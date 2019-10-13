namespace PawnEE
{
    partial class IDE
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IDE));
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.vS2015DarkTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.enregistrerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrersousToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aperçuavantimpressionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.annulerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rétablirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.couperToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.collerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.sélectionnertoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.outilsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personnaliserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sommaireToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.àproposdeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockPanel1
            // 
            this.dockPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dockPanel1.DockBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dockPanel1.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.dockPanel1.Location = new System.Drawing.Point(0, 72);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Padding = new System.Windows.Forms.Padding(6);
            this.dockPanel1.ShowAutoHideContentOnHover = false;
            this.dockPanel1.Size = new System.Drawing.Size(1280, 646);
            this.dockPanel1.TabIndex = 0;
            this.dockPanel1.Theme = this.vS2015DarkTheme1;
            this.dockPanel1.ActiveDocumentChanged += new System.EventHandler(this.dockPanel1_ActiveDocumentChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.menuStrip1.Location = new System.Drawing.Point(0, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1280, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem1,
            this.editionToolStripMenuItem1,
            this.outilsToolStripMenuItem1,
            this.aideToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1280, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fichierToolStripMenuItem1
            // 
            this.fichierToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem1,
            this.ouvrirToolStripMenuItem1,
            this.toolStripSeparator6,
            this.enregistrerToolStripMenuItem1,
            this.enregistrersousToolStripMenuItem1,
            this.toolStripSeparator7,
            this.imprimerToolStripMenuItem1,
            this.aperçuavantimpressionToolStripMenuItem1,
            this.toolStripSeparator8,
            this.quitterToolStripMenuItem1});
            this.fichierToolStripMenuItem1.ForeColor = System.Drawing.Color.Gainsboro;
            this.fichierToolStripMenuItem1.Name = "fichierToolStripMenuItem1";
            this.fichierToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem1.Text = "&Fichier";
            // 
            // nouveauToolStripMenuItem1
            // 
            this.nouveauToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("nouveauToolStripMenuItem1.Image")));
            this.nouveauToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nouveauToolStripMenuItem1.Name = "nouveauToolStripMenuItem1";
            this.nouveauToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.nouveauToolStripMenuItem1.Text = "&Nouveau";
            // 
            // ouvrirToolStripMenuItem1
            // 
            this.ouvrirToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripMenuItem1.Image")));
            this.ouvrirToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ouvrirToolStripMenuItem1.Name = "ouvrirToolStripMenuItem1";
            this.ouvrirToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.ouvrirToolStripMenuItem1.Text = "&Ouvrir";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(202, 6);
            // 
            // enregistrerToolStripMenuItem1
            // 
            this.enregistrerToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripMenuItem1.Image")));
            this.enregistrerToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enregistrerToolStripMenuItem1.Name = "enregistrerToolStripMenuItem1";
            this.enregistrerToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.enregistrerToolStripMenuItem1.Text = "&Enregistrer";
            // 
            // enregistrersousToolStripMenuItem1
            // 
            this.enregistrersousToolStripMenuItem1.Name = "enregistrersousToolStripMenuItem1";
            this.enregistrersousToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.enregistrersousToolStripMenuItem1.Text = "Enregistrer &sous";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(202, 6);
            // 
            // imprimerToolStripMenuItem1
            // 
            this.imprimerToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("imprimerToolStripMenuItem1.Image")));
            this.imprimerToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimerToolStripMenuItem1.Name = "imprimerToolStripMenuItem1";
            this.imprimerToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.imprimerToolStripMenuItem1.Text = "&Imprimer";
            // 
            // aperçuavantimpressionToolStripMenuItem1
            // 
            this.aperçuavantimpressionToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("aperçuavantimpressionToolStripMenuItem1.Image")));
            this.aperçuavantimpressionToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aperçuavantimpressionToolStripMenuItem1.Name = "aperçuavantimpressionToolStripMenuItem1";
            this.aperçuavantimpressionToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.aperçuavantimpressionToolStripMenuItem1.Text = "Aperçu a&vant impression";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(202, 6);
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.quitterToolStripMenuItem1.Text = "&Quitter";
            // 
            // editionToolStripMenuItem1
            // 
            this.editionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annulerToolStripMenuItem1,
            this.rétablirToolStripMenuItem1,
            this.toolStripSeparator9,
            this.couperToolStripMenuItem1,
            this.copierToolStripMenuItem1,
            this.collerToolStripMenuItem1,
            this.toolStripSeparator10,
            this.sélectionnertoutToolStripMenuItem1});
            this.editionToolStripMenuItem1.ForeColor = System.Drawing.Color.Gainsboro;
            this.editionToolStripMenuItem1.Name = "editionToolStripMenuItem1";
            this.editionToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem1.Text = "&Edition";
            // 
            // annulerToolStripMenuItem1
            // 
            this.annulerToolStripMenuItem1.Name = "annulerToolStripMenuItem1";
            this.annulerToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.annulerToolStripMenuItem1.Text = "&Annuler";
            // 
            // rétablirToolStripMenuItem1
            // 
            this.rétablirToolStripMenuItem1.Name = "rétablirToolStripMenuItem1";
            this.rétablirToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.rétablirToolStripMenuItem1.Text = "&Rétablir";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(161, 6);
            // 
            // couperToolStripMenuItem1
            // 
            this.couperToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("couperToolStripMenuItem1.Image")));
            this.couperToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.couperToolStripMenuItem1.Name = "couperToolStripMenuItem1";
            this.couperToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.couperToolStripMenuItem1.Text = "&Couper";
            // 
            // copierToolStripMenuItem1
            // 
            this.copierToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("copierToolStripMenuItem1.Image")));
            this.copierToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copierToolStripMenuItem1.Name = "copierToolStripMenuItem1";
            this.copierToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.copierToolStripMenuItem1.Text = "Co&pier";
            // 
            // collerToolStripMenuItem1
            // 
            this.collerToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("collerToolStripMenuItem1.Image")));
            this.collerToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.collerToolStripMenuItem1.Name = "collerToolStripMenuItem1";
            this.collerToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.collerToolStripMenuItem1.Text = "Co&ller";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(161, 6);
            // 
            // sélectionnertoutToolStripMenuItem1
            // 
            this.sélectionnertoutToolStripMenuItem1.Name = "sélectionnertoutToolStripMenuItem1";
            this.sélectionnertoutToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.sélectionnertoutToolStripMenuItem1.Text = "Sélectio&nner tout";
            // 
            // outilsToolStripMenuItem1
            // 
            this.outilsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personnaliserToolStripMenuItem1,
            this.optionsToolStripMenuItem1});
            this.outilsToolStripMenuItem1.ForeColor = System.Drawing.Color.Gainsboro;
            this.outilsToolStripMenuItem1.Name = "outilsToolStripMenuItem1";
            this.outilsToolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.outilsToolStripMenuItem1.Text = "&Outils";
            // 
            // personnaliserToolStripMenuItem1
            // 
            this.personnaliserToolStripMenuItem1.Name = "personnaliserToolStripMenuItem1";
            this.personnaliserToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.personnaliserToolStripMenuItem1.Text = "&Personnaliser";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.optionsToolStripMenuItem1.Text = "&Options";
            // 
            // aideToolStripMenuItem1
            // 
            this.aideToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sommaireToolStripMenuItem1,
            this.indexToolStripMenuItem1,
            this.rechercherToolStripMenuItem1,
            this.toolStripSeparator11,
            this.àproposdeToolStripMenuItem1});
            this.aideToolStripMenuItem1.ForeColor = System.Drawing.Color.Gainsboro;
            this.aideToolStripMenuItem1.Name = "aideToolStripMenuItem1";
            this.aideToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem1.Text = "&Aide";
            // 
            // sommaireToolStripMenuItem1
            // 
            this.sommaireToolStripMenuItem1.Name = "sommaireToolStripMenuItem1";
            this.sommaireToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.sommaireToolStripMenuItem1.Text = "&Sommaire";
            // 
            // indexToolStripMenuItem1
            // 
            this.indexToolStripMenuItem1.Name = "indexToolStripMenuItem1";
            this.indexToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.indexToolStripMenuItem1.Text = "&Index";
            // 
            // rechercherToolStripMenuItem1
            // 
            this.rechercherToolStripMenuItem1.Name = "rechercherToolStripMenuItem1";
            this.rechercherToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.rechercherToolStripMenuItem1.Text = "&Rechercher";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(144, 6);
            // 
            // àproposdeToolStripMenuItem1
            // 
            this.àproposdeToolStripMenuItem1.Name = "àproposdeToolStripMenuItem1";
            this.àproposdeToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.àproposdeToolStripMenuItem1.Text = "À &propos de...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.label1.Location = new System.Drawing.Point(38, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "PawnEE - Editor";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1178, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 26);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1212, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 26);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1246, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 26);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1280, 24);
            this.menuStrip3.TabIndex = 8;
            this.menuStrip3.Text = "menuStrip3";
            this.menuStrip3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip3_MouseDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.statusStrip1.Location = new System.Drawing.Point(0, 718);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1280, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(4, 721);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prêt";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Gainsboro;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(9, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(24, 24);
            this.button5.TabIndex = 12;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(69, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 24);
            this.button4.TabIndex = 13;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button6.Enabled = false;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Gainsboro;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(129, 48);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(24, 24);
            this.button6.TabIndex = 14;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button7.Enabled = false;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.Gainsboro;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(189, 48);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(24, 24);
            this.button7.TabIndex = 15;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.Gainsboro;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(159, 48);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(24, 24);
            this.button8.TabIndex = 16;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.Gainsboro;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(99, 48);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(24, 24);
            this.button9.TabIndex = 17;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.Gainsboro;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(39, 48);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(24, 24);
            this.button10.TabIndex = 18;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 740);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.Controls.Add(this.dockPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IDE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme vS2015DarkTheme1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem enregistrersousToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aperçuavantimpressionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rétablirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem sélectionnertoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personnaliserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sommaireToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem àproposdeToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Timer timer1;
    }
}

