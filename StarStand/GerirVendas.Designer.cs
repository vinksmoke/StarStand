namespace StarStand
{
    partial class GerirVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirVendas));
            this.btnSubmeter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TextboxMatricula = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBoxModelo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxMarca = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PanelHeader = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.comboboxCombustivel = new System.Windows.Forms.ComboBox();
            this.textBoxExtras = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.textboxValor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.pictureBoxCarro = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.listboxClientes = new StarStand.ListBoxPersonal();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmeter
            // 
            this.btnSubmeter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSubmeter.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSubmeter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmeter.BorderRadius = 0;
            this.btnSubmeter.ButtonText = "Inserir";
            this.btnSubmeter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmeter.DisabledColor = System.Drawing.Color.Gray;
            this.btnSubmeter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSubmeter.Iconimage = null;
            this.btnSubmeter.Iconimage_right = null;
            this.btnSubmeter.Iconimage_right_Selected = null;
            this.btnSubmeter.Iconimage_Selected = null;
            this.btnSubmeter.IconMarginLeft = 0;
            this.btnSubmeter.IconMarginRight = 0;
            this.btnSubmeter.IconRightVisible = true;
            this.btnSubmeter.IconRightZoom = 0D;
            this.btnSubmeter.IconVisible = true;
            this.btnSubmeter.IconZoom = 90D;
            this.btnSubmeter.IsTab = false;
            this.btnSubmeter.Location = new System.Drawing.Point(260, 337);
            this.btnSubmeter.Name = "btnSubmeter";
            this.btnSubmeter.Normalcolor = System.Drawing.Color.ForestGreen;
            this.btnSubmeter.OnHovercolor = System.Drawing.Color.Green;
            this.btnSubmeter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSubmeter.selected = false;
            this.btnSubmeter.Size = new System.Drawing.Size(412, 48);
            this.btnSubmeter.TabIndex = 10;
            this.btnSubmeter.Text = "Inserir";
            this.btnSubmeter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubmeter.Textcolor = System.Drawing.Color.White;
            this.btnSubmeter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmeter.Click += new System.EventHandler(this.BtnSubmeter_Click);
            // 
            // TextboxMatricula
            // 
            this.TextboxMatricula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxMatricula.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxMatricula.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxMatricula.HintText = "";
            this.TextboxMatricula.isPassword = false;
            this.TextboxMatricula.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxMatricula.LineIdleColor = System.Drawing.Color.Gray;
            this.TextboxMatricula.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxMatricula.LineThickness = 3;
            this.TextboxMatricula.Location = new System.Drawing.Point(273, 189);
            this.TextboxMatricula.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxMatricula.Name = "TextboxMatricula";
            this.TextboxMatricula.Size = new System.Drawing.Size(194, 44);
            this.TextboxMatricula.TabIndex = 9;
            this.TextboxMatricula.Text = "Matricula";
            this.TextboxMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextboxMatricula.Enter += new System.EventHandler(this.TextboxMatricula_Enter);
            this.TextboxMatricula.Leave += new System.EventHandler(this.TextboxMatricula_Leave);
            // 
            // TextBoxModelo
            // 
            this.TextBoxModelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxModelo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBoxModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxModelo.HintForeColor = System.Drawing.Color.Empty;
            this.TextBoxModelo.HintText = "";
            this.TextBoxModelo.isPassword = false;
            this.TextBoxModelo.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextBoxModelo.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBoxModelo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextBoxModelo.LineThickness = 3;
            this.TextBoxModelo.Location = new System.Drawing.Point(273, 137);
            this.TextBoxModelo.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxModelo.Name = "TextBoxModelo";
            this.TextBoxModelo.Size = new System.Drawing.Size(195, 44);
            this.TextBoxModelo.TabIndex = 8;
            this.TextBoxModelo.Text = "Modelo";
            this.TextBoxModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxModelo.Enter += new System.EventHandler(this.TextBoxModelo_Enter);
            this.TextBoxModelo.Leave += new System.EventHandler(this.TextBoxModelo_Leave);
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMarca.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxMarca.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxMarca.HintText = "";
            this.textBoxMarca.isPassword = false;
            this.textBoxMarca.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBoxMarca.LineIdleColor = System.Drawing.Color.Gray;
            this.textBoxMarca.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBoxMarca.LineThickness = 3;
            this.textBoxMarca.Location = new System.Drawing.Point(273, 85);
            this.textBoxMarca.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(195, 44);
            this.textBoxMarca.TabIndex = 7;
            this.textBoxMarca.Text = "Marca";
            this.textBoxMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMarca.Enter += new System.EventHandler(this.TextBoxMarca_Enter);
            this.textBoxMarca.Leave += new System.EventHandler(this.TextBoxMarca_Leave);
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelHeader.BackgroundImage")));
            this.PanelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHeader.Controls.Add(this.BtnClose);
            this.PanelHeader.Controls.Add(this.lblTitulo);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.GradientBottomLeft = System.Drawing.Color.White;
            this.PanelHeader.GradientBottomRight = System.Drawing.Color.White;
            this.PanelHeader.GradientTopLeft = System.Drawing.Color.Black;
            this.PanelHeader.GradientTopRight = System.Drawing.Color.White;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Quality = 10;
            this.PanelHeader.Size = new System.Drawing.Size(685, 44);
            this.PanelHeader.TabIndex = 6;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            this.PanelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            this.PanelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseUp);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.Location = new System.Drawing.Point(634, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(39, 34);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnClose.TabIndex = 6;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 10;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(65, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Venda";
            // 
            // comboboxCombustivel
            // 
            this.comboboxCombustivel.BackColor = System.Drawing.Color.Silver;
            this.comboboxCombustivel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboboxCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxCombustivel.FormattingEnabled = true;
            this.comboboxCombustivel.Items.AddRange(new object[] {
            "Gasolina",
            "Diesel",
            "GPL"});
            this.comboboxCombustivel.Location = new System.Drawing.Point(273, 292);
            this.comboboxCombustivel.Name = "comboboxCombustivel";
            this.comboboxCombustivel.Size = new System.Drawing.Size(194, 24);
            this.comboboxCombustivel.TabIndex = 24;
            this.comboboxCombustivel.Text = "Combustível";
            // 
            // textBoxExtras
            // 
            this.textBoxExtras.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExtras.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxExtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxExtras.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxExtras.HintText = "";
            this.textBoxExtras.isPassword = false;
            this.textBoxExtras.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBoxExtras.LineIdleColor = System.Drawing.Color.Gray;
            this.textBoxExtras.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBoxExtras.LineThickness = 3;
            this.textBoxExtras.Location = new System.Drawing.Point(273, 241);
            this.textBoxExtras.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxExtras.Name = "textBoxExtras";
            this.textBoxExtras.Size = new System.Drawing.Size(194, 44);
            this.textBoxExtras.TabIndex = 25;
            this.textBoxExtras.Text = "Extra";
            this.textBoxExtras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxExtras.Enter += new System.EventHandler(this.TextBoxExtras_Enter);
            this.textBoxExtras.Leave += new System.EventHandler(this.TextBoxExtras_Leave);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuSeparator1.LineThickness = 5;
            this.bunifuSeparator1.Location = new System.Drawing.Point(474, 54);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(27, 281);
            this.bunifuSeparator1.TabIndex = 26;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // textboxValor
            // 
            this.textboxValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxValor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxValor.HintForeColor = System.Drawing.Color.Empty;
            this.textboxValor.HintText = "";
            this.textboxValor.isPassword = false;
            this.textboxValor.LineFocusedColor = System.Drawing.Color.Blue;
            this.textboxValor.LineIdleColor = System.Drawing.Color.Gray;
            this.textboxValor.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textboxValor.LineThickness = 3;
            this.textboxValor.Location = new System.Drawing.Point(520, 225);
            this.textboxValor.Margin = new System.Windows.Forms.Padding(4);
            this.textboxValor.Name = "textboxValor";
            this.textboxValor.Size = new System.Drawing.Size(152, 44);
            this.textboxValor.TabIndex = 27;
            this.textboxValor.Text = "Valor";
            this.textboxValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxValor.Enter += new System.EventHandler(this.TextboxValor_Enter);
            this.textboxValor.Leave += new System.EventHandler(this.TextboxValor_Leave);
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.BackColor = System.Drawing.Color.Silver;
            this.comboBoxEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Usado",
            "Semi-novo",
            "Novo"});
            this.comboBoxEstado.Location = new System.Drawing.Point(520, 292);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(153, 24);
            this.comboBoxEstado.TabIndex = 28;
            this.comboBoxEstado.Text = "Estado";
            // 
            // pictureBoxCarro
            // 
            this.pictureBoxCarro.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCarro.ErrorImage")));
            this.pictureBoxCarro.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCarro.Image")));
            this.pictureBoxCarro.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCarro.InitialImage")));
            this.pictureBoxCarro.Location = new System.Drawing.Point(520, 63);
            this.pictureBoxCarro.Name = "pictureBoxCarro";
            this.pictureBoxCarro.Size = new System.Drawing.Size(153, 126);
            this.pictureBoxCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCarro.TabIndex = 29;
            this.pictureBoxCarro.TabStop = false;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(202, 63);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(31, 35);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 38;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.BtnRemoveClientes_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(128, 63);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(31, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 36;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BtnAddClientes_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(165, 63);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(31, 35);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 37;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.BtnEditClientes_Click);
            // 
            // listboxClientes
            // 
            this.listboxClientes.bgColorHead = System.Drawing.Color.DarkSlateGray;
            this.listboxClientes.bgcolorList = System.Drawing.Color.LightCyan;
            this.listboxClientes.Location = new System.Drawing.Point(12, 54);
            this.listboxClientes.Name = "listboxClientes";
            this.listboxClientes.Size = new System.Drawing.Size(241, 331);
            this.listboxClientes.TabIndex = 35;
            this.listboxClientes.titleColor = System.Drawing.Color.White;
            this.listboxClientes.titulo = "Clientes";
            // 
            // GerirVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 405);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.listboxClientes);
            this.Controls.Add(this.pictureBoxCarro);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.textboxValor);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.textBoxExtras);
            this.Controls.Add(this.comboboxCombustivel);
            this.Controls.Add(this.btnSubmeter);
            this.Controls.Add(this.TextboxMatricula);
            this.Controls.Add(this.TextBoxModelo);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerirVendas";
            this.Text = "GerirVendas";
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnSubmeter;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxMatricula;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBoxModelo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxMarca;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelHeader;
        private Bunifu.Framework.UI.BunifuImageButton BtnClose;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox comboboxCombustivel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxExtras;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxValor;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.PictureBox pictureBoxCarro;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private ListBoxPersonal listboxClientes;
    }
}