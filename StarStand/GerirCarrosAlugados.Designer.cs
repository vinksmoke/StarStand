namespace StarStand
{
    partial class GerirCarrosAlugados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirCarrosAlugados));
            this.PanelHeader = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.textboxModelo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textboxMarca = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnInserir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.comboboxCombustivel = new System.Windows.Forms.ComboBox();
            this.textboxValorBase = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
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
            this.PanelHeader.Size = new System.Drawing.Size(361, 44);
            this.PanelHeader.TabIndex = 17;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            this.PanelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            this.PanelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseUp);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.Location = new System.Drawing.Point(314, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(45, 34);
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
            this.lblTitulo.Location = new System.Drawing.Point(14, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(148, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Carros Alugados";
            // 
            // textboxModelo
            // 
            this.textboxModelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxModelo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxModelo.HintForeColor = System.Drawing.Color.Empty;
            this.textboxModelo.HintText = "";
            this.textboxModelo.isPassword = false;
            this.textboxModelo.LineFocusedColor = System.Drawing.Color.Blue;
            this.textboxModelo.LineIdleColor = System.Drawing.Color.Gray;
            this.textboxModelo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textboxModelo.LineThickness = 3;
            this.textboxModelo.Location = new System.Drawing.Point(45, 144);
            this.textboxModelo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textboxModelo.Name = "textboxModelo";
            this.textboxModelo.Size = new System.Drawing.Size(275, 44);
            this.textboxModelo.TabIndex = 20;
            this.textboxModelo.Text = "Modelo";
            this.textboxModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxMarca
            // 
            this.textboxMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxMarca.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxMarca.HintForeColor = System.Drawing.Color.Empty;
            this.textboxMarca.HintText = "";
            this.textboxMarca.isPassword = false;
            this.textboxMarca.LineFocusedColor = System.Drawing.Color.Blue;
            this.textboxMarca.LineIdleColor = System.Drawing.Color.Gray;
            this.textboxMarca.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textboxMarca.LineThickness = 3;
            this.textboxMarca.Location = new System.Drawing.Point(45, 92);
            this.textboxMarca.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textboxMarca.Name = "textboxMarca";
            this.textboxMarca.Size = new System.Drawing.Size(275, 44);
            this.textboxMarca.TabIndex = 21;
            this.textboxMarca.Text = "Marca";
            this.textboxMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnInserir
            // 
            this.btnInserir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInserir.BackColor = System.Drawing.Color.ForestGreen;
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInserir.BorderRadius = 0;
            this.btnInserir.ButtonText = "Inserir";
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.DisabledColor = System.Drawing.Color.Gray;
            this.btnInserir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInserir.Iconimage = null;
            this.btnInserir.Iconimage_right = null;
            this.btnInserir.Iconimage_right_Selected = null;
            this.btnInserir.Iconimage_Selected = null;
            this.btnInserir.IconMarginLeft = 0;
            this.btnInserir.IconMarginRight = 0;
            this.btnInserir.IconRightVisible = true;
            this.btnInserir.IconRightZoom = 0D;
            this.btnInserir.IconVisible = true;
            this.btnInserir.IconZoom = 90D;
            this.btnInserir.IsTab = false;
            this.btnInserir.Location = new System.Drawing.Point(41, 303);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Normalcolor = System.Drawing.Color.ForestGreen;
            this.btnInserir.OnHovercolor = System.Drawing.Color.Green;
            this.btnInserir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInserir.selected = false;
            this.btnInserir.Size = new System.Drawing.Size(276, 48);
            this.btnInserir.TabIndex = 22;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInserir.Textcolor = System.Drawing.Color.White;
            this.btnInserir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // comboboxCombustivel
            // 
            this.comboboxCombustivel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboboxCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxCombustivel.FormattingEnabled = true;
            this.comboboxCombustivel.Items.AddRange(new object[] {
            "Gasolina",
            "Diesel",
            "GPL"});
            this.comboboxCombustivel.Location = new System.Drawing.Point(45, 258);
            this.comboboxCombustivel.Name = "comboboxCombustivel";
            this.comboboxCombustivel.Size = new System.Drawing.Size(274, 24);
            this.comboboxCombustivel.TabIndex = 23;
            this.comboboxCombustivel.Text = "Combustível";
            // 
            // textboxValorBase
            // 
            this.textboxValorBase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxValorBase.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxValorBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxValorBase.HintForeColor = System.Drawing.Color.Empty;
            this.textboxValorBase.HintText = "";
            this.textboxValorBase.isPassword = false;
            this.textboxValorBase.LineFocusedColor = System.Drawing.Color.Blue;
            this.textboxValorBase.LineIdleColor = System.Drawing.Color.Gray;
            this.textboxValorBase.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textboxValorBase.LineThickness = 3;
            this.textboxValorBase.Location = new System.Drawing.Point(45, 196);
            this.textboxValorBase.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textboxValorBase.Name = "textboxValorBase";
            this.textboxValorBase.Size = new System.Drawing.Size(272, 44);
            this.textboxValorBase.TabIndex = 24;
            this.textboxValorBase.Text = "Valor Base";
            this.textboxValorBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GerirCarrosAlugados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 363);
            this.Controls.Add(this.textboxValorBase);
            this.Controls.Add(this.comboboxCombustivel);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.textboxMarca);
            this.Controls.Add(this.textboxModelo);
            this.Controls.Add(this.PanelHeader);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerirCarrosAlugados";
            this.Text = "GerirAlugados";
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel PanelHeader;
        private Bunifu.Framework.UI.BunifuImageButton BtnClose;
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxModelo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxMarca;
        private Bunifu.Framework.UI.BunifuFlatButton btnInserir;
        private System.Windows.Forms.ComboBox comboboxCombustivel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxValorBase;
    }
}