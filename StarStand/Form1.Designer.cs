namespace StarStand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.slidingpanel = new System.Windows.Forms.Panel();
            this.btnGerirCarros = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOficina = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAluguer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVendas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.venda1 = new StarStand.USVenda();
            this.clientes1 = new StarStand.clientes();
            this.oficina1 = new StarStand.oficina();
            this.uSaluguer1 = new StarStand.USaluguer();
            this.slidingpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // slidingpanel
            // 
            this.slidingpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.slidingpanel.Controls.Add(this.btnGerirCarros);
            this.slidingpanel.Controls.Add(this.btnCliente);
            this.slidingpanel.Controls.Add(this.btnOficina);
            this.slidingpanel.Controls.Add(this.btnAluguer);
            this.slidingpanel.Controls.Add(this.btnVendas);
            this.slidingpanel.Controls.Add(this.bunifuImageButton1);
            this.slidingpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidingpanel.Location = new System.Drawing.Point(0, 37);
            this.slidingpanel.Name = "slidingpanel";
            this.slidingpanel.Size = new System.Drawing.Size(225, 622);
            this.slidingpanel.TabIndex = 0;
            // 
            // btnGerirCarros
            // 
            this.btnGerirCarros.Activecolor = System.Drawing.Color.Maroon;
            this.btnGerirCarros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnGerirCarros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGerirCarros.BorderRadius = 0;
            this.btnGerirCarros.ButtonText = "   Gerir Carros";
            this.btnGerirCarros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerirCarros.DisabledColor = System.Drawing.Color.Gray;
            this.btnGerirCarros.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGerirCarros.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGerirCarros.Iconimage")));
            this.btnGerirCarros.Iconimage_right = null;
            this.btnGerirCarros.Iconimage_right_Selected = null;
            this.btnGerirCarros.Iconimage_Selected = null;
            this.btnGerirCarros.IconMarginLeft = 0;
            this.btnGerirCarros.IconMarginRight = 0;
            this.btnGerirCarros.IconRightVisible = true;
            this.btnGerirCarros.IconRightZoom = 0D;
            this.btnGerirCarros.IconVisible = true;
            this.btnGerirCarros.IconZoom = 90D;
            this.btnGerirCarros.IsTab = false;
            this.btnGerirCarros.Location = new System.Drawing.Point(0, 516);
            this.btnGerirCarros.Name = "btnGerirCarros";
            this.btnGerirCarros.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnGerirCarros.OnHovercolor = System.Drawing.Color.Maroon;
            this.btnGerirCarros.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGerirCarros.selected = false;
            this.btnGerirCarros.Size = new System.Drawing.Size(225, 78);
            this.btnGerirCarros.TabIndex = 11;
            this.btnGerirCarros.Text = "   Gerir Carros";
            this.btnGerirCarros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerirCarros.Textcolor = System.Drawing.Color.White;
            this.btnGerirCarros.TextFont = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCliente
            // 
            this.btnCliente.Activecolor = System.Drawing.Color.Maroon;
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliente.BorderRadius = 0;
            this.btnCliente.ButtonText = "   Cliente";
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCliente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCliente.Iconimage")));
            this.btnCliente.Iconimage_right = null;
            this.btnCliente.Iconimage_right_Selected = null;
            this.btnCliente.Iconimage_Selected = null;
            this.btnCliente.IconMarginLeft = 0;
            this.btnCliente.IconMarginRight = 0;
            this.btnCliente.IconRightVisible = true;
            this.btnCliente.IconRightZoom = 0D;
            this.btnCliente.IconVisible = true;
            this.btnCliente.IconZoom = 90D;
            this.btnCliente.IsTab = false;
            this.btnCliente.Location = new System.Drawing.Point(0, 166);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnCliente.OnHovercolor = System.Drawing.Color.Maroon;
            this.btnCliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCliente.selected = false;
            this.btnCliente.Size = new System.Drawing.Size(225, 80);
            this.btnCliente.TabIndex = 9;
            this.btnCliente.Text = "   Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Textcolor = System.Drawing.Color.White;
            this.btnCliente.TextFont = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnOficina
            // 
            this.btnOficina.Activecolor = System.Drawing.Color.Maroon;
            this.btnOficina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnOficina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOficina.BorderRadius = 0;
            this.btnOficina.ButtonText = "    Oficina";
            this.btnOficina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOficina.DisabledColor = System.Drawing.Color.Gray;
            this.btnOficina.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOficina.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOficina.Iconimage")));
            this.btnOficina.Iconimage_right = null;
            this.btnOficina.Iconimage_right_Selected = null;
            this.btnOficina.Iconimage_Selected = null;
            this.btnOficina.IconMarginLeft = 0;
            this.btnOficina.IconMarginRight = 0;
            this.btnOficina.IconRightVisible = true;
            this.btnOficina.IconRightZoom = 0D;
            this.btnOficina.IconVisible = true;
            this.btnOficina.IconZoom = 90D;
            this.btnOficina.IsTab = false;
            this.btnOficina.Location = new System.Drawing.Point(0, 252);
            this.btnOficina.Name = "btnOficina";
            this.btnOficina.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnOficina.OnHovercolor = System.Drawing.Color.Maroon;
            this.btnOficina.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOficina.selected = false;
            this.btnOficina.Size = new System.Drawing.Size(225, 81);
            this.btnOficina.TabIndex = 8;
            this.btnOficina.Text = "    Oficina";
            this.btnOficina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOficina.Textcolor = System.Drawing.Color.White;
            this.btnOficina.TextFont = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOficina.Click += new System.EventHandler(this.btnOficina_Click);
            // 
            // btnAluguer
            // 
            this.btnAluguer.Activecolor = System.Drawing.Color.Maroon;
            this.btnAluguer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnAluguer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAluguer.BorderRadius = 0;
            this.btnAluguer.ButtonText = "   Aluguer";
            this.btnAluguer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAluguer.DisabledColor = System.Drawing.Color.Gray;
            this.btnAluguer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAluguer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAluguer.Iconimage")));
            this.btnAluguer.Iconimage_right = null;
            this.btnAluguer.Iconimage_right_Selected = null;
            this.btnAluguer.Iconimage_Selected = null;
            this.btnAluguer.IconMarginLeft = 0;
            this.btnAluguer.IconMarginRight = 0;
            this.btnAluguer.IconRightVisible = true;
            this.btnAluguer.IconRightZoom = 0D;
            this.btnAluguer.IconVisible = true;
            this.btnAluguer.IconZoom = 90D;
            this.btnAluguer.IsTab = false;
            this.btnAluguer.Location = new System.Drawing.Point(0, 339);
            this.btnAluguer.Name = "btnAluguer";
            this.btnAluguer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnAluguer.OnHovercolor = System.Drawing.Color.Maroon;
            this.btnAluguer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAluguer.selected = false;
            this.btnAluguer.Size = new System.Drawing.Size(225, 87);
            this.btnAluguer.TabIndex = 7;
            this.btnAluguer.Text = "   Aluguer";
            this.btnAluguer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAluguer.Textcolor = System.Drawing.Color.White;
            this.btnAluguer.TextFont = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluguer.Click += new System.EventHandler(this.BtnAluguer_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Activecolor = System.Drawing.Color.Maroon;
            this.btnVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVendas.BorderRadius = 0;
            this.btnVendas.ButtonText = "   Vendas";
            this.btnVendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVendas.DisabledColor = System.Drawing.Color.Gray;
            this.btnVendas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVendas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVendas.Iconimage")));
            this.btnVendas.Iconimage_right = null;
            this.btnVendas.Iconimage_right_Selected = null;
            this.btnVendas.Iconimage_Selected = null;
            this.btnVendas.IconMarginLeft = 0;
            this.btnVendas.IconMarginRight = 0;
            this.btnVendas.IconRightVisible = true;
            this.btnVendas.IconRightZoom = 0D;
            this.btnVendas.IconVisible = true;
            this.btnVendas.IconZoom = 90D;
            this.btnVendas.IsTab = false;
            this.btnVendas.Location = new System.Drawing.Point(0, 432);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnVendas.OnHovercolor = System.Drawing.Color.Maroon;
            this.btnVendas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVendas.selected = false;
            this.btnVendas.Size = new System.Drawing.Size(225, 78);
            this.btnVendas.TabIndex = 6;
            this.btnVendas.Text = "   Vendas";
            this.btnVendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendas.Textcolor = System.Drawing.Color.White;
            this.btnVendas.TextFont = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.Click += new System.EventHandler(this.BtnVendas_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 27);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(34, 29);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 10;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.labelTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1232, 37);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(1152, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(31, 30);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1189, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(3, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(102, 24);
            this.labelTitulo.TabIndex = 3;
            this.labelTitulo.Text = "StarStand";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.uSaluguer1);
            this.panelBody.Controls.Add(this.venda1);
            this.panelBody.Controls.Add(this.clientes1);
            this.panelBody.Controls.Add(this.oficina1);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(225, 37);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1007, 622);
            this.panelBody.TabIndex = 2;
            // 
            // venda1
            // 
            this.venda1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("venda1.BackgroundImage")));
            this.venda1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.venda1.Location = new System.Drawing.Point(0, 0);
            this.venda1.Name = "venda1";
            this.venda1.Size = new System.Drawing.Size(1007, 622);
            this.venda1.TabIndex = 2;
            // 
            // clientes1
            // 
            this.clientes1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clientes1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.clientes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientes1.Location = new System.Drawing.Point(0, 0);
            this.clientes1.Name = "clientes1";
            this.clientes1.Size = new System.Drawing.Size(1007, 622);
            this.clientes1.TabIndex = 1;
            // 
            // oficina1
            // 
            this.oficina1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.oficina1.Location = new System.Drawing.Point(0, 6);
            this.oficina1.Name = "oficina1";
            this.oficina1.Size = new System.Drawing.Size(1004, 616);
            this.oficina1.TabIndex = 0;
            // 
            // uSaluguer1
            // 
            this.uSaluguer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.uSaluguer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uSaluguer1.Location = new System.Drawing.Point(0, 0);
            this.uSaluguer1.Name = "uSaluguer1";
            this.uSaluguer1.Size = new System.Drawing.Size(1007, 622);
            this.uSaluguer1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1232, 659);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.slidingpanel);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.slidingpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel slidingpanel;
        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuFlatButton btnAluguer;
        private Bunifu.Framework.UI.BunifuFlatButton btnVendas;
        private Bunifu.Framework.UI.BunifuFlatButton btnCliente;
        private Bunifu.Framework.UI.BunifuFlatButton btnOficina;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panelBody;
        private clientes clientes1;
        private oficina oficina1;
        private System.Windows.Forms.Label labelTitulo;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private USVenda venda1;
        private Bunifu.Framework.UI.BunifuFlatButton btnGerirCarros;
        private USaluguer uSaluguer1;
    }
}

