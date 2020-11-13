using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignerPainelDeControle.Email
{
    public partial class frmEnviarCronograma : Form
    {
        public frmEnviarCronograma()
        {
            InitializeComponent();
        }
        private void frmEnviarReport_Load(object sender, EventArgs e)
        { 
            txtPara.Focus();
        }
        private void ativaCamposAdicionar()
        {
            btnPara.Enabled = true;
            txtPara.Enabled = true;
            btnCc.Enabled = true;
            txtCc.Enabled = true;
            btnCco.Enabled = true;
            txtCco.Enabled = true;
            txtAssunto.Enabled = true;
            btnAssunto.Enabled = true;
            txtAnexo.Enabled = true;
            btnAnexo.Enabled = true;
            txtMensagem.Enabled = true;
            btnMensagem.Enabled = true;
        }
        private void limparCamposAdicionar()
        {
            txtPara.Text = "";
            txtCc.Text = "";
            txtCco.Text = "";
            txtAssunto.Text = "";
            txtAnexo.Text = "";
            txtMensagem.Text = "";
        }

        //********************* BOTOES ************************************
        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtPara.Focus();
            ativaCamposAdicionar();
            limparCamposAdicionar();
        }
        private void btnAnexar_Click(object sender, EventArgs e)
        {
            EnviarEmail();
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja Realmente Excluir?", "Email Excluido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                limparCamposAdicionar();
            }
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            CamposPreenchidos();
        }
        //---------------------------------------------------------------//

        //******************* ENVIO DO EMAIL ******************************
        public void EnviarEmail()
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtAnexo.Text = open.FileName;
            }
        }
        private bool CamposPreenchidos()
        {
            if(string.IsNullOrWhiteSpace(txtPara.Text))
            {
                MessageBox.Show("O Camopo (PARA) está vazio!!");
                return false;
            }
            else
            {
                MessageBox.Show("Sua Mensagem foi enviada com Sucesso!");
                Email();
                return true;
            }
        }
        public void Email()
        {
            EnvioDeEmail email = new EnvioDeEmail();
            email.EnviodeEmail(txtPara.Text, txtCc.Text, txtCco.Text, txtMensagem.Text, txtAssunto.Text, txtAnexo.Text);
        }
        //---------------------------------------------------------------//
    }
}
