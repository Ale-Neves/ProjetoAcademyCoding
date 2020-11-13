namespace DesignerPainelDeControle
{
    partial class fmrProjetos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrProjetos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuWebClient1 = new Bunifu.Framework.UI.BunifuWebClient(this.components);
            this.bunifuWebClient2 = new Bunifu.Framework.UI.BunifuWebClient(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.pnNovoProjeto = new System.Windows.Forms.Panel();
            this.btnListaTarefas = new System.Windows.Forms.Button();
            this.btnMensagem = new System.Windows.Forms.Button();
            this.gridTarefasProjeto = new System.Windows.Forms.DataGridView();
            this.gridProjetos = new System.Windows.Forms.DataGridView();
            this.mtxtBuscarData = new System.Windows.Forms.MaskedTextBox();
            this.txtGestor = new System.Windows.Forms.TextBox();
            this.btnGestor = new System.Windows.Forms.Button();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.rbDataInicio = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.mtxtDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.btnDataInicio = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnNome = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.pnNovoProjeto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTarefasProjeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProjetos)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuWebClient1
            // 
            this.bunifuWebClient1.AllowReadStreamBuffering = false;
            this.bunifuWebClient1.AllowWriteStreamBuffering = false;
            this.bunifuWebClient1.BaseAddress = "";
            this.bunifuWebClient1.CachePolicy = null;
            this.bunifuWebClient1.Credentials = null;
            this.bunifuWebClient1.Encoding = ((System.Text.Encoding)(resources.GetObject("bunifuWebClient1.Encoding")));
            this.bunifuWebClient1.Headers = ((System.Net.WebHeaderCollection)(resources.GetObject("bunifuWebClient1.Headers")));
            this.bunifuWebClient1.QueryString = ((System.Collections.Specialized.NameValueCollection)(resources.GetObject("bunifuWebClient1.QueryString")));
            this.bunifuWebClient1.UseDefaultCredentials = false;
            // 
            // bunifuWebClient2
            // 
            this.bunifuWebClient2.AllowReadStreamBuffering = false;
            this.bunifuWebClient2.AllowWriteStreamBuffering = false;
            this.bunifuWebClient2.BaseAddress = "";
            this.bunifuWebClient2.CachePolicy = null;
            this.bunifuWebClient2.Credentials = null;
            this.bunifuWebClient2.Encoding = ((System.Text.Encoding)(resources.GetObject("bunifuWebClient2.Encoding")));
            this.bunifuWebClient2.Headers = ((System.Net.WebHeaderCollection)(resources.GetObject("bunifuWebClient2.Headers")));
            this.bunifuWebClient2.QueryString = ((System.Collections.Specialized.NameValueCollection)(resources.GetObject("bunifuWebClient2.QueryString")));
            this.bunifuWebClient2.UseDefaultCredentials = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeletar);
            this.panel2.Controls.Add(this.button16);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.btnAlterar);
            this.panel2.Controls.Add(this.btnPesquisar);
            this.panel2.Controls.Add(this.btnNovo);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnDeletar, "btnDeletar");
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click_1);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Transparent;
            this.button16.Cursor = System.Windows.Forms.Cursors.Default;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button16, "button16");
            this.button16.ForeColor = System.Drawing.Color.Transparent;
            this.button16.Name = "button16";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSalvar, "btnSalvar");
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.Cursor = System.Windows.Forms.Cursors.Default;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button9, "button9");
            this.button9.ForeColor = System.Drawing.Color.Transparent;
            this.button9.Name = "button9";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Cursor = System.Windows.Forms.Cursors.Default;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button8, "button8");
            this.button8.ForeColor = System.Drawing.Color.Transparent;
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Cursor = System.Windows.Forms.Cursors.Default;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button7, "button7");
            this.button7.ForeColor = System.Drawing.Color.Transparent;
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Cursor = System.Windows.Forms.Cursors.Default;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button6, "button6");
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAlterar, "btnAlterar");
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click_1);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnPesquisar, "btnPesquisar");
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnNovo, "btnNovo");
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click_1);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.menuStrip2, "menuStrip2");
            this.menuStrip2.Name = "menuStrip2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // pnNovoProjeto
            // 
            resources.ApplyResources(this.pnNovoProjeto, "pnNovoProjeto");
            this.pnNovoProjeto.Controls.Add(this.btnListaTarefas);
            this.pnNovoProjeto.Controls.Add(this.btnMensagem);
            this.pnNovoProjeto.Controls.Add(this.gridTarefasProjeto);
            this.pnNovoProjeto.Controls.Add(this.gridProjetos);
            this.pnNovoProjeto.Controls.Add(this.mtxtBuscarData);
            this.pnNovoProjeto.Controls.Add(this.txtGestor);
            this.pnNovoProjeto.Controls.Add(this.btnGestor);
            this.pnNovoProjeto.Controls.Add(this.txtBuscarNome);
            this.pnNovoProjeto.Controls.Add(this.rbDataInicio);
            this.pnNovoProjeto.Controls.Add(this.rbNome);
            this.pnNovoProjeto.Controls.Add(this.mtxtDataInicial);
            this.pnNovoProjeto.Controls.Add(this.btnDataInicio);
            this.pnNovoProjeto.Controls.Add(this.txtNome);
            this.pnNovoProjeto.Controls.Add(this.btnNome);
            this.pnNovoProjeto.Controls.Add(this.btnBuscar);
            this.pnNovoProjeto.Name = "pnNovoProjeto";
            // 
            // btnListaTarefas
            // 
            this.btnListaTarefas.BackColor = System.Drawing.Color.Transparent;
            this.btnListaTarefas.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnListaTarefas.FlatAppearance.BorderSize = 0;
            this.btnListaTarefas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnListaTarefas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnListaTarefas, "btnListaTarefas");
            this.btnListaTarefas.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnListaTarefas.Name = "btnListaTarefas";
            this.btnListaTarefas.UseVisualStyleBackColor = false;
            // 
            // btnMensagem
            // 
            resources.ApplyResources(this.btnMensagem, "btnMensagem");
            this.btnMensagem.BackColor = System.Drawing.Color.Transparent;
            this.btnMensagem.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMensagem.FlatAppearance.BorderSize = 0;
            this.btnMensagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMensagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMensagem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.UseVisualStyleBackColor = false;
            // 
            // gridTarefasProjeto
            // 
            this.gridTarefasProjeto.AllowUserToAddRows = false;
            this.gridTarefasProjeto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridTarefasProjeto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.gridTarefasProjeto, "gridTarefasProjeto");
            this.gridTarefasProjeto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.gridTarefasProjeto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTarefasProjeto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridTarefasProjeto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTarefasProjeto.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTarefasProjeto.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridTarefasProjeto.Name = "gridTarefasProjeto";
            this.gridTarefasProjeto.ReadOnly = true;
            this.gridTarefasProjeto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTarefasProjeto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProjetos_CellClick);
            this.gridTarefasProjeto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridTarefasProjeto_CellFormatting);
            this.gridTarefasProjeto.Click += new System.EventHandler(this.fmrProjetos_Load);
            // 
            // gridProjetos
            // 
            this.gridProjetos.AllowUserToAddRows = false;
            this.gridProjetos.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.gridProjetos, "gridProjetos");
            this.gridProjetos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.gridProjetos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProjetos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridProjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProjetos.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridProjetos.Name = "gridProjetos";
            this.gridProjetos.ReadOnly = true;
            this.gridProjetos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProjetos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProjetos_CellClick);
            // 
            // mtxtBuscarData
            // 
            resources.ApplyResources(this.mtxtBuscarData, "mtxtBuscarData");
            this.mtxtBuscarData.Name = "mtxtBuscarData";
            this.mtxtBuscarData.ValidatingType = typeof(System.DateTime);
            this.mtxtBuscarData.TextChanged += new System.EventHandler(this.mtxtBuscarData_TextChanged);
            // 
            // txtGestor
            // 
            resources.ApplyResources(this.txtGestor, "txtGestor");
            this.txtGestor.Name = "txtGestor";
            // 
            // btnGestor
            // 
            this.btnGestor.BackColor = System.Drawing.Color.Transparent;
            this.btnGestor.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGestor.FlatAppearance.BorderSize = 0;
            this.btnGestor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGestor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnGestor, "btnGestor");
            this.btnGestor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGestor.Name = "btnGestor";
            this.btnGestor.UseVisualStyleBackColor = false;
            // 
            // txtBuscarNome
            // 
            resources.ApplyResources(this.txtBuscarNome, "txtBuscarNome");
            this.txtBuscarNome.Name = "txtBuscarNome";
            this.txtBuscarNome.TextChanged += new System.EventHandler(this.txtBuscarNome_TextChanged);
            // 
            // rbDataInicio
            // 
            resources.ApplyResources(this.rbDataInicio, "rbDataInicio");
            this.rbDataInicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbDataInicio.Name = "rbDataInicio";
            this.rbDataInicio.TabStop = true;
            this.rbDataInicio.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            resources.ApplyResources(this.rbNome, "rbNome");
            this.rbNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbNome.Name = "rbNome";
            this.rbNome.TabStop = true;
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // mtxtDataInicial
            // 
            resources.ApplyResources(this.mtxtDataInicial, "mtxtDataInicial");
            this.mtxtDataInicial.Name = "mtxtDataInicial";
            this.mtxtDataInicial.ValidatingType = typeof(System.DateTime);
            // 
            // btnDataInicio
            // 
            this.btnDataInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnDataInicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDataInicio.FlatAppearance.BorderSize = 0;
            this.btnDataInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDataInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnDataInicio, "btnDataInicio");
            this.btnDataInicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDataInicio.Name = "btnDataInicio";
            this.btnDataInicio.UseVisualStyleBackColor = false;
            // 
            // txtNome
            // 
            resources.ApplyResources(this.txtNome, "txtNome");
            this.txtNome.Name = "txtNome";
            // 
            // btnNome
            // 
            this.btnNome.BackColor = System.Drawing.Color.Transparent;
            this.btnNome.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNome.FlatAppearance.BorderSize = 0;
            this.btnNome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnNome, "btnNome");
            this.btnNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNome.Name = "btnNome";
            this.btnNome.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnBuscar, "btnBuscar");
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // fmrProjetos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.pnNovoProjeto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmrProjetos";
            this.Load += new System.EventHandler(this.fmrProjetos_Load);
            this.panel2.ResumeLayout(false);
            this.pnNovoProjeto.ResumeLayout(false);
            this.pnNovoProjeto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTarefasProjeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProjetos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuWebClient bunifuWebClient1;
        private Bunifu.Framework.UI.BunifuWebClient bunifuWebClient2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnNovoProjeto;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.RadioButton rbDataInicio;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.Button btnDataInicio;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnNome;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtGestor;
        private System.Windows.Forms.Button btnGestor;
        private System.Windows.Forms.MaskedTextBox mtxtDataInicial;
        private System.Windows.Forms.MaskedTextBox mtxtBuscarData;
        private System.Windows.Forms.DataGridView gridProjetos;
        private System.Windows.Forms.Button btnMensagem;
        private System.Windows.Forms.Button btnListaTarefas;
        private System.Windows.Forms.DataGridView gridTarefasProjeto;
    }
}