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

namespace DesignerPainelDeControle.Tarefas
{
    public partial class fmrTarefas : Form
    {
        public fmrTarefas()
        {
            InitializeComponent();
        }

        // CHAMANDO CONEXAO COM BANCO E EXECUTANDO INSTRUÇÕES.
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string id;

        public void CarregarComboBox()
        {
            con.abrirConexao();
            sql = "SELECT * FROM dbo_recursos order by nome_recurso asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            cbRecurso.DataSource = dt;
            cbRecurso.ValueMember = "id_recurso";
            cbRecurso.DisplayMember = "nome_recurso";
            con.fecharConexao();
        }
        public void CarregarComboBoxProjetos()
        {
            con.abrirConexao();
            sql = "SELECT * FROM dbo_projetos order by nome_projeto asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            cbProjeto.DataSource = dt;
            cbProjeto.ValueMember = "id_projeto";
            cbProjeto.DisplayMember = "nome_projeto";
            con.fecharConexao();
        }
        private void fmrTarefas_Load_1(object sender, EventArgs e)
        {
            btnNova.Enabled = true;
            btnPesquisar.Enabled = true;   
            rbNome.Checked = true;
            txtBuscarNome.Focus();

            CarregarComboBox();
            CarregarComboBoxProjetos();
            chamapainel();
            ativaCamposPesquisar();
            desativaCamposAdicionar();  
        }

        //*************************** BOTÃO ADICIONAR ****************************************** 
        private void ativaCamposAdicionar()
        {
            txtProjeto.Enabled = true;
            cbProjeto.Enabled = true;
            btnNome.Enabled = true;
            txtNome.Enabled = true;
            btnDataInicial.Enabled = true;
            mtxtDataInicial.Enabled = true;
            btnDataFinal.Enabled = true;
            mtxtDataFinal.Enabled = true;
            btnDuracao.Enabled = true;
            mtxtDuracao.Enabled = true;
            btnAntecessor.Enabled = true;
            txtAntecessor.Enabled = true;
            btnRecurso.Enabled = true;
            cbRecurso.Enabled = true;
        }
        private void desativaCamposAdicionar()
        {
            txtProjeto.Enabled = false;
            cbProjeto.Enabled = false;
            btnNome.Enabled = false;
            txtNome.Enabled = false;
            btnDataInicial.Enabled = false;
            mtxtDataInicial.Enabled = false;
            btnDataFinal.Enabled = false;
            mtxtDataFinal.Enabled = false;
            btnDuracao.Enabled = false;
            mtxtDuracao.Enabled = false;
            btnAntecessor.Enabled = false;
            txtAntecessor.Enabled = false;
            btnRecurso.Enabled = false;
            cbRecurso.Enabled = false;
        }
        public  void limparCamposAdicionar()
        {
            txtNome.Text = "";
            cbProjeto.Text = "SELECIONE O PROJETO";
            mtxtDataInicial.Text = "";
            mtxtDataFinal.Text = "";
            mtxtDuracao.Text = "";
            txtAntecessor.Text = "";
            cbRecurso.Text = "SELECIONE";
        }
        private void chamapainel()
        {
             pnAdicionarTarefas.Visible = true;
             Listar();
        }
        private void btnNova_Click(object sender, EventArgs e)
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

        //*************************** BOTÃO PESQUISAR ****************************************
        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            ativaCamposPesquisar();
            txtBuscarNome.Focus();
            rbNome.Checked = true;

            btnAlterar.Enabled = false;
            btnDeletar.Enabled = false;
            btnSalvar.Enabled = false;
        }
        private void PesquisarNome()
        {
            con.abrirConexao();
            sql = "SELECT * FROM dbo_atividades where nome_tarefa LIKE @nome order by nome_tarefa asc";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtBuscarNome.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            gridTarefas.DataSource = dt;
            FormatarDG();
            con.fecharConexao();

            FormatarDG();         
        }
        private void PesquisarData()
        {
            con.abrirConexao();
            sql = "SELECT * FROM dbo_atividades where dataInicial_tarefa LIKE @dataInicial order by dataInicial_tarefa asc";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@dataInicial", mtxtBuscarData.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            gridTarefas.DataSource = dt;
            FormatarDG();
            con.fecharConexao();

            FormatarDG();
        }
        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            PesquisarNome();
        }
        private void mtxtDataBuscar_TextChanged(object sender, EventArgs e)
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
        private void ativaCamposPesquisar()
        {
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
        //----------------------------------------------------------------------------------//

        //*************************** BOTÃO EDITAR ******************************************
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;

            if (cbProjeto.Text == "SELECIONE O PROJETO")
            {
                MessageBox.Show("Projeto Obrigatorio!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbProjeto.Text = "SELECIONE O PROJETO";
                cbProjeto.Focus();
                return;
            }
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Nome Obrigatorio!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;

            }
            if (cbRecurso.Text == "SELECIONE")
            {
                MessageBox.Show("Recurso Obrigatorio!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbRecurso.Text = "SELECIONE";
                cbRecurso.Focus();
                return;
            }

            //PROGRAMANDO O BOTÃO EDITAR
            con.abrirConexao();
            sql = "UPDATE dbo_atividades SET projeto = @projeto, nome_tarefa = @nome, dataInicial_tarefa = @dataInicial, dataFinal_tarefa = @dataFinal, duracao_tarefa = @duracao, porcentagem_concluida_tarefa = @porcentagem_concluida_tarefa, recurso = @recurso where id_tarefa = @id";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@projeto", cbProjeto.SelectedValue);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@dataInicial", mtxtDataInicial.Text);
            cmd.Parameters.AddWithValue("@dataFinal", mtxtDataFinal.Text);
            cmd.Parameters.AddWithValue("@duracao", mtxtDuracao.Text);
            cmd.Parameters.AddWithValue("@porcentagem_concluida_tarefa", txtAntecessor.Text);
            cmd.Parameters.AddWithValue("@recurso", cbRecurso.SelectedValue);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.fecharConexao();

            MessageBox.Show("Editado com Sucesso!", "Tarefa Editada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparCamposAdicionar();
            txtNome.Focus();
            btnAlterar.Enabled = false;
            btnDeletar.Enabled = false;
            btnSalvar.Enabled = true;
            Listar();
        }
        //----------------------------------------------------------------------------------//

        //*************************** BOTÃO EXCLUIR ******************************************
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;

            var resultado = MessageBox.Show("Deseja Realmente Excluir?", "Tarefa Excluido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                //PROGRAMANDO O BOTÃO EXCLUIR
                con.abrirConexao();
                sql = "DELETE FROM dbo_atividades where id_tarefa = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.fecharConexao();
                limparCamposAdicionar();

                MessageBox.Show("Tarefa Excluida com Sucesso!", "Tarefa Excluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAlterar.Enabled = false;
                btnDeletar.Enabled = false;
                btnSalvar.Enabled = true;
                Listar();
            }
        }
        //----------------------------------------------------------------------------------//

        //*************************** BOTÃO SALVAR ******************************************
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cbProjeto.Text == "SELECIONE O PROJETO")
            {
                MessageBox.Show("Projeto Obrigatorio!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbProjeto.Text = "SELECIONE O PROJETO";
                cbProjeto.Focus();
                return;
            }
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Nome Obrigatorio!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (cbRecurso.Text == "SELECIONE")
            {
                MessageBox.Show("Recurso Obrigatorio!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbRecurso.Text = "SELECIONE";
                cbRecurso.Focus();
                return;
            }

            //PROGRAMANDO O BOTÃO SALVAR
            con.abrirConexao();
            sql = "INSERT INTO dbo_atividades (projeto, nome_tarefa, dataInicial_tarefa, dataFinal_tarefa, duracao_tarefa, porcentagem_concluida_tarefa, recurso) VALUES (@projeto, @nome, @dataInicial, @dataFinal, @duracao, @porcentagem_concluida_tarefa, @recurso)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@projeto", cbProjeto.SelectedValue);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@dataInicial", mtxtDataInicial.Text);
            cmd.Parameters.AddWithValue("@dataFinal", mtxtDataFinal.Text);
            cmd.Parameters.AddWithValue("@duracao", mtxtDuracao.Text);
            cmd.Parameters.AddWithValue("@porcentagem_concluida_tarefa", txtAntecessor.Text);
            cmd.Parameters.AddWithValue("@recurso", cbRecurso.SelectedValue);
            cmd.ExecuteNonQuery();
            con.fecharConexao();


            MessageBox.Show("Salvo com Sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparCamposAdicionar();
            btnNova.Enabled = true;
            txtNome.Focus();
            Listar();
        }
        //----------------------------------------------------------------------------------//

        //*************************** DATA GRID RECURSOS *************************************
        public  void Listar()
        {
            //aqui eu fiz um novo inner join para lincar o nome do projeto, ai la no grid ele vai buscar o nome
            con.abrirConexao();
            sql = "SELECT id_tarefa, projeto.nome_projeto, tarf.nome_tarefa, tarf.dataInicial_tarefa, tarf.dataFinal_tarefa, " +
                "tarf.duracao_tarefa, tarf.porcentagem_concluida_tarefa, rec.nome_recurso FROM dbo_atividades as tarf INNER JOIN " +
                "dbo_recursos as rec ON tarf.recurso = rec.id_recurso INNER JOIN dbo_projetos projeto on tarf.projeto = projeto.id_projeto order by tarf.id_tarefa asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridTarefas.DataSource = dt;
            FormatarDG();
            con.fecharConexao();
        }
        private void FormatarDG()
        {
            gridTarefas.Columns[0].HeaderText = "ID";
            gridTarefas.Columns[1].HeaderText = "NOME PROJETO";
            gridTarefas.Columns[2].HeaderText = "NOME TAREFA";
            gridTarefas.Columns[3].HeaderText = "DATA INICIAL";
            gridTarefas.Columns[4].HeaderText = "DATA FINAL";
            gridTarefas.Columns[5].HeaderText = "DURACAO";
            gridTarefas.Columns[6].HeaderText = "COMPLETO %";
            gridTarefas.Columns[7].HeaderText = "RECURSO";

            gridTarefas.Columns[0].Width = 40;
            gridTarefas.Columns[1].Width = 155;
            gridTarefas.Columns[2].Width = 155;
            gridTarefas.Columns[3].Width = 100;
            gridTarefas.Columns[4].Width = 100;
            gridTarefas.Columns[5].Width = 80;
            gridTarefas.Columns[6].Width = 100;
            gridTarefas.Columns[7].Width = 155;

            gridTarefas.Columns[0].Visible = false;
        }   
        private void gridTarefas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id = gridTarefas.CurrentRow.Cells[0].Value.ToString();
            cbProjeto.Text = gridTarefas.CurrentRow.Cells[1].Value.ToString();
            txtNome.Text = gridTarefas.CurrentRow.Cells[2].Value.ToString();
            mtxtDataInicial.Text = gridTarefas.CurrentRow.Cells[3].Value.ToString();
            mtxtDataFinal.Text = gridTarefas.CurrentRow.Cells[4].Value.ToString();
            mtxtDuracao.Text = gridTarefas.CurrentRow.Cells[5].Value.ToString();
            txtAntecessor.Text = gridTarefas.CurrentRow.Cells[6].Value.ToString();
            cbRecurso.Text = gridTarefas.CurrentRow.Cells[7].Value.ToString();

            btnAlterar.Enabled = true;
            btnDeletar.Enabled = true;
            btnSalvar.Enabled = false;
            ativaCamposAdicionar();
            txtNome.Focus();
        }
        private void gridTarefas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridTarefas.Columns[e.ColumnIndex].Name == "porcentagem_concluida_tarefa")
            {
                if (Convert.ToInt32(e.Value) <= 25)
                {
                    DataGridViewRow roww = gridTarefas.Rows[e.RowIndex];
                    roww.DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                if (Convert.ToInt32(e.Value) > 25 && Convert.ToInt32(e.Value) <= 70)
                {
                    DataGridViewRow roww = gridTarefas.Rows[e.RowIndex];
                    roww.DefaultCellStyle.BackColor = Color.GreenYellow;
                }
                if (Convert.ToInt32(e.Value) > 70)
                {
                    DataGridViewRow roww = gridTarefas.Rows[e.RowIndex];
                    roww.DefaultCellStyle.BackColor = Color.MediumSpringGreen;
                }
            }
        }
        //----------------------------------------------------------------------------------//
    }
}
