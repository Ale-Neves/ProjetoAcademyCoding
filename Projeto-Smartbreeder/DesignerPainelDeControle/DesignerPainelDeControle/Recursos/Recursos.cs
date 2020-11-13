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

namespace DesignerPainelDeControle.Recursos
{
    public partial class fmrRecursos : Form
    {
        // CHAMANDO CONEXAO COM BANCO E EXECUTANDO INSTRUÇÕES.
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string id;
        string cpfAntigo, nomeAntigo;

        public fmrRecursos()
        {
            InitializeComponent();
        }
        private void fmrRecursos_Load(object sender, EventArgs e)
        {
            btnAdicionar.Enabled = true;
            btnPesquisar.Enabled = true;
            rbNome.Checked = true;
            txtNomeBuscar.Focus();

            chamapainel();
            ativaCamposPesquisar();
            desativaCamposAdicionar();
        }

        //*************************** BOTÃO ADICIONAR ***************************************
        private void ativaCamposAdicionar()
        {
            btnNome.Enabled = true;
            txtNome.Enabled = true;
            btnCPF.Enabled = true;
            mtxtCPF.Enabled = true;
            btnTelefone.Enabled = true;
            mtxtTelefone.Enabled = true;
            btnCargo.Enabled = true;
            txtCargo.Enabled = true;
        }
        private void desativaCamposAdicionar()
        {
            btnNome.Enabled = false;
            txtNome.Enabled = false;
            btnCPF.Enabled = false;
            mtxtCPF.Enabled = false;
            btnTelefone.Enabled = false;
            mtxtTelefone.Enabled = false;
            btnCargo.Enabled = false;
            txtCargo.Enabled = false;
        }
        private void limparCamposAdicionar()
        {
            txtNome.Text = "";
            mtxtCPF.Text = "";
            mtxtTelefone.Text = "";
            txtCargo.Text = "";
        }
        private void chamapainel()
        {
            pnAdicionarRecursos.Visible = true;
            Listar();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
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
        public void btnPesquisar_Click(object sender, EventArgs e)
        {
            ativaCamposPesquisar();
            txtNomeBuscar.Focus();
            rbNome.Checked = true;

            btnAlterar.Enabled = false;
            btnDeletar.Enabled = false;
            btnSalvar.Enabled = false;
        }
        private void PesquisarNome()
        {
            con.abrirConexao();
            sql = "SELECT * FROM dbo_recursos where nome_recurso LIKE @nome order by nome_recurso asc";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNomeBuscar.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            gridProjetos.DataSource = dt;
            FormatarDG();
            con.fecharConexao();

            FormatarDG();
        }
        private void PesquisarCPF()
        {
            con.abrirConexao();
            sql = "SELECT * FROM dbo_recursos where cpf_recurso LIKE @cpf order by cpf_recurso asc";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@cpf", mtxtCPFBuscar.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            gridProjetos.DataSource = dt;
            FormatarDG();
            con.fecharConexao();

            FormatarDG();
        }
        private void txtNomeBuscar_TextChanged(object sender, EventArgs e)
        {
            PesquisarNome();
        }
        private void mtxtCPFBuscar_TextChanged(object sender, EventArgs e)
        {
            if (mtxtCPFBuscar.Text == "  /  /")
            {
                Listar();
            }
            else
            {
                PesquisarCPF();
            }
        }
        private void ativaCamposPesquisar()
        {
            btnBuscar.Visible = true;
            rbNome.Visible = true;
            txtNomeBuscar.Visible = true;
            rbCPF.Visible = true;
            mtxtCPFBuscar.Visible = true;

            desativaCamposAdicionar();
        }
        private void desativaCamposPesquisar()
        {
            ativaCamposAdicionar();
            btnBuscar.Visible = false;
            rbNome.Visible = false;
            txtNomeBuscar.Visible = false;
            rbCPF.Visible = false;
            mtxtCPFBuscar.Visible = false;
        }
        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            mtxtCPFBuscar.Enabled = true;
            txtNomeBuscar.Enabled = false;
            txtNomeBuscar.Text = "";
            mtxtCPFBuscar.Text = "";
        }
        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            mtxtCPFBuscar.Enabled = false;
            txtNomeBuscar.Enabled = true;

            txtNomeBuscar.Text = "";
            mtxtCPFBuscar.Text = "";
        }
        //----------------------------------------------------------------------------------//

        //*************************** BOTÃO EDITAR ******************************************
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;

            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Nome Obrigatorio!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (mtxtCPF.Text == "   .   .   -")
            {
                MessageBox.Show("CPF Obrigatorio!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }
            if (txtCargo.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Cargo Obrigatorio!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCargo.Text = "";
                txtCargo.Focus();
                return;
            }

            //PROGRAMANDO O BOTÃO EDITAR
            con.abrirConexao();
            sql = "UPDATE dbo_recursos SET nome_recurso = @nome, cpf_recurso = @cpf, telefone_recurso = @telefone , cargo_recurso = @cargo where id_recurso = @id";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cpf", mtxtCPF.Text);
            cmd.Parameters.AddWithValue("@telefone", mtxtTelefone.Text);
            cmd.Parameters.AddWithValue("@cargo", txtCargo.Text);
            cmd.Parameters.AddWithValue("@id", id);

            if (mtxtCPF.Text != cpfAntigo)
            {
                MySqlCommand cmdVerificarCPF;
                cmdVerificarCPF = new MySqlCommand("SELECT * FROM dbo_recursos where cpf_recurso = @cpf", con.con);
                cmdVerificarCPF.Parameters.AddWithValue("@cpf", mtxtCPF.Text);
                MySqlDataAdapter da2 = new MySqlDataAdapter();
                da2.SelectCommand = cmdVerificarCPF;
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);

                if (dt2.Rows.Count > 0)
                {
                    MessageBox.Show("Usuário já Registrado!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mtxtCPF.Text = "";
                    mtxtCPF.Focus();
                    return;
                }
            }

            cmd.ExecuteNonQuery();
            con.fecharConexao();

            MessageBox.Show("Editado com Sucesso!", "Dados Editados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparCamposAdicionar();
            txtNome.Focus();
            btnAlterar.Enabled = false;
            btnDeletar.Enabled = false;
            Listar();
        }
        //----------------------------------------------------------------------------------//

        //*************************** BOTÃO EXCLUIR ******************************************
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            var resultado = MessageBox.Show("Deseja Realmente Excluir?", "Recurso Excluido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                //PROGRAMANDO O BOTÃO EDITAR
                con.abrirConexao();
                sql = "DELETE FROM dbo_recursos where id_recurso = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.fecharConexao();


                MessageBox.Show("Recurso Excluido com Sucesso!", "Recurso Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAlterar.Enabled = false;
                btnDeletar.Enabled = false;
                Listar();
            }
        }
        //-----------------------------------------------------------------------------------//

        //*************************** BOTÃO SALVAR ******************************************
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Nome Obrigatorio!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (mtxtCPF.Text == "   .   .   -")
            {
                MessageBox.Show("CPF Obrigatorio!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }
            if (txtCargo.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Cargo Obrigatorio!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCargo.Text = "";
                txtCargo.Focus();
                return;
            }

            //PROGRAMANDO O BOTÃO SALVAR.
            con.abrirConexao();
            sql = "INSERT INTO dbo_recursos (nome_recurso, cpf_recurso, telefone_recurso, cargo_recurso) VALUES (@nome, @cpf, @telefone, @cargo)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cpf", mtxtCPF.Text);
            cmd.Parameters.AddWithValue("@telefone", mtxtTelefone.Text);
            cmd.Parameters.AddWithValue("@cargo", txtCargo.Text);


            //VERIFICA SE RECURSO JA EXISTE.
            MySqlCommand cmdVerificarNome;
            MySqlCommand cmdVerificarCPF;
            cmdVerificarNome = new MySqlCommand("SELECT * FROM dbo_recursos where nome_recurso = @nome", con.con);
            cmdVerificarCPF = new MySqlCommand("SELECT * FROM dbo_recursos where cpf_recurso = @cpf", con.con);
            cmdVerificarNome.Parameters.AddWithValue("@nome", txtNome.Text);
            cmdVerificarCPF.Parameters.AddWithValue("@cpf", mtxtCPF.Text);
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlDataAdapter da2 = new MySqlDataAdapter();
            da.SelectCommand = cmdVerificarNome;
            da2.SelectCommand = cmdVerificarCPF;
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            da.Fill(dt);
            da2.Fill(dt2);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Usuário já Registrado!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (dt2.Rows.Count > 0)
            {
                MessageBox.Show("Usuário já Registrado!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtxtCPF.Text = "";
                mtxtCPF.Focus();
                return;
            }

            cmd.ExecuteNonQuery();
            con.fecharConexao();

            MessageBox.Show("Salvo com Sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparCamposAdicionar();
            btnAdicionar.Enabled = true;
            txtNome.Focus();
            Listar();
        }
        //----------------------------------------------------------------------------------//

        //*************************** DATA GRID RECURSOS ************************************
        public void Listar()
        {
            con.abrirConexao();
            sql = "SELECT * FROM dbo_recursos order by nome_recurso asc";
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
            gridProjetos.Columns[1].HeaderText = "NOME";
            gridProjetos.Columns[2].HeaderText = "CPF";
            gridProjetos.Columns[3].HeaderText = "TELEFONE";
            gridProjetos.Columns[4].HeaderText = "CARGO";

            gridProjetos.Columns[0].Width = 40;
            gridProjetos.Columns[1].Width = 155;
            gridProjetos.Columns[2].Width = 155;
            gridProjetos.Columns[3].Width = 155;
            gridProjetos.Columns[4].Width = 230;
        }
        private void gridProjetos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = gridProjetos.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = gridProjetos.CurrentRow.Cells[1].Value.ToString();
            mtxtCPF.Text = gridProjetos.CurrentRow.Cells[2].Value.ToString();
            mtxtTelefone.Text = gridProjetos.CurrentRow.Cells[3].Value.ToString();
            txtCargo.Text = gridProjetos.CurrentRow.Cells[4].Value.ToString();

            nomeAntigo = gridProjetos.CurrentRow.Cells[1].Value.ToString();
            cpfAntigo = gridProjetos.CurrentRow.Cells[2].Value.ToString();

            btnAlterar.Enabled = true;
            btnDeletar.Enabled = true;
            btnSalvar.Enabled = false;
            ativaCamposAdicionar();
            txtNome.Focus();
        }
        //-----------------------------------------------------------------------------------//
    }
}
