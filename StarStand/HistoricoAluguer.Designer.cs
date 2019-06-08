namespace StarStand
{
    partial class HistoricoAluguer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoricoAluguer));
            this.PanelHeader = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.listBoxHist = new StarStand.ListBoxPersonal();
            this.btnRemoveCarros = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnFaturar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveCarros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFaturar)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
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
            this.PanelHeader.Size = new System.Drawing.Size(299, 44);
            this.PanelHeader.TabIndex = 1;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            this.PanelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            this.PanelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseUp);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.Location = new System.Drawing.Point(248, 3);
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
            this.lblTitulo.Size = new System.Drawing.Size(180, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Historico de aluguer";
            // 
            // listBoxHist
            // 
            this.listBoxHist.bgColorHead = System.Drawing.Color.Sienna;
            this.listBoxHist.bgcolorList = System.Drawing.SystemColors.AppWorkspace;
            this.listBoxHist.Location = new System.Drawing.Point(50, 7);
            this.listBoxHist.Name = "listBoxHist";
            this.listBoxHist.Size = new System.Drawing.Size(201, 341);
            this.listBoxHist.TabIndex = 2;
            this.listBoxHist.titleColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxHist.titulo = "Aluguer";
            // 
            // btnRemoveCarros
            // 
            this.btnRemoveCarros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveCarros.BackColor = System.Drawing.Color.Sienna;
            this.btnRemoveCarros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveCarros.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveCarros.Image")));
            this.btnRemoveCarros.ImageActive = null;
            this.btnRemoveCarros.Location = new System.Drawing.Point(208, 18);
            this.btnRemoveCarros.Name = "btnRemoveCarros";
            this.btnRemoveCarros.Size = new System.Drawing.Size(31, 33);
            this.btnRemoveCarros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRemoveCarros.TabIndex = 32;
            this.btnRemoveCarros.TabStop = false;
            this.btnRemoveCarros.Zoom = 10;
            this.btnRemoveCarros.Click += new System.EventHandler(this.BtnRemoveCarros_Click);
            // 
            // btnFaturar
            // 
            this.btnFaturar.BackColor = System.Drawing.Color.Sienna;
            this.btnFaturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaturar.Image = ((System.Drawing.Image)(resources.GetObject("btnFaturar.Image")));
            this.btnFaturar.ImageActive = null;
            this.btnFaturar.Location = new System.Drawing.Point(168, 18);
            this.btnFaturar.Name = "btnFaturar";
            this.btnFaturar.Size = new System.Drawing.Size(34, 33);
            this.btnFaturar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFaturar.TabIndex = 40;
            this.btnFaturar.TabStop = false;
            this.btnFaturar.Zoom = 10;
            this.btnFaturar.Click += new System.EventHandler(this.BtnFaturar_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnFaturar);
            this.bunifuGradientPanel1.Controls.Add(this.btnRemoveCarros);
            this.bunifuGradientPanel1.Controls.Add(this.listBoxHist);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DarkOrange;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Sienna;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 43);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(299, 360);
            this.bunifuGradientPanel1.TabIndex = 41;
            // 
            // HistoricoAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 403);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoricoAluguer";
            this.Text = "HistoricoAluguer";
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveCarros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFaturar)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel PanelHeader;
        private Bunifu.Framework.UI.BunifuImageButton BtnClose;
        private System.Windows.Forms.Label lblTitulo;
        private ListBoxPersonal listBoxHist;
        private Bunifu.Framework.UI.BunifuImageButton btnRemoveCarros;
        private Bunifu.Framework.UI.BunifuImageButton btnFaturar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
    }
}