using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignerPainelDeControle.Relatorios
{
    public partial class frmCronograma : Form
    {
        public frmCronograma()
        {
            InitializeComponent();
        }

        private void frmRelProjetos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cronogramaDataSet1.dbo_atividades_projeto_recurso'. Você pode movê-la ou removê-la conforme necessário.
            this.dbo_atividades_projeto_recursoTableAdapter.Fill(this.cronogramaDataSet1.dbo_atividades_projeto_recurso);
            // TODO: esta linha de código carrega dados na tabela 'cronogramaDataSet1.projetosEatividades'. Você pode movê-la ou removê-la conforme necessário.
            // TODO: esta linha de código carrega dados na tabela 'cronogramaDataSet1.projetos_tarefas'. Você pode movê-la ou removê-la conforme necessário.
            this.dbo_projetosTableAdapter.Fill(this.cronogramaDataSet.dbo_projetos);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
