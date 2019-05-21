namespace StarStand
{
    partial class GerirClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirClientes));
            this.PanelHeader = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSubmeter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textboxEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textboxTelemovel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textboxNIF = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textboxMorada = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textboxNome = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            this.PanelHeader.Size = new System.Drawing.Size(356, 44);
            this.PanelHeader.TabIndex = 16;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.Location = new System.Drawing.Point(313, 3);
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
            this.lblTitulo.Size = new System.Drawing.Size(79, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Clientes";
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
            this.btnSubmeter.Location = new System.Drawing.Point(46, 385);
            this.btnSubmeter.Name = "btnSubmeter";
            this.btnSubmeter.Normalcolor = System.Drawing.Color.ForestGreen;
            this.btnSubmeter.OnHovercolor = System.Drawing.Color.Green;
            this.btnSubmeter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSubmeter.selected = false;
            this.btnSubmeter.Size = new System.Drawing.Size(259, 48);
            this.btnSubmeter.TabIndex = 15;
            this.btnSubmeter.Text = "Inserir";
            this.btnSubmeter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubmeter.Textcolor = System.Drawing.Color.White;
            this.btnSubmeter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmeter.Click += new System.EventHandler(this.btnSubmeter_Click);
            // 
            // textboxEmail
            // 
            this.textboxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxEmail.HintForeColor = System.Drawing.Color.Empty;
            this.textboxEmail.HintText = "";
            this.textboxEmail.isPassword = false;
            this.textboxEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.textboxEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.textboxEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textboxEmail.LineThickness = 3;
            this.textboxEmail.Location = new System.Drawing.Point(60, 320);
            this.textboxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textboxEmail.Name = "textboxEmail";
            this.textboxEmail.Size = new System.Drawing.Size(236, 44);
            this.textboxEmail.TabIndex = 14;
            this.textboxEmail.Text = "Email";
            this.textboxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textboxTelemovel
            // 
            this.textboxTelemovel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxTelemovel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxTelemovel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxTelemovel.HintForeColor = System.Drawing.Color.Empty;
            this.textboxTelemovel.HintText = "";
            this.textboxTelemovel.isPassword = false;
            this.textboxTelemovel.LineFocusedColor = System.Drawing.Color.Blue;
            this.textboxTelemovel.LineIdleColor = System.Drawing.Color.Gray;
            this.textboxTelemovel.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textboxTelemovel.LineThickness = 3;
            this.textboxTelemovel.Location = new System.Drawing.Point(60, 216);
            this.textboxTelemovel.Margin = new System.Windows.Forms.Padding(4);
            this.textboxTelemovel.Name = "textboxTelemovel";
            this.textboxTelemovel.Size = new System.Drawing.Size(236, 44);
            this.textboxTelemovel.TabIndex = 13;
            this.textboxTelemovel.Text = "Telemovel";
            this.textboxTelemovel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textboxNIF
            // 
            this.textboxNIF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxNIF.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxNIF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxNIF.HintForeColor = System.Drawing.Color.Empty;
            this.textboxNIF.HintText = "";
            this.textboxNIF.isPassword = false;
            this.textboxNIF.LineFocusedColor = System.Drawing.Color.Blue;
            this.textboxNIF.LineIdleColor = System.Drawing.Color.Gray;
            this.textboxNIF.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textboxNIF.LineThickness = 3;
            this.textboxNIF.Location = new System.Drawing.Point(60, 164);
            this.textboxNIF.Margin = new System.Windows.Forms.Padding(4);
            this.textboxNIF.Name = "textboxNIF";
            this.textboxNIF.Size = new System.Drawing.Size(236, 44);
            this.textboxNIF.TabIndex = 12;
            this.textboxNIF.Text = "NIF";
            this.textboxNIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textboxMorada
            // 
            this.textboxMorada.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxMorada.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxMorada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxMorada.HintForeColor = System.Drawing.Color.Empty;
            this.textboxMorada.HintText = "";
            this.textboxMorada.isPassword = false;
            this.textboxMorada.LineFocusedColor = System.Drawing.Color.Blue;
            this.textboxMorada.LineIdleColor = System.Drawing.Color.Gray;
            this.textboxMorada.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textboxMorada.LineThickness = 3;
            this.textboxMorada.Location = new System.Drawing.Point(60, 268);
            this.textboxMorada.Margin = new System.Windows.Forms.Padding(4);
            this.textboxMorada.Name = "textboxMorada";
            this.textboxMorada.Size = new System.Drawing.Size(236, 44);
            this.textboxMorada.TabIndex = 11;
            this.textboxMorada.Text = "Morada";
            this.textboxMorada.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.textboxNome.Location = new System.Drawing.Point(60, 112);
            this.textboxNome.Margin = new System.Windows.Forms.Padding(4);
            this.textboxNome.Name = "textboxNome";
            this.textboxNome.Size = new System.Drawing.Size(236, 44);
            this.textboxNome.TabIndex = 10;
            this.textboxNome.Text = "Nome";
            this.textboxNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // GerirClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 450);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.btnSubmeter);
            this.Controls.Add(this.textboxEmail);
            this.Controls.Add(this.textboxTelemovel);
            this.Controls.Add(this.textboxNIF);
            this.Controls.Add(this.textboxMorada);
            this.Controls.Add(this.textboxNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerirClientes";
            this.Text = "GerirClientes";
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel PanelHeader;
        private Bunifu.Framework.UI.BunifuImageButton BtnClose;
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.Framework.UI.BunifuFlatButton btnSubmeter;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxTelemovel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxNIF;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxMorada;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxNome;
    }
}