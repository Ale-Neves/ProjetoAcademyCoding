namespace DesignerPainelDeControle
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.pnMenuTopo = new System.Windows.Forms.Panel();
            this.pbRestaurar = new System.Windows.Forms.PictureBox();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbMaximizar = new System.Windows.Forms.PictureBox();
            this.pbSair = new System.Windows.Forms.PictureBox();
            this.lbPainel = new System.Windows.Forms.Label();
            this.pbMenuBarraLateral = new System.Windows.Forms.PictureBox();
            this.pnBarraLateral = new System.Windows.Forms.Panel();
            this.bgpFundoBarraLateral = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bsFaixaLogo = new Bunifu.Framework.UI.BunifuSeparator();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbLogo2 = new System.Windows.Forms.PictureBox();
            this.bfbEnviarReport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbRelatorios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbRecursos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbTarefas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbProjetos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnCentral = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.beBordaBarraLateral = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btAnimacaoBarraLateral = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnMenuTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuBarraLateral)).BeginInit();
            this.pnBarraLateral.SuspendLayout();
            this.bgpFundoBarraLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo2)).BeginInit();
            this.pnCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenuTopo
            // 
            this.pnMenuTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnMenuTopo.Controls.Add(this.pbRestaurar);
            this.pnMenuTopo.Controls.Add(this.pbMinimizar);
            this.pnMenuTopo.Controls.Add(this.pbMaximizar);
            this.pnMenuTopo.Controls.Add(this.pbSair);
            this.pnMenuTopo.Controls.Add(this.lbPainel);
            this.pnMenuTopo.Controls.Add(this.pbMenuBarraLateral);
            this.btAnimacaoBarraLateral.SetDecoration(this.pnMenuTopo, BunifuAnimatorNS.DecorationType.None);
            this.pnMenuTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenuTopo.Location = new System.Drawing.Point(0, 0);
            this.pnMenuTopo.Name = "pnMenuTopo";
            this.pnMenuTopo.Size = new System.Drawing.Size(1080, 50);
            this.pnMenuTopo.TabIndex = 0;
            // 
            // pbRestaurar
            // 
            this.pbRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAnimacaoBarraLateral.SetDecoration(this.pbRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.pbRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("pbRestaurar.Image")));
            this.pbRestaurar.Location = new System.Drawing.Point(1016, 11);
            this.pbRestaurar.Name = "pbRestaurar";
            this.pbRestaurar.Size = new System.Drawing.Size(23, 24);
            this.pbRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRestaurar.TabIndex = 5;
            this.pbRestaurar.TabStop = false;
            this.pbRestaurar.Visible = false;
            this.pbRestaurar.Click += new System.EventHandler(this.pbRestaurar_Click);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAnimacaoBarraLateral.SetDecoration(this.pbMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(987, 11);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(23, 24);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 4;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // pbMaximizar
            // 
            this.pbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAnimacaoBarraLateral.SetDecoration(this.pbMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.pbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMaximizar.Image")));
            this.pbMaximizar.Location = new System.Drawing.Point(1016, 11);
            this.pbMaximizar.Name = "pbMaximizar";
            this.pbMaximizar.Size = new System.Drawing.Size(23, 24);
            this.pbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMaximizar.TabIndex = 3;
            this.pbMaximizar.TabStop = false;
            // 
            // pbSair
            // 
            this.pbSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAnimacaoBarraLateral.SetDecoration(this.pbSair, BunifuAnimatorNS.DecorationType.None);
            this.pbSair.Image = ((System.Drawing.Image)(resources.GetObject("pbSair.Image")));
            this.pbSair.Location = new System.Drawing.Point(1045, 11);
            this.pbSair.Name = "pbSair";
            this.pbSair.Size = new System.Drawing.Size(23, 24);
            this.pbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSair.TabIndex = 2;
            this.pbSair.TabStop = false;
            this.pbSair.Click += new System.EventHandler(this.pbSair_Click);
            // 
            // lbPainel
            // 
            this.lbPainel.AutoSize = true;
            this.lbPainel.BackColor = System.Drawing.Color.Transparent;
            this.btAnimacaoBarraLateral.SetDecoration(this.lbPainel, BunifuAnimatorNS.DecorationType.None);
            this.lbPainel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPainel.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPainel.ForeColor = System.Drawing.Color.White;
            this.lbPainel.Location = new System.Drawing.Point(65, 13);
            this.lbPainel.Name = "lbPainel";
            this.lbPainel.Size = new System.Drawing.Size(126, 22);
            this.lbPainel.TabIndex = 1;
            this.lbPainel.Text = "Painel de Controle";
            // 
            // pbMenuBarraLateral
            // 
            this.btAnimacaoBarraLateral.SetDecoration(this.pbMenuBarraLateral, BunifuAnimatorNS.DecorationType.None);
            this.pbMenuBarraLateral.Image = ((System.Drawing.Image)(resources.GetObject("pbMenuBarraLateral.Image")));
            this.pbMenuBarraLateral.Location = new System.Drawing.Point(36, 12);
            this.pbMenuBarraLateral.Name = "pbMenuBarraLateral";
            this.pbMenuBarraLateral.Size = new System.Drawing.Size(23, 24);
            this.pbMenuBarraLateral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenuBarraLateral.TabIndex = 0;
            this.pbMenuBarraLateral.TabStop = false;
            this.pbMenuBarraLateral.Click += new System.EventHandler(this.pbMenuBarraLateral_Click);
            // 
            // pnBarraLateral
            // 
            this.pnBarraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnBarraLateral.Controls.Add(this.bgpFundoBarraLateral);
            this.btAnimacaoBarraLateral.SetDecoration(this.pnBarraLateral, BunifuAnimatorNS.DecorationType.None);
            this.pnBarraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnBarraLateral.Location = new System.Drawing.Point(0, 50);
            this.pnBarraLateral.Name = "pnBarraLateral";
            this.pnBarraLateral.Size = new System.Drawing.Size(232, 670);
            this.pnBarraLateral.TabIndex = 1;
            // 
            // bgpFundoBarraLateral
            // 
            this.bgpFundoBarraLateral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bgpFundoBarraLateral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bgpFundoBarraLateral.BackgroundImage")));
            this.bgpFundoBarraLateral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bgpFundoBarraLateral.Controls.Add(this.bsFaixaLogo);
            this.bgpFundoBarraLateral.Controls.Add(this.pbLogo);
            this.bgpFundoBarraLateral.Controls.Add(this.pbLogo2);
            this.bgpFundoBarraLateral.Controls.Add(this.bfbEnviarReport);
            this.bgpFundoBarraLateral.Controls.Add(this.bfbRelatorios);
            this.bgpFundoBarraLateral.Controls.Add(this.bfbRecursos);
            this.bgpFundoBarraLateral.Controls.Add(this.bfbTarefas);
            this.bgpFundoBarraLateral.Controls.Add(this.bfbProjetos);
            this.btAnimacaoBarraLateral.SetDecoration(this.bgpFundoBarraLateral, BunifuAnimatorNS.DecorationType.None);
            this.bgpFundoBarraLateral.GradientBottomLeft = System.Drawing.Color.MediumSpringGreen;
            this.bgpFundoBarraLateral.GradientBottomRight = System.Drawing.Color.MediumSpringGreen;
            this.bgpFundoBarraLateral.GradientTopLeft = System.Drawing.Color.MediumSpringGreen;
            this.bgpFundoBarraLateral.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bgpFundoBarraLateral.Location = new System.Drawing.Point(13, 13);
            this.bgpFundoBarraLateral.Name = "bgpFundoBarraLateral";
            this.bgpFundoBarraLateral.Quality = 10;
            this.bgpFundoBarraLateral.Size = new System.Drawing.Size(204, 657);
            this.bgpFundoBarraLateral.TabIndex = 7;
            // 
            // bsFaixaLogo
            // 
            this.bsFaixaLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bsFaixaLogo.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.bsFaixaLogo.BackColor = System.Drawing.Color.Transparent;
            this.bsFaixaLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btAnimacaoBarraLateral.SetDecoration(this.bsFaixaLogo, BunifuAnimatorNS.DecorationType.None);
            this.bsFaixaLogo.ForeColor = System.Drawing.Color.Transparent;
            this.bsFaixaLogo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bsFaixaLogo.LineThickness = 1;
            this.bsFaixaLogo.Location = new System.Drawing.Point(5, 76);
            this.bsFaixaLogo.Name = "bsFaixaLogo";
            this.bsFaixaLogo.Size = new System.Drawing.Size(190, 10);
            this.bsFaixaLogo.TabIndex = 7;
            this.bsFaixaLogo.Transparency = 255;
            this.bsFaixaLogo.Vertical = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btAnimacaoBarraLateral.SetDecoration(this.pbLogo, BunifuAnimatorNS.DecorationType.None);
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(7, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(184, 85);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            // 
            // pbLogo2
            // 
            this.pbLogo2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pbLogo2.BackColor = System.Drawing.Color.Transparent;
            this.btAnimacaoBarraLateral.SetDecoration(this.pbLogo2, BunifuAnimatorNS.DecorationType.None);
            this.pbLogo2.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo2.Image")));
            this.pbLogo2.Location = new System.Drawing.Point(2, 18);
            this.pbLogo2.Name = "pbLogo2";
            this.pbLogo2.Size = new System.Drawing.Size(59, 54);
            this.pbLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo2.TabIndex = 6;
            this.pbLogo2.TabStop = false;
            this.pbLogo2.Visible = false;
            // 
            // bfbEnviarReport
            // 
            this.bfbEnviarReport.Activecolor = System.Drawing.Color.Transparent;
            this.bfbEnviarReport.BackColor = System.Drawing.Color.Transparent;
            this.bfbEnviarReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbEnviarReport.BorderRadius = 0;
            this.bfbEnviarReport.ButtonText = "  Enviar                Cronograma";
            this.bfbEnviarReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAnimacaoBarraLateral.SetDecoration(this.bfbEnviarReport, BunifuAnimatorNS.DecorationType.None);
            this.bfbEnviarReport.DisabledColor = System.Drawing.Color.Gray;
            this.bfbEnviarReport.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbEnviarReport.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbEnviarReport.Iconimage")));
            this.bfbEnviarReport.Iconimage_right = null;
            this.bfbEnviarReport.Iconimage_right_Selected = null;
            this.bfbEnviarReport.Iconimage_Selected = null;
            this.bfbEnviarReport.IconMarginLeft = 0;
            this.bfbEnviarReport.IconMarginRight = 0;
            this.bfbEnviarReport.IconRightVisible = true;
            this.bfbEnviarReport.IconRightZoom = 0D;
            this.bfbEnviarReport.IconVisible = true;
            this.bfbEnviarReport.IconZoom = 90D;
            this.bfbEnviarReport.IsTab = false;
            this.bfbEnviarReport.Location = new System.Drawing.Point(10, 348);
            this.bfbEnviarReport.Name = "bfbEnviarReport";
            this.bfbEnviarReport.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbEnviarReport.OnHovercolor = System.Drawing.Color.Transparent;
            this.bfbEnviarReport.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbEnviarReport.selected = false;
            this.bfbEnviarReport.Size = new System.Drawing.Size(188, 48);
            this.bfbEnviarReport.TabIndex = 12;
            this.bfbEnviarReport.Text = "  Enviar                Cronograma";
            this.bfbEnviarReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbEnviarReport.Textcolor = System.Drawing.Color.Black;
            this.bfbEnviarReport.TextFont = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbEnviarReport.Click += new System.EventHandler(this.bfbEnviarReport_Click);
            // 
            // bfbRelatorios
            // 
            this.bfbRelatorios.Activecolor = System.Drawing.Color.Transparent;
            this.bfbRelatorios.BackColor = System.Drawing.Color.Transparent;
            this.bfbRelatorios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbRelatorios.BorderRadius = 0;
            this.bfbRelatorios.ButtonText = "  Cronograma";
            this.bfbRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAnimacaoBarraLateral.SetDecoration(this.bfbRelatorios, BunifuAnimatorNS.DecorationType.None);
            this.bfbRelatorios.DisabledColor = System.Drawing.Color.Gray;
            this.bfbRelatorios.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbRelatorios.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbRelatorios.Iconimage")));
            this.bfbRelatorios.Iconimage_right = null;
            this.bfbRelatorios.Iconimage_right_Selected = null;
            this.bfbRelatorios.Iconimage_Selected = null;
            this.bfbRelatorios.IconMarginLeft = 0;
            this.bfbRelatorios.IconMarginRight = 0;
            this.bfbRelatorios.IconRightVisible = true;
            this.bfbRelatorios.IconRightZoom = 0D;
            this.bfbRelatorios.IconVisible = true;
            this.bfbRelatorios.IconZoom = 90D;
            this.bfbRelatorios.IsTab = false;
            this.bfbRelatorios.Location = new System.Drawing.Point(10, 284);
            this.bfbRelatorios.Name = "bfbRelatorios";
            this.bfbRelatorios.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbRelatorios.OnHovercolor = System.Drawing.Color.Transparent;
            this.bfbRelatorios.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbRelatorios.selected = false;
            this.bfbRelatorios.Size = new System.Drawing.Size(188, 48);
            this.bfbRelatorios.TabIndex = 11;
            this.bfbRelatorios.Text = "  Cronograma";
            this.bfbRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbRelatorios.Textcolor = System.Drawing.Color.Black;
            this.bfbRelatorios.TextFont = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbRelatorios.Click += new System.EventHandler(this.bfbRelatorios_Click);
            // 
            // bfbRecursos
            // 
            this.bfbRecursos.Activecolor = System.Drawing.Color.Transparent;
            this.bfbRecursos.BackColor = System.Drawing.Color.Transparent;
            this.bfbRecursos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbRecursos.BorderRadius = 0;
            this.bfbRecursos.ButtonText = "  Recursos";
            this.bfbRecursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAnimacaoBarraLateral.SetDecoration(this.bfbRecursos, BunifuAnimatorNS.DecorationType.None);
            this.bfbRecursos.DisabledColor = System.Drawing.Color.Gray;
            this.bfbRecursos.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbRecursos.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbRecursos.Iconimage")));
            this.bfbRecursos.Iconimage_right = null;
            this.bfbRecursos.Iconimage_right_Selected = null;
            this.bfbRecursos.Iconimage_Selected = null;
            this.bfbRecursos.IconMarginLeft = 0;
            this.bfbRecursos.IconMarginRight = 0;
            this.bfbRecursos.IconRightVisible = true;
            this.bfbRecursos.IconRightZoom = 0D;
            this.bfbRecursos.IconVisible = true;
            this.bfbRecursos.IconZoom = 90D;
            this.bfbRecursos.IsTab = false;
            this.bfbRecursos.Location = new System.Drawing.Point(8, 166);
            this.bfbRecursos.Name = "bfbRecursos";
            this.bfbRecursos.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbRecursos.OnHovercolor = System.Drawing.Color.Transparent;
            this.bfbRecursos.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbRecursos.selected = false;
            this.bfbRecursos.Size = new System.Drawing.Size(188, 48);
            this.bfbRecursos.TabIndex = 10;
            this.bfbRecursos.Text = "  Recursos";
            this.bfbRecursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbRecursos.Textcolor = System.Drawing.Color.Black;
            this.bfbRecursos.TextFont = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbRecursos.Click += new System.EventHandler(this.bfbRecursos_Click);
            // 
            // bfbTarefas
            // 
            this.bfbTarefas.Activecolor = System.Drawing.Color.Transparent;
            this.bfbTarefas.BackColor = System.Drawing.Color.Transparent;
            this.bfbTarefas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbTarefas.BorderRadius = 0;
            this.bfbTarefas.ButtonText = "  Tarefas";
            this.bfbTarefas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAnimacaoBarraLateral.SetDecoration(this.bfbTarefas, BunifuAnimatorNS.DecorationType.None);
            this.bfbTarefas.DisabledColor = System.Drawing.Color.Gray;
            this.bfbTarefas.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbTarefas.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbTarefas.Iconimage")));
            this.bfbTarefas.Iconimage_right = null;
            this.bfbTarefas.Iconimage_right_Selected = null;
            this.bfbTarefas.Iconimage_Selected = null;
            this.bfbTarefas.IconMarginLeft = 0;
            this.bfbTarefas.IconMarginRight = 0;
            this.bfbTarefas.IconRightVisible = true;
            this.bfbTarefas.IconRightZoom = 0D;
            this.bfbTarefas.IconVisible = true;
            this.bfbTarefas.IconZoom = 90D;
            this.bfbTarefas.IsTab = false;
            this.bfbTarefas.Location = new System.Drawing.Point(11, 223);
            this.bfbTarefas.Name = "bfbTarefas";
            this.bfbTarefas.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbTarefas.OnHovercolor = System.Drawing.Color.Transparent;
            this.bfbTarefas.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbTarefas.selected = false;
            this.bfbTarefas.Size = new System.Drawing.Size(188, 48);
            this.bfbTarefas.TabIndex = 9;
            this.bfbTarefas.Text = "  Tarefas";
            this.bfbTarefas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbTarefas.Textcolor = System.Drawing.Color.Black;
            this.bfbTarefas.TextFont = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbTarefas.Click += new System.EventHandler(this.bfbTarefas_Click);
            // 
            // bfbProjetos
            // 
            this.bfbProjetos.Activecolor = System.Drawing.Color.Transparent;
            this.bfbProjetos.BackColor = System.Drawing.Color.Transparent;
            this.bfbProjetos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbProjetos.BorderRadius = 0;
            this.bfbProjetos.ButtonText = "  Projetos";
            this.bfbProjetos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAnimacaoBarraLateral.SetDecoration(this.bfbProjetos, BunifuAnimatorNS.DecorationType.None);
            this.bfbProjetos.DisabledColor = System.Drawing.Color.Gray;
            this.bfbProjetos.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbProjetos.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbProjetos.Iconimage")));
            this.bfbProjetos.Iconimage_right = null;
            this.bfbProjetos.Iconimage_right_Selected = null;
            this.bfbProjetos.Iconimage_Selected = null;
            this.bfbProjetos.IconMarginLeft = 0;
            this.bfbProjetos.IconMarginRight = 0;
            this.bfbProjetos.IconRightVisible = true;
            this.bfbProjetos.IconRightZoom = 0D;
            this.bfbProjetos.IconVisible = true;
            this.bfbProjetos.IconZoom = 90D;
            this.bfbProjetos.IsTab = false;
            this.bfbProjetos.Location = new System.Drawing.Point(8, 112);
            this.bfbProjetos.Name = "bfbProjetos";
            this.bfbProjetos.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbProjetos.OnHovercolor = System.Drawing.Color.Transparent;
            this.bfbProjetos.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbProjetos.selected = false;
            this.bfbProjetos.Size = new System.Drawing.Size(188, 48);
            this.bfbProjetos.TabIndex = 8;
            this.bfbProjetos.Text = "  Projetos";
            this.bfbProjetos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbProjetos.Textcolor = System.Drawing.Color.Black;
            this.bfbProjetos.TextFont = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbProjetos.Click += new System.EventHandler(this.bfbProjetos_Click);
            // 
            // pnCentral
            // 
            this.pnCentral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnCentral.Controls.Add(this.pictureBox1);
            this.btAnimacaoBarraLateral.SetDecoration(this.pnCentral, BunifuAnimatorNS.DecorationType.None);
            this.pnCentral.Location = new System.Drawing.Point(232, 50);
            this.pnCentral.Name = "pnCentral";
            this.pnCentral.Size = new System.Drawing.Size(848, 670);
            this.pnCentral.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btAnimacaoBarraLateral.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(137, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(596, 545);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // beBordaBarraLateral
            // 
            this.beBordaBarraLateral.ElipseRadius = 7;
            this.beBordaBarraLateral.TargetControl = this.bgpFundoBarraLateral;
            // 
            // btAnimacaoBarraLateral
            // 
            this.btAnimacaoBarraLateral.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.btAnimacaoBarraLateral.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.btAnimacaoBarraLateral.DefaultAnimation = animation1;
            this.btAnimacaoBarraLateral.Interval = 7;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.pnBarraLateral);
            this.Controls.Add(this.pnCentral);
            this.Controls.Add(this.pnMenuTopo);
            this.btAnimacaoBarraLateral.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cronograma de Atividades";
            this.pnMenuTopo.ResumeLayout(false);
            this.pnMenuTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuBarraLateral)).EndInit();
            this.pnBarraLateral.ResumeLayout(false);
            this.bgpFundoBarraLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo2)).EndInit();
            this.pnCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenuTopo;
        private System.Windows.Forms.Panel pnBarraLateral;
        private System.Windows.Forms.Label lbPainel;
        private System.Windows.Forms.PictureBox pbMenuBarraLateral;
        private System.Windows.Forms.PictureBox pbRestaurar;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbMaximizar;
        private System.Windows.Forms.PictureBox pbSair;
        private Bunifu.Framework.UI.BunifuGradientPanel bgpFundoBarraLateral;
        private System.Windows.Forms.PictureBox pbLogo;
        private Bunifu.Framework.UI.BunifuSeparator bsFaixaLogo;
        private Bunifu.Framework.UI.BunifuFlatButton bfbProjetos;
        private Bunifu.Framework.UI.BunifuFlatButton bfbEnviarReport;
        private Bunifu.Framework.UI.BunifuFlatButton bfbRelatorios;
        private Bunifu.Framework.UI.BunifuFlatButton bfbRecursos;
        private Bunifu.Framework.UI.BunifuFlatButton bfbTarefas;
        private System.Windows.Forms.Panel pnCentral;
        private Bunifu.Framework.UI.BunifuElipse beBordaBarraLateral;
        private System.Windows.Forms.PictureBox pbLogo2;
        private BunifuAnimatorNS.BunifuTransition btAnimacaoBarraLateral;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

