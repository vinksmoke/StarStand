namespace StarStand
{
    partial class GerirCarros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirCarros));
            this.PanelHeader = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.textBoxMarca = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBoxModelo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextboxMatricula = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textboxCombustivel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            this.PanelHeader.Size = new System.Drawing.Size(284, 44);
            this.PanelHeader.TabIndex = 0;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            this.PanelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            this.PanelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseUp);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.Location = new System.Drawing.Point(242, 3);
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
            this.lblTitulo.Text = "Carros";
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
            this.textBoxMarca.Location = new System.Drawing.Point(13, 51);
            this.textBoxMarca.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(258, 44);
            this.textBoxMarca.TabIndex = 1;
            this.textBoxMarca.Text = "Marca";
            this.textBoxMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMarca.Enter += new System.EventHandler(this.TextBoxMarca_Enter);
            this.textBoxMarca.Leave += new System.EventHandler(this.TextBoxMarca_Leave);
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
            this.TextBoxModelo.Location = new System.Drawing.Point(13, 103);
            this.TextBoxModelo.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxModelo.Name = "TextBoxModelo";
            this.TextBoxModelo.Size = new System.Drawing.Size(258, 44);
            this.TextBoxModelo.TabIndex = 2;
            this.TextBoxModelo.Text = "Modelo";
            this.TextBoxModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxModelo.Enter += new System.EventHandler(this.TextBoxModelo_Enter);
            this.TextBoxModelo.Leave += new System.EventHandler(this.TextBoxModelo_Leave);
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
            this.TextboxMatricula.Location = new System.Drawing.Point(13, 155);
            this.TextboxMatricula.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxMatricula.Name = "TextboxMatricula";
            this.TextboxMatricula.Size = new System.Drawing.Size(258, 44);
            this.TextboxMatricula.TabIndex = 3;
            this.TextboxMatricula.Text = "Matricula";
            this.TextboxMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextboxMatricula.Enter += new System.EventHandler(this.TextboxMatricula_Enter);
            this.TextboxMatricula.Leave += new System.EventHandler(this.TextboxMatricula_Leave);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.ForestGreen;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Inserir";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(12, 272);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.ForestGreen;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Green;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(259, 48);
            this.bunifuFlatButton1.TabIndex = 4;
            this.bunifuFlatButton1.Text = "Inserir";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // textboxCombustivel
            // 
            this.textboxCombustivel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxCombustivel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxCombustivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxCombustivel.HintForeColor = System.Drawing.Color.Empty;
            this.textboxCombustivel.HintText = "";
            this.textboxCombustivel.isPassword = false;
            this.textboxCombustivel.LineFocusedColor = System.Drawing.Color.Blue;
            this.textboxCombustivel.LineIdleColor = System.Drawing.Color.Gray;
            this.textboxCombustivel.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textboxCombustivel.LineThickness = 3;
            this.textboxCombustivel.Location = new System.Drawing.Point(12, 207);
            this.textboxCombustivel.Margin = new System.Windows.Forms.Padding(4);
            this.textboxCombustivel.Name = "textboxCombustivel";
            this.textboxCombustivel.Size = new System.Drawing.Size(259, 44);
            this.textboxCombustivel.TabIndex = 5;
            this.textboxCombustivel.Text = "Combustivel";
            this.textboxCombustivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxCombustivel.Enter += new System.EventHandler(this.TextboxCombustivel_Enter);
            this.textboxCombustivel.Leave += new System.EventHandler(this.TextboxCombustivel_Leave);
            // 
            // GerirCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 355);
            this.Controls.Add(this.textboxCombustivel);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.TextboxMatricula);
            this.Controls.Add(this.TextBoxModelo);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerirCarros";
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel PanelHeader;
        private Bunifu.Framework.UI.BunifuImageButton BtnClose;
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxMarca;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBoxModelo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxMatricula;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxCombustivel;
    }
}