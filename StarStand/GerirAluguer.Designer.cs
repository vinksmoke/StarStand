namespace StarStand
{
    partial class GerirAluguer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirAluguer));
            this.PanelHeader = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.DatepickerEntrada = new Bunifu.Framework.UI.BunifuDatepicker();
            this.DatepickerSaida = new Bunifu.Framework.UI.BunifuDatepicker();
            this.textboxKms = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textboxTotal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInserir = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.PanelHeader.Size = new System.Drawing.Size(358, 44);
            this.PanelHeader.TabIndex = 18;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            this.PanelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            this.PanelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseUp);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.Location = new System.Drawing.Point(301, 3);
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
            this.lblTitulo.Size = new System.Drawing.Size(84, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = " Aluguer";
            // 
            // DatepickerEntrada
            // 
            this.DatepickerEntrada.BackColor = System.Drawing.Color.SeaGreen;
            this.DatepickerEntrada.BorderRadius = 0;
            this.DatepickerEntrada.ForeColor = System.Drawing.Color.White;
            this.DatepickerEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DatepickerEntrada.FormatCustom = null;
            this.DatepickerEntrada.Location = new System.Drawing.Point(19, 81);
            this.DatepickerEntrada.Name = "DatepickerEntrada";
            this.DatepickerEntrada.Size = new System.Drawing.Size(303, 36);
            this.DatepickerEntrada.TabIndex = 19;
            this.DatepickerEntrada.Value = new System.DateTime(2019, 6, 6, 0, 41, 1, 174);
            this.DatepickerEntrada.onValueChanged += new System.EventHandler(this.DatepickerEntrada_onValueChanged);
            // 
            // DatepickerSaida
            // 
            this.DatepickerSaida.BackColor = System.Drawing.Color.SeaGreen;
            this.DatepickerSaida.BorderRadius = 0;
            this.DatepickerSaida.ForeColor = System.Drawing.Color.White;
            this.DatepickerSaida.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DatepickerSaida.FormatCustom = null;
            this.DatepickerSaida.Location = new System.Drawing.Point(19, 165);
            this.DatepickerSaida.Name = "DatepickerSaida";
            this.DatepickerSaida.Size = new System.Drawing.Size(303, 36);
            this.DatepickerSaida.TabIndex = 20;
            this.DatepickerSaida.Value = new System.DateTime(2019, 6, 6, 0, 41, 1, 174);
            this.DatepickerSaida.onValueChanged += new System.EventHandler(this.DatepickerSaida_onValueChanged);
            // 
            // textboxKms
            // 
            this.textboxKms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxKms.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxKms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxKms.HintForeColor = System.Drawing.Color.Empty;
            this.textboxKms.HintText = "";
            this.textboxKms.isPassword = false;
            this.textboxKms.LineFocusedColor = System.Drawing.Color.Blue;
            this.textboxKms.LineIdleColor = System.Drawing.Color.Gray;
            this.textboxKms.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textboxKms.LineThickness = 3;
            this.textboxKms.Location = new System.Drawing.Point(19, 208);
            this.textboxKms.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textboxKms.Name = "textboxKms";
            this.textboxKms.Size = new System.Drawing.Size(303, 44);
            this.textboxKms.TabIndex = 22;
            this.textboxKms.Text = "KMS";
            this.textboxKms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxKms.OnValueChanged += new System.EventHandler(this.TextboxKms_OnValueChanged);
            this.textboxKms.Enter += new System.EventHandler(this.TextboxKms_Enter);
            this.textboxKms.Leave += new System.EventHandler(this.TextboxKms_Leave);
            // 
            // textboxTotal
            // 
            this.textboxTotal.BorderColorFocused = System.Drawing.Color.Blue;
            this.textboxTotal.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxTotal.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.textboxTotal.BorderThickness = 3;
            this.textboxTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxTotal.Enabled = false;
            this.textboxTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxTotal.isPassword = false;
            this.textboxTotal.Location = new System.Drawing.Point(142, 269);
            this.textboxTotal.Margin = new System.Windows.Forms.Padding(4);
            this.textboxTotal.Name = "textboxTotal";
            this.textboxTotal.Size = new System.Drawing.Size(180, 46);
            this.textboxTotal.TabIndex = 23;
            this.textboxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Data de Entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Data de Saida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Valor Final:";
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
            this.btnInserir.Location = new System.Drawing.Point(19, 328);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Normalcolor = System.Drawing.Color.ForestGreen;
            this.btnInserir.OnHovercolor = System.Drawing.Color.Green;
            this.btnInserir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInserir.selected = false;
            this.btnInserir.Size = new System.Drawing.Size(303, 48);
            this.btnInserir.TabIndex = 27;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInserir.Textcolor = System.Drawing.Color.White;
            this.btnInserir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // GerirAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 388);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxTotal);
            this.Controls.Add(this.textboxKms);
            this.Controls.Add(this.DatepickerSaida);
            this.Controls.Add(this.DatepickerEntrada);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerirAluguer";
            this.Text = "GerirAluguer";
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel PanelHeader;
        private Bunifu.Framework.UI.BunifuImageButton BtnClose;
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.Framework.UI.BunifuDatepicker DatepickerEntrada;
        private Bunifu.Framework.UI.BunifuDatepicker DatepickerSaida;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxKms;
        private Bunifu.Framework.UI.BunifuMetroTextbox textboxTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnInserir;
    }
}