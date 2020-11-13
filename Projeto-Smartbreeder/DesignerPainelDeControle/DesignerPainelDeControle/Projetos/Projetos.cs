using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignerPainelDeControle
{
    public partial class fmrProjetos : Form
    {
        public fmrProjetos()
        {
            InitializeComponent();
        }

        // CHAMANDO CONEXAO COM BANCO E EXECUTANDO INSTRUÇÕES.
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string id; string idTarefa;

        private void fmrProjetos_Load(object sender, EventArgs e)
        {
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            chamapainel();
            desativaCamposAdicionar();
            ativaCamposPesquisar();
        }

        //*************************** BOTÃO ADICIONAR ****************************************
        private void ativaCamposAdicionar()
        {
            btnNome.Enabled = true;
            txtNome.Enabled = true;
            btnGestor.Enabled = true;
            txtGestor.Enabled = true;
            btnDataInicio.Enabled = true;
            mtxtDataInicial.Enabled = true;
        }
        private void desativaCamposAdicionar()
        {
            btnNome.Enabled = false;
            txtNome.Enabled = false;
            btnGestor.Enabled = false;
            txtGestor.Enabled = false;
            btnDataInicio.Enabled = false;
            mtxtDataInicial.Enabled = false;
        }
        private void limparCamposAdicionar()
        {
            txtNome.Text = "";
            txtGestor.Text = "";
            mtxtDataInicial.Text = "";    
        }
        private void chamapainel()
        {
            pnNovoProjeto.Visible = true;
            Listar();
        }
        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnDeletar.Enabled = false;

            txtNome.Focus();

            ativaCamposAdicionar();
            desativaCamposPesquisar();
            limparCamposAdicionar();
        }
        //----------------------------------------------------------------------------------//

        //*************************** BOTÃO PESQUISAR ***************************************
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ativaCamposPesquisar();
            txtBuscarNome.Focus();
            rbNome.Checked = true;
            btnAlterar.Enabled = false;
            btnDeletar.Enabled = false;
            btnSalvar.Enabled  = false; 
        }
        private void PesquisarNome()
        {
            con.abrirConexao();
            sql = "SELECT * FROM dbo_projetos where nome_projeto LIKE @nome order by nome_projeto asc";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtBuscarNome.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            gridProjetos.DataSource = dt;
            FormatarDG();
            con.fecharConexao();
            FormatarDG();
        }
        private void PesquisarData()
        {
            con.abrirConexao();
            sql = "SELECT * FROM dbo_projetos where dataInicio_projeto LIKE @dataInicio order by dataInicio_projeto asc";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@dataInicio", mtxtBuscarData.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            gridProjetos.DataSource = dt;
            FormatarDG();
            con.fecharConexao();

            FormatarDG();
        }
        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            PesquisarNome();
        }
        private void mtxtBuscarData_TextChanged(object sender, EventArgs e)
        {
            if (mtxtBuscarData.Text == "  /  /")
            {
                Listar();
            }
            else
            { 
                PesquisarData();
            }
        }
        private void ativaCamposPesquisar()
        {
            txtBuscarNome.Focus();
            rbNome.Checked = true;
            btnBuscar.Visible = true;
            rbNome.Visible = true;
            txtBuscarNome.Visible = true;
            rbDataInicio.Visible = true;
            mtxtBuscarData.Visible = true;

            desativaCamposAdicionar();
        }
        private void desativaCamposPesquisar()
        {
            ativaCamposAdicionar();
            btnBuscar.Visible = false;
            rbNome.Visible = false;
            txtBuscarNome.Visible = false;
            rbDataInicio.Visible = false;
            mtxtBuscarData.Visible = false;
        }
        private void rbDataInicio_CheckedChanged(object sender, EventArgs e)
        {
            mtxtBuscarData.Enabled = true;
            txtBuscarNome.Enabled = false;
            txtBuscarNome.Text = "";
            mtxtBuscarData.Text = "";
        }
        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            mtxtBuscarData.Enabled = false;
            txtBuscarNome.Enabled = true;

            txtBuscarNome.Text = "";
            mtxtBuscarData.Text = "";
        }
        //----------------------------------------------------------------------------------//

        //*************************** BOTÃO SALVAR ******************************************
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Nome Obrigatorio!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (txtGestor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Gestor Obrigatorio!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGestor.Text = "";
                txtGestor.Focus();
                return;
            }
            if (mtxtDataInicial.Text.ToString().Trim() == "__/__/____")
            {
                MessageBox.Show("Data Inicial Obrigatoria!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtxtDataInicial.Text = "__/__/____";
                mtxtDataInicial.Focus();
                return;
            }

            //PROGRAMANDO O BOTÃO SALVAR
            con.abrirConexao();
            sql = "INSERT INTO dbo_projetos (nome_projeto, gestor_projeto, dataInicio_projeto) VALUES (@nome, @gestor, @dataInicial)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@gestor", txtGestor.Text);
            cmd.Parameters.AddWithValue("@dataInicial", mtxtDataInicial.Text);
            cmd.ExecuteNonQuery();
            con.fecharConexao();

            MessageBox.Show("Salvo com Sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparCamposAdicionar();
            txtNome.Focus();
            Listar();
        }
        //----------------------------------------------------------------------------------//

        //*************************** BOTÃO EDITAR ******************************************
        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;

            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Nome Obrigatorio!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (txtGestor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Gestor Obrigatorio!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGestor.Text = "";
                txtGestor.Focus();
                return;
            }
            if (mtxtDataInicial.Text.ToString().Trim() == "__/__/____")
            {
                MessageBox.Show("Data Inicial Obrigatoria!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtxtDataInicial.Text = "__/__/____";
                mtxtDataInicial.Focus();
                return;
            }

            //PROGRAMANDO O BOTÃO EDITAR
            con.abrirConexao();
            sql = "UPDATE dbo_projetos SET nome_projeto = @nome, gestor_projeto = @gestor, dataInicio_projeto = @dataInicio where id_projeto = @id";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@gestor", txtGestor.Text);
            cmd.Parameters.AddWithValue("@dataInicio", mtxtDataInicial.Text);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.fecharConexao();

            MessageBox.Show("Editado com Sucesso!", "Projeto Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparCamposAdicionar();
            txtNome.Focus();
            btnAlterar.Enabled = false;
            btnDeletar.Enabled = false;
            btnSalvar.Enabled = true;
            Listar();
        }
        //----------------------------------------------------------------------------------//

        //*************************** BOTÃO EXCLUIR ******************************************
        private void btnDeletar_Click_1(object sender, EventArgs e)
            {
                btnSalvar.Enabled = false;

                var resultado = MessageBox.Show("Deseja Realmente Excluir?", "Projeto Excluido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    //PROGRAMANDO O BOTÃO EXCLUIR
                    con.abrirConexao();
                    sql = "DELETE FROM dbo_projetos where id_projeto = @id";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    con.fecharConexao();
                    limparCamposAdicionar();

                    MessageBox.Show("Projeto Excluido com Sucesso!", "Projeto Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAlterar.Enabled = false;
                    btnDeletar.Enabled = false;
                    btnSalvar.Enabled = true;
                    Listar();
                }
                
            }
        //----------------------------------------------------------------------------------//

        //*************************** DATA GRID RECURSOS ************************************
        private void ListarTarefa()
        {
            if (id == idTarefa)
            {
                btnMensagem.Visible = false;
                btnListaTarefas.Visible = true;
                con.abrirConexao();
                sql = "SELECT id_tarefa, tarf.nome_tarefa, tarf.dataInicial_tarefa, tarf.dataFinal_tarefa, tarf.duracao_tarefa, tarf.porcentagem_concluida_tarefa, rec.nome_recurso FROM dbo_atividades as tarf INNER JOIN dbo_recursos as rec ON tarf.recurso = rec.id_recurso where tarf.projeto = " + idTarefa + " order by tarf.id_tarefa asc";                                                                                                                               //                  sql = "SELECT * FROM dbo_projetos where dataInicio_projeto LIKE @dataInicio order by dataInicio_projeto asc";
                cmd = new MySqlCommand(sql, con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;

                DataTable dt = new DataTable();
                da.Fill(dt);
                gridTarefasProjeto.DataSource = dt;
                FormatarDG2();
                con.fecharConexao();
            }

        }
        public  void Listar()
        {
            con.abrirConexao();
            sql = "SELECT * FROM dbo_projetos order by id_projeto asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            gridProjetos.DataSource = dt;
            FormatarDG();
            con.fecharConexao();
        }
        private void FormatarDG()
        { 
            gridProjetos.Columns[0].HeaderText = "ID";
            gridProjetos.Columns[1].HeaderText = "NOME PROJETO";
            gridProjetos.Columns[2].HeaderText = "GESTOR PROJETO";
            gridProjetos.Columns[3].HeaderText = "DATA INICIAL";

            gridProjetos.Columns[0].Width = 40;
            gridProjetos.Columns[1].Width = 300;
            gridProjetos.Columns[2].Width = 200;
            gridProjetos.Columns[3].Width = 150;
        }
        private void FormatarDG2()
        {
            gridTarefasProjeto.Columns[0].HeaderText = "ID";
            gridTarefasProjeto.Columns[1].HeaderText = "NOME TAREFA";
            gridTarefasProjeto.Columns[2].HeaderText = "DATA INICIAL";
            gridTarefasProjeto.Columns[3].HeaderText = "DATA FINAL";
            gridTarefasProjeto.Columns[4].HeaderText = "DURACAO";
            gridTarefasProjeto.Columns[5].HeaderText = "COMPLETO %";
            gridTarefasProjeto.Columns[6].HeaderText = "RECURSO";

            gridTarefasProjeto.Columns[0].Width = 40;
            gridTarefasProjeto.Columns[1].Width = 230;
            gridTarefasProjeto.Columns[2].Width = 120;
            gridTarefasProjeto.Columns[3].Width = 120;
            gridTarefasProjeto.Columns[4].Width = 100;
            gridTarefasProjeto.Columns[5].Width = 120;
            gridTarefasProjeto.Columns[6].Width = 200;

            gridTarefasProjeto.Columns[0].Visible = false;  
        }
        private void gridProjetos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = gridProjetos.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = gridProjetos.CurrentRow.Cells[1].Value.ToString();
            txtGestor.Text = gridProjetos.CurrentRow.Cells[2].Value.ToString();
            mtxtDataInicial.Text = gridProjetos.CurrentRow.Cells[3].Value.ToString();
            idTarefa = gridProjetos.CurrentRow.Cells[0].Value.ToString();

            btnAlterar.Enabled = true;
            btnDeletar.Enabled = true;
            btnSalvar.Enabled = false;
            ativaCamposAdicionar();
            txtNome.Focus();
            ListarTarefa();
        }
        private void gridTarefasProjeto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridTarefasProjeto.Columns[e.ColumnIndex].Name == "porcentagem_concluida_tarefa")
            {
                string r = "porcentagem_concluida_tarefa";

                if ( Convert.ToInt32(e.Value) <= 25)
                {
                    DataGridViewRow roww = gridTarefasProjeto.Rows[e.RowIndex];
                    roww.DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                if ((r == "porcentagem_concluida_tarefa") && (Convert.ToInt32(e.Value) > 25) && (Convert.ToInt32(e.Value) <= 70))
                {
                    DataGridViewRow roww = gridTarefasProjeto.Rows[e.RowIndex];
                    roww.DefaultCellStyle.BackColor = Color.GreenYellow;
                }
                if ((r == "porcentagem_concluida_tarefa") && (Convert.ToInt32(e.Value) > 70))
                {
                    DataGridViewRow roww = gridTarefasProjeto.Rows[e.RowIndex];
                    roww.DefaultCellStyle.BackColor = Color.MediumSpringGreen;
                }
            }
        }
        //----------------------------------------------------------------------------------//
    }
}
