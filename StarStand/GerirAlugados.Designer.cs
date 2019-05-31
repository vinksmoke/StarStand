namespace StarStand
{
    partial class GerirAlugados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirAlugados));
            this.PanelHeader = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.textboxNome = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSubmeter = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.PanelHeader.Size = new System.Drawing.Size(318, 44);
            this.PanelHeader.TabIndex = 17;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.Location = new System.Drawing.Point(269, 6);
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
            this.lblTitulo.Size = new System.Drawing.Size(148, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Carros Alugados";
            // 
            // textboxNome
            // 
            this.textboxNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxNome.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxNome.HintForeColor = System.Drawing.Color.Empty;
            this.textboxNome.HintText = "";
            this.textboxNome.isPassword = false;
            this.textboxNome.LineFocusedColor = System.Drawing.Color.Blue;
            this.textboxNome.LineIdleColor = System.Drawing.Color.Gray;
            this.textboxNome.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textboxNome.LineThickness = 3;
            this.textboxNome.Location = new System.Drawing.Point(41, 196);
            this.textboxNome.Margin = new System.Windows.Forms.Padding(4);
            this.textboxNome.Name = "textboxNome";
            this.textboxNome.Size = new System.Drawing.Size(236, 44);
            this.textboxNome.TabIndex = 18;
            this.textboxNome.Text = "Kms";
            this.textboxNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(41, 248);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(236, 44);
            this.bunifuMaterialTextbox1.TabIndex = 19;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(41, 144);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(236, 44);
            this.bunifuMaterialTextbox2.TabIndex = 20;
            this.bunifuMaterialTextbox2.Text = "Modelo";
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox3.HintText = "";
            this.bunifuMaterialTextbox3.isPassword = false;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox3.LineThickness = 3;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(41, 92);
            this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(236, 44);
            this.bunifuMaterialTextbox3.TabIndex = 21;
            this.bunifuMaterialTextbox3.Text = "Marca";
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnSubmeter.Location = new System.Drawing.Point(29, 318);
            this.btnSubmeter.Name = "btnSubmeter";
            this.btnSubmeter.Normalcolor = System.Drawing.Color.ForestGreen;
            this.btnSubmeter.OnHovercolor = System.Drawing.Color.Green;
            this.btnSubmeter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSubmeter.selected = false;
            this.btnSubmeter.Size = new System.Drawing.Size(259, 48);
            this.btnSubmeter.TabIndex = 22;
            this.btnSubmeter.Text = "Inserir";
            this.btnSubmeter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubmeter.Textcolor = System.Drawing.Color.White;
            this.btnSubmeter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // GerirAlugados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 389);
            this.Controls.Add(this.btnSubmeter);
            this.Controls.Add(this.bunifuMaterialTextbox3);
            this.Controls.Add(this.bunifuMaterialTextbox2);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.textboxNome);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerirAlugados";
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxNome;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        private Bunifu.Framework.UI.BunifuFlatButton btnSubmeter;
    }
}