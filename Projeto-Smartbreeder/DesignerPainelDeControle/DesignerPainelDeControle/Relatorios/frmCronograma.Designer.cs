namespace DesignerPainelDeControle.Relatorios
{
    partial class frmCronograma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dboatividadesprojetorecursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cronogramaDataSet1 = new DesignerPainelDeControle.cronogramaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dboprojetosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cronogramaDataSet = new DesignerPainelDeControle.cronogramaDataSet();
            this.dbo_projetosTableAdapter = new DesignerPainelDeControle.cronogramaDataSetTableAdapters.dbo_projetosTableAdapter();
            this.dbo_atividades_projeto_recursoTableAdapter = new DesignerPainelDeControle.cronogramaDataSetTableAdapters.dbo_atividades_projeto_recursoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dboatividadesprojetorecursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cronogramaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboprojetosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cronogramaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dboatividadesprojetorecursoBindingSource
            // 
            this.dboatividadesprojetorecursoBindingSource.DataMember = "dbo_atividades_projeto_recurso";
            this.dboatividadesprojetorecursoBindingSource.DataSource = this.cronogramaDataSet1;
            // 
            // cronogramaDataSet1
            // 
            this.cronogramaDataSet1.DataSetName = "cronogramaDataSet";
            this.cronogramaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dboatividadesprojetorecursoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DesignerPainelDeControle.Relatorios.Relatorios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(68, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(661, 709);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dboprojetosBindingSource
            // 
            this.dboprojetosBindingSource.DataMember = "dbo_projetos";
            this.dboprojetosBindingSource.DataSource = this.cronogramaDataSet;
            // 
            // cronogramaDataSet
            // 
            this.cronogramaDataSet.DataSetName = "cronogramaDataSet";
            this.cronogramaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbo_projetosTableAdapter
            // 
            this.dbo_projetosTableAdapter.ClearBeforeFill = true;
            // 
            // dbo_atividades_projeto_recursoTableAdapter
            // 
            this.dbo_atividades_projeto_recursoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelProjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRelProjetos";
            this.Text = "frmRelProjetos";
            this.Load += new System.EventHandler(this.frmRelProjetos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dboatividadesprojetorecursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cronogramaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboprojetosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cronogramaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private cronogramaDataSet cronogramaDataSet;
        private cronogramaDataSet cronogramaDataSet1;
        private System.Windows.Forms.BindingSource dboprojetosBindingSource;
        private cronogramaDataSetTableAdapters.dbo_projetosTableAdapter dbo_projetosTableAdapter;
        private System.Windows.Forms.BindingSource dboatividadesprojetorecursoBindingSource;
        private cronogramaDataSetTableAdapters.dbo_atividades_projeto_recursoTableAdapter dbo_atividades_projeto_recursoTableAdapter;
    }
}