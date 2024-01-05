namespace Player
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.stPlaylist = new System.Windows.Forms.ListBox();
            this.btSalvar = new DevComponents.DotNetBar.ButtonX();
            this.btCarregar = new DevComponents.DotNetBar.ButtonX();
            this.btLimpar = new DevComponents.DotNetBar.ButtonX();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.lbRight = new DevComponents.DotNetBar.LabelX();
            this.lbLeft = new DevComponents.DotNetBar.LabelX();
            this.btNext = new DevComponents.DotNetBar.ButtonX();
            this.lbTituloMusica = new DevComponents.DotNetBar.LabelX();
            this.btBack = new DevComponents.DotNetBar.ButtonX();
            this.btPausa = new DevComponents.DotNetBar.ButtonX();
            this.btPlay = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btAbrir = new DevComponents.DotNetBar.ButtonX();
            this.pnList = new System.Windows.Forms.Panel();
            this.AbrirPasta = new DevComponents.DotNetBar.ButtonX();
            this.txtContList = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.AllowDrop = true;
            this.player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(178, -7);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(741, 486);
            this.player.TabIndex = 0;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            // 
            // stPlaylist
            // 
            this.stPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stPlaylist.ForeColor = System.Drawing.Color.White;
            this.stPlaylist.FormattingEnabled = true;
            this.stPlaylist.ItemHeight = 16;
            this.stPlaylist.Location = new System.Drawing.Point(178, 4);
            this.stPlaylist.Name = "stPlaylist";
            this.stPlaylist.Size = new System.Drawing.Size(741, 432);
            this.stPlaylist.TabIndex = 1;
            this.stPlaylist.SelectedIndexChanged += new System.EventHandler(this.stPlaylist_SelectedIndexChanged);
            this.stPlaylist.DoubleClick += new System.EventHandler(this.stPlaylist_DoubleClick);
            this.stPlaylist.MouseLeave += new System.EventHandler(this.stPlaylist_MouseLeave);
            // 
            // btSalvar
            // 
            this.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvar.FocusCuesEnabled = false;
            this.btSalvar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(1, 425);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(177, 40);
            this.btSalvar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSalvar.Symbol = "";
            this.btSalvar.TabIndex = 3;
            this.btSalvar.Text = " Salvar PlayList";
            this.btSalvar.TextColor = System.Drawing.Color.White;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCarregar
            // 
            this.btCarregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCarregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCarregar.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btCarregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCarregar.FocusCuesEnabled = false;
            this.btCarregar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCarregar.Location = new System.Drawing.Point(1, 463);
            this.btCarregar.Name = "btCarregar";
            this.btCarregar.Size = new System.Drawing.Size(177, 40);
            this.btCarregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCarregar.Symbol = "";
            this.btCarregar.TabIndex = 4;
            this.btCarregar.Text = " Carregar PlayList";
            this.btCarregar.TextColor = System.Drawing.Color.White;
            this.btCarregar.Click += new System.EventHandler(this.btCarregar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLimpar.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLimpar.FocusCuesEnabled = false;
            this.btLimpar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(1, 497);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(177, 40);
            this.btLimpar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btLimpar.Symbol = "";
            this.btLimpar.TabIndex = 5;
            this.btLimpar.Text = " Apagar PlayList";
            this.btLimpar.TextColor = System.Drawing.Color.White;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.txtContList);
            this.panel1.Controls.Add(this.buttonX4);
            this.panel1.Controls.Add(this.buttonX5);
            this.panel1.Controls.Add(this.buttonX2);
            this.panel1.Controls.Add(this.buttonX1);
            this.panel1.Controls.Add(this.lbRight);
            this.panel1.Controls.Add(this.lbLeft);
            this.panel1.Controls.Add(this.btNext);
            this.panel1.Controls.Add(this.lbTituloMusica);
            this.panel1.Controls.Add(this.btBack);
            this.panel1.Controls.Add(this.btPausa);
            this.panel1.Controls.Add(this.btPlay);
            this.panel1.Location = new System.Drawing.Point(178, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 94);
            this.panel1.TabIndex = 10;
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonX4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX4.FocusCuesEnabled = false;
            this.buttonX4.Location = new System.Drawing.Point(426, 39);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(50, 50);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.Symbol = "";
            this.buttonX4.SymbolColor = System.Drawing.Color.White;
            this.buttonX4.TabIndex = 26;
            this.buttonX4.Click += new System.EventHandler(this.btAvancar);
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonX5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX5.FocusCuesEnabled = false;
            this.buttonX5.Location = new System.Drawing.Point(243, 39);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(50, 50);
            this.buttonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX5.Symbol = "";
            this.buttonX5.SymbolColor = System.Drawing.Color.White;
            this.buttonX5.TabIndex = 25;
            this.buttonX5.Click += new System.EventHandler(this.btReAvançar);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonX2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX2.FocusCuesEnabled = false;
            this.buttonX2.Location = new System.Drawing.Point(199, 39);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(50, 50);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.SymbolColor = System.Drawing.Color.White;
            this.buttonX2.TabIndex = 24;
            this.buttonX2.Click += new System.EventHandler(this.btPlayList);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonX1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX1.FocusCuesEnabled = false;
            this.buttonX1.Location = new System.Drawing.Point(470, 38);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(50, 50);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolColor = System.Drawing.Color.White;
            this.buttonX1.TabIndex = 23;
            this.buttonX1.Click += new System.EventHandler(this.btStop);
            // 
            // lbRight
            // 
            this.lbRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lbRight.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRight.ForeColor = System.Drawing.Color.White;
            this.lbRight.Location = new System.Drawing.Point(677, 4);
            this.lbRight.Name = "lbRight";
            this.lbRight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbRight.Size = new System.Drawing.Size(58, 10);
            this.lbRight.TabIndex = 21;
            this.lbRight.Text = "00";
            // 
            // lbLeft
            // 
            // 
            // 
            // 
            this.lbLeft.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeft.ForeColor = System.Drawing.Color.White;
            this.lbLeft.Location = new System.Drawing.Point(5, 3);
            this.lbLeft.Name = "lbLeft";
            this.lbLeft.Size = new System.Drawing.Size(85, 10);
            this.lbLeft.TabIndex = 20;
            this.lbLeft.Text = "00";
            // 
            // btNext
            // 
            this.btNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btNext.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNext.FocusCuesEnabled = false;
            this.btNext.Location = new System.Drawing.Point(380, 39);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(50, 50);
            this.btNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btNext.Symbol = "";
            this.btNext.SymbolColor = System.Drawing.Color.White;
            this.btNext.TabIndex = 15;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // lbTituloMusica
            // 
            // 
            // 
            // 
            this.lbTituloMusica.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTituloMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloMusica.ForeColor = System.Drawing.Color.White;
            this.lbTituloMusica.Location = new System.Drawing.Point(4, 20);
            this.lbTituloMusica.Name = "lbTituloMusica";
            this.lbTituloMusica.Size = new System.Drawing.Size(734, 16);
            this.lbTituloMusica.TabIndex = 11;
            this.lbTituloMusica.Text = "Titúlo da Música";
            // 
            // btBack
            // 
            this.btBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btBack.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBack.FocusCuesEnabled = false;
            this.btBack.Location = new System.Drawing.Point(285, 39);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(50, 50);
            this.btBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btBack.Symbol = "";
            this.btBack.SymbolColor = System.Drawing.Color.White;
            this.btBack.TabIndex = 12;
            this.btBack.Click += new System.EventHandler(this.bt_Back);
            // 
            // btPausa
            // 
            this.btPausa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btPausa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btPausa.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btPausa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPausa.FocusCuesEnabled = false;
            this.btPausa.Location = new System.Drawing.Point(331, 39);
            this.btPausa.Name = "btPausa";
            this.btPausa.Size = new System.Drawing.Size(54, 50);
            this.btPausa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btPausa.Symbol = "57398";
            this.btPausa.SymbolColor = System.Drawing.Color.White;
            this.btPausa.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btPausa.TabIndex = 14;
            this.btPausa.Click += new System.EventHandler(this.btPausar);
            // 
            // btPlay
            // 
            this.btPlay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btPlay.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPlay.FocusCuesEnabled = false;
            this.btPlay.Location = new System.Drawing.Point(335, 39);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(50, 50);
            this.btPlay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btPlay.Symbol = "57401";
            this.btPlay.SymbolColor = System.Drawing.Color.White;
            this.btPlay.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btPlay.TabIndex = 22;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click_1);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(5, 106);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(169, 79);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "JohnSoft";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(178, 433);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(28, 13);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(892, 433);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(27, 13);
            this.panel3.TabIndex = 14;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.White;
            this.labelX2.Image = global::Player.Properties.Resources.Video_Playlist_50px_1;
            this.labelX2.Location = new System.Drawing.Point(15, 27);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(153, 48);
            this.labelX2.TabIndex = 12;
            this.labelX2.Text = "Player";
            // 
            // btAbrir
            // 
            this.btAbrir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btAbrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAbrir.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAbrir.FocusCuesEnabled = false;
            this.btAbrir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbrir.Image = global::Player.Properties.Resources.icons8_video_playlist_25px_1;
            this.btAbrir.Location = new System.Drawing.Point(1, 349);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(177, 40);
            this.btAbrir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btAbrir.TabIndex = 2;
            this.btAbrir.Text = " Buscar";
            this.btAbrir.TextColor = System.Drawing.Color.White;
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // pnList
            // 
            this.pnList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnList.Location = new System.Drawing.Point(178, 0);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(741, 4);
            this.pnList.TabIndex = 27;
            // 
            // AbrirPasta
            // 
            this.AbrirPasta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.AbrirPasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AbrirPasta.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.AbrirPasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AbrirPasta.FocusCuesEnabled = false;
            this.AbrirPasta.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbrirPasta.Image = global::Player.Properties.Resources.icons8_video_playlist_25px_1;
            this.AbrirPasta.Location = new System.Drawing.Point(1, 389);
            this.AbrirPasta.Name = "AbrirPasta";
            this.AbrirPasta.Size = new System.Drawing.Size(177, 40);
            this.AbrirPasta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.AbrirPasta.Symbol = "";
            this.AbrirPasta.TabIndex = 28;
            this.AbrirPasta.Text = "Abrir Pasta";
            this.AbrirPasta.TextColor = System.Drawing.Color.White;
            this.AbrirPasta.Click += new System.EventHandler(this.AbrirPasta_Click);
            // 
            // txtContList
            // 
            this.txtContList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContList.ForeColor = System.Drawing.Color.White;
            this.txtContList.Location = new System.Drawing.Point(695, 65);
            this.txtContList.Name = "txtContList";
            this.txtContList.Size = new System.Drawing.Size(40, 15);
            this.txtContList.TabIndex = 27;
            this.txtContList.Text = "00/00";
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.White;
            this.labelX3.Location = new System.Drawing.Point(645, 65);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(40, 15);
            this.labelX3.TabIndex = 28;
            this.labelX3.Text = "Itens:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(919, 538);
            this.Controls.Add(this.AbrirPasta);
            this.Controls.Add(this.pnList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCarregar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btAbrir);
            this.Controls.Add(this.stPlaylist);
            this.Controls.Add(this.player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.ListBox stPlaylist;
        private DevComponents.DotNetBar.ButtonX btAbrir;
        private DevComponents.DotNetBar.ButtonX btSalvar;
        private DevComponents.DotNetBar.ButtonX btCarregar;
        private DevComponents.DotNetBar.ButtonX btLimpar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btNext;
        private DevComponents.DotNetBar.LabelX lbTituloMusica;
        private DevComponents.DotNetBar.ButtonX btPausa;
        private DevComponents.DotNetBar.ButtonX btBack;
        private DevComponents.DotNetBar.LabelX lbRight;
        private DevComponents.DotNetBar.LabelX lbLeft;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.ButtonX btPlay;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private System.Windows.Forms.Panel pnList;
        private DevComponents.DotNetBar.ButtonX AbrirPasta;
        private DevComponents.DotNetBar.LabelX txtContList;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}

