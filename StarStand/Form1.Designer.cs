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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.slidingpanel = new System.Windows.Forms.Panel();
            this.btnCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOficina = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAluguer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVendas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCloseProgram = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.clientes1 = new StarStand.clientes();
            this.oficina1 = new StarStand.oficina();
            this.slidingpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseProgram)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // slidingpanel
            // 
            this.slidingpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
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
            // btnCliente
            // 
            this.btnCliente.Activecolor = System.Drawing.Color.Maroon;
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliente.BorderRadius = 0;
            this.btnCliente.ButtonText = "          Cliente";
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
            this.btnCliente.Text = "          Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Textcolor = System.Drawing.Color.White;
            this.btnCliente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnOficina
            // 
            this.btnOficina.Activecolor = System.Drawing.Color.Maroon;
            this.btnOficina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnOficina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOficina.BorderRadius = 0;
            this.btnOficina.ButtonText = "         Oficina";
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
            this.btnOficina.Location = new System.Drawing.Point(-3, 243);
            this.btnOficina.Name = "btnOficina";
            this.btnOficina.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnOficina.OnHovercolor = System.Drawing.Color.Maroon;
            this.btnOficina.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOficina.selected = false;
            this.btnOficina.Size = new System.Drawing.Size(225, 81);
            this.btnOficina.TabIndex = 8;
            this.btnOficina.Text = "         Oficina";
            this.btnOficina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOficina.Textcolor = System.Drawing.Color.White;
            this.btnOficina.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOficina.Click += new System.EventHandler(this.btnOficina_Click);
            // 
            // btnAluguer
            // 
            this.btnAluguer.Activecolor = System.Drawing.Color.Maroon;
            this.btnAluguer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnAluguer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAluguer.BorderRadius = 0;
            this.btnAluguer.ButtonText = "         Aluguer";
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
            this.btnAluguer.Location = new System.Drawing.Point(0, 330);
            this.btnAluguer.Name = "btnAluguer";
            this.btnAluguer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnAluguer.OnHovercolor = System.Drawing.Color.Maroon;
            this.btnAluguer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAluguer.selected = false;
            this.btnAluguer.Size = new System.Drawing.Size(225, 87);
            this.btnAluguer.TabIndex = 7;
            this.btnAluguer.Text = "         Aluguer";
            this.btnAluguer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAluguer.Textcolor = System.Drawing.Color.White;
            this.btnAluguer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnVendas
            // 
            this.btnVendas.Activecolor = System.Drawing.Color.Maroon;
            this.btnVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVendas.BorderRadius = 0;
            this.btnVendas.ButtonText = "         Vendas";
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
            this.btnVendas.Location = new System.Drawing.Point(-3, 414);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnVendas.OnHovercolor = System.Drawing.Color.Maroon;
            this.btnVendas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVendas.selected = false;
            this.btnVendas.Size = new System.Drawing.Size(225, 78);
            this.btnVendas.TabIndex = 6;
            this.btnVendas.Text = "         Vendas";
            this.btnVendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendas.Textcolor = System.Drawing.Color.White;
            this.btnVendas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panelHeader.Controls.Add(this.btnCloseProgram);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1232, 37);
            this.panelHeader.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(1153, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(33, 31);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnCloseProgram
            // 
            this.btnCloseProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCloseProgram.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseProgram.Image")));
            this.btnCloseProgram.ImageActive = null;
            this.btnCloseProgram.Location = new System.Drawing.Point(1192, 3);
            this.btnCloseProgram.Name = "btnCloseProgram";
            this.btnCloseProgram.Size = new System.Drawing.Size(28, 31);
            this.btnCloseProgram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseProgram.TabIndex = 0;
            this.btnCloseProgram.TabStop = false;
            this.btnCloseProgram.Zoom = 10;
            this.btnCloseProgram.Click += new System.EventHandler(this.btnCloseProgram_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clientes1);
            this.panel1.Controls.Add(this.oficina1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(225, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 622);
            this.panel1.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // clientes1
            // 
            this.clientes1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clientes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientes1.Location = new System.Drawing.Point(0, 0);
            this.clientes1.Name = "clientes1";
            this.clientes1.Size = new System.Drawing.Size(1007, 622);
            this.clientes1.TabIndex = 1;
            // 
            // oficina1
            // 
            this.oficina1.Location = new System.Drawing.Point(0, 6);
            this.oficina1.Name = "oficina1";
            this.oficina1.Size = new System.Drawing.Size(1004, 616);
            this.oficina1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1232, 659);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.slidingpanel);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.slidingpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseProgram)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel slidingpanel;
        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuImageButton btnCloseProgram;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuFlatButton btnAluguer;
        private Bunifu.Framework.UI.BunifuFlatButton btnVendas;
        private Bunifu.Framework.UI.BunifuFlatButton btnCliente;
        private Bunifu.Framework.UI.BunifuFlatButton btnOficina;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private clientes clientes1;
        private oficina oficina1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

