using DesignerPainelDeControle.Recursos;
using DesignerPainelDeControle.Tarefas;
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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        //********************** INSTANCIAÇÕES DE OBJETOS *****************************
        fmrProjetos frmProjetos = new fmrProjetos();
        fmrTarefas frmTarefas = new fmrTarefas();
        fmrRecursos frmRecursos = new fmrRecursos();
        Relatorios.frmCronograma frmRelProjetos = new Relatorios.frmCronograma();
        Email.frmEnviarCronograma frmEnviarReport = new Email.frmEnviarCronograma();
        //----------------------------------------------------------------------------//

        //*********************** DIMENSÕES DO PROJETO ********************************
        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            // Estado da Janela do Windows recebe Minimizado
            WindowState = FormWindowState.Minimized;
        }
        private void pbRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pbRestaurar.Visible = false; // Desativa o Botão Restaurar.
            pbMaximizar.Visible = true; // Ativa o Botão Maximizar.
        }
        private void pbSair_Click(object sender, EventArgs e)
        {
            // Aplica o metodo sair ao clicar. 
            Application.Exit();
        }
        private void pbMenuBarraLateral_Click(object sender, EventArgs e)
        {
            if (pnBarraLateral.Width == 232)
            {
                pnBarraLateral.Visible = true;
                pnBarraLateral.Width = 95;
                pnCentral.Location = new Point(95, 50);
                pnCentral.Width += 135;
                pbLogo.Visible = false;
                pbLogo2.Visible = true;
                btAnimacaoBarraLateral.Show(pnBarraLateral);
            }
            else
            {
                pnBarraLateral.Visible = false;
                pnBarraLateral.Width = 232;
                pnCentral.Location = new Point(232, 50);
                pnCentral.Width -= 135;
                pbLogo.Visible = true;
                pbLogo2.Visible = false;
                bsFaixaLogo.Width = 190;

                btAnimacaoBarraLateral.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
                btAnimacaoBarraLateral.Show(pnBarraLateral);
            }
        }
        private void AbrirFormProjetoNoPainel(object FormHijo)
        {
            if (this.pnCentral.Controls.Count > 0)
            {
                this.pnCentral.Controls.RemoveAt(0);
            }

            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnCentral.Controls.Add(fh);
            this.pnCentral.Tag = fh;
            fh.Show();
        }
        //----------------------------------------------------------------------------//

        //*************** BOTOES DE OPÇÕES *********************************************
        private void bfbProjetos_Click(object sender, EventArgs e)
        {
            AbrirFormProjetoNoPainel(frmProjetos);
        }
        private void bfbTarefas_Click(object sender, EventArgs e)
        {
            AbrirFormProjetoNoPainel(frmTarefas);
            frmTarefas.Listar();
            frmTarefas.CarregarComboBox();
            frmTarefas.CarregarComboBoxProjetos();
        }
        private void bfbRecursos_Click(object sender, EventArgs e)
        {
            AbrirFormProjetoNoPainel(frmRecursos);
            frmRecursos.Listar();
        }
        private void bfbRelatorios_Click(object sender, EventArgs e)
        {
            AbrirFormProjetoNoPainel(frmRelProjetos);
        }
        private void bfbEnviarReport_Click(object sender, EventArgs e)
        {
            AbrirFormProjetoNoPainel(frmEnviarReport);
        }
        //----------------------------------------------------------------------------//
    }
}
