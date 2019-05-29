namespace StarStand
{
    partial class USaluguer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USaluguer));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.labelMostraKms = new System.Windows.Forms.Label();
            this.labelMostraEstado = new System.Windows.Forms.Label();
            this.labelMostraValor = new System.Windows.Forms.Label();
            this.labelMostraMarca = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelKms = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.panelPeças = new System.Windows.Forms.Panel();
            this.buttonAlugar = new System.Windows.Forms.Button();
            this.pictureBoxCarro = new System.Windows.Forms.PictureBox();
            this.btnAddCarros = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEditCarros = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRemoveCarros = new Bunifu.Framework.UI.BunifuImageButton();
            this.listboxCarros = new StarStand.ListBoxPersonal();
            this.listboxClientes = new StarStand.ListBoxPersonal();
            this.bunifuCards1.SuspendLayout();
            this.panelPeças.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCarros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditCarros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Maroon;
            this.bunifuCards1.Controls.Add(this.labelMostraKms);
            this.bunifuCards1.Controls.Add(this.labelMostraEstado);
            this.bunifuCards1.Controls.Add(this.labelMostraValor);
            this.bunifuCards1.Controls.Add(this.labelMostraMarca);
            this.bunifuCards1.Controls.Add(this.labelEstado);
            this.bunifuCards1.Controls.Add(this.labelKms);
            this.bunifuCards1.Controls.Add(this.labelValor);
            this.bunifuCards1.Controls.Add(this.labelMarca);
            this.bunifuCards1.Controls.Add(this.panelPeças);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(300, 75);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(420, 469);
            this.bunifuCards1.TabIndex = 4;
            // 
            // labelMostraKms
            // 
            this.labelMostraKms.AutoSize = true;
            this.labelMostraKms.Location = new System.Drawing.Point(216, 64);
            this.labelMostraKms.Name = "labelMostraKms";
            this.labelMostraKms.Size = new System.Drawing.Size(95, 13);
            this.labelMostraKms.TabIndex = 41;
            this.labelMostraKms.Text = "Nada Selecionado";
            // 
            // labelMostraEstado
            // 
            this.labelMostraEstado.AutoSize = true;
            this.labelMostraEstado.Location = new System.Drawing.Point(229, 20);
            this.labelMostraEstado.Name = "labelMostraEstado";
            this.labelMostraEstado.Size = new System.Drawing.Size(95, 13);
            this.labelMostraEstado.TabIndex = 40;
            this.labelMostraEstado.Text = "Nada Selecionado";
            // 
            // labelMostraValor
            // 
            this.labelMostraValor.AutoSize = true;
            this.labelMostraValor.Location = new System.Drawing.Point(53, 64);
            this.labelMostraValor.Name = "labelMostraValor";
            this.labelMostraValor.Size = new System.Drawing.Size(95, 13);
            this.labelMostraValor.TabIndex = 39;
            this.labelMostraValor.Text = "Nada Selecionado";
            // 
            // labelMostraMarca
            // 
            this.labelMostraMarca.AutoSize = true;
            this.labelMostraMarca.Location = new System.Drawing.Point(59, 20);
            this.labelMostraMarca.Name = "labelMostraMarca";
            this.labelMostraMarca.Size = new System.Drawing.Size(95, 13);
            this.labelMostraMarca.TabIndex = 0;
            this.labelMostraMarca.Text = "Nada Selecionado";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(180, 20);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(43, 13);
            this.labelEstado.TabIndex = 38;
            this.labelEstado.Text = "Estado:";
            // 
            // labelKms
            // 
            this.labelKms.AutoSize = true;
            this.labelKms.Location = new System.Drawing.Point(180, 64);
            this.labelKms.Name = "labelKms";
            this.labelKms.Size = new System.Drawing.Size(30, 13);
            this.labelKms.TabIndex = 37;
            this.labelKms.Text = "Kms:";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(13, 64);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(34, 13);
            this.labelValor.TabIndex = 36;
            this.labelValor.Text = "Valor:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(13, 20);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 5;
            this.labelMarca.Text = "Marca:";
            // 
            // panelPeças
            // 
            this.panelPeças.Controls.Add(this.buttonAlugar);
            this.panelPeças.Controls.Add(this.pictureBoxCarro);
            this.panelPeças.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPeças.Location = new System.Drawing.Point(0, 121);
            this.panelPeças.Name = "panelPeças";
            this.panelPeças.Size = new System.Drawing.Size(420, 348);
            this.panelPeças.TabIndex = 35;
            // 
            // buttonAlugar
            // 
            this.buttonAlugar.BackColor = System.Drawing.Color.Maroon;
            this.buttonAlugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlugar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAlugar.Location = new System.Drawing.Point(148, 291);
            this.buttonAlugar.Name = "buttonAlugar";
            this.buttonAlugar.Size = new System.Drawing.Size(125, 39);
            this.buttonAlugar.TabIndex = 1;
            this.buttonAlugar.Text = "Alugar";
            this.buttonAlugar.UseVisualStyleBackColor = false;
            // 
            // pictureBoxCarro
            // 
            this.pictureBoxCarro.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCarro.ErrorImage")));
            this.pictureBoxCarro.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCarro.Image")));
            this.pictureBoxCarro.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCarro.InitialImage")));
            this.pictureBoxCarro.Location = new System.Drawing.Point(22, 21);
            this.pictureBoxCarro.Name = "pictureBoxCarro";
            this.pictureBoxCarro.Size = new System.Drawing.Size(374, 252);
            this.pictureBoxCarro.TabIndex = 0;
            this.pictureBoxCarro.TabStop = false;
            // 
            // btnAddCarros
            // 
            this.btnAddCarros.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddCarros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCarros.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCarros.Image")));
            this.btnAddCarros.ImageActive = null;
            this.btnAddCarros.Location = new System.Drawing.Point(151, 47);
            this.btnAddCarros.Name = "btnAddCarros";
            this.btnAddCarros.Size = new System.Drawing.Size(31, 33);
            this.btnAddCarros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddCarros.TabIndex = 28;
            this.btnAddCarros.TabStop = false;
            this.btnAddCarros.Zoom = 10;
            // 
            // btnEditCarros
            // 
            this.btnEditCarros.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEditCarros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCarros.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCarros.Image")));
            this.btnEditCarros.ImageActive = null;
            this.btnEditCarros.Location = new System.Drawing.Point(188, 47);
            this.btnEditCarros.Name = "btnEditCarros";
            this.btnEditCarros.Size = new System.Drawing.Size(31, 33);
            this.btnEditCarros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditCarros.TabIndex = 30;
            this.btnEditCarros.TabStop = false;
            this.btnEditCarros.Zoom = 10;
            // 
            // btnRemoveCarros
            // 
            this.btnRemoveCarros.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRemoveCarros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveCarros.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveCarros.Image")));
            this.btnRemoveCarros.ImageActive = null;
            this.btnRemoveCarros.Location = new System.Drawing.Point(225, 47);
            this.btnRemoveCarros.Name = "btnRemoveCarros";
            this.btnRemoveCarros.Size = new System.Drawing.Size(31, 33);
            this.btnRemoveCarros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRemoveCarros.TabIndex = 31;
            this.btnRemoveCarros.TabStop = false;
            this.btnRemoveCarros.Zoom = 10;
            // 
            // listboxCarros
            // 
            this.listboxCarros.bgColorHead = System.Drawing.Color.DarkSlateGray;
            this.listboxCarros.bgcolorList = System.Drawing.Color.LightCyan;
            this.listboxCarros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listboxCarros.Location = new System.Drawing.Point(30, 38);
            this.listboxCarros.Name = "listboxCarros";
            this.listboxCarros.Size = new System.Drawing.Size(237, 568);
            this.listboxCarros.TabIndex = 11;
            this.listboxCarros.titleColor = System.Drawing.Color.White;
            this.listboxCarros.titulo = "Carros para Alugar";
            // 
            // listboxClientes
            // 
            this.listboxClientes.bgColorHead = System.Drawing.Color.DarkSlateGray;
            this.listboxClientes.bgcolorList = System.Drawing.Color.LightCyan;
            this.listboxClientes.Location = new System.Drawing.Point(750, 38);
            this.listboxClientes.Name = "listboxClientes";
            this.listboxClientes.Size = new System.Drawing.Size(241, 568);
            this.listboxClientes.TabIndex = 10;
            this.listboxClientes.titleColor = System.Drawing.Color.White;
            this.listboxClientes.titulo = "Clientes";
            this.listboxClientes.Load += new System.EventHandler(this.listboxClientes_Load);
            // 
            // USaluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.btnRemoveCarros);
            this.Controls.Add(this.btnEditCarros);
            this.Controls.Add(this.btnAddCarros);
            this.Controls.Add(this.listboxCarros);
            this.Controls.Add(this.listboxClientes);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "USaluguer";
            this.Size = new System.Drawing.Size(1014, 621);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.panelPeças.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCarros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditCarros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveCarros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelKms;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Panel panelPeças;
        private System.Windows.Forms.Label labelMostraKms;
        private System.Windows.Forms.Label labelMostraEstado;
        private System.Windows.Forms.Label labelMostraValor;
        private System.Windows.Forms.Label labelMostraMarca;
        private System.Windows.Forms.Button buttonAlugar;
        private System.Windows.Forms.PictureBox pictureBoxCarro;
        private ListBoxPersonal listboxClientes;
        private ListBoxPersonal listboxCarros;
        private Bunifu.Framework.UI.BunifuImageButton btnAddCarros;
        private Bunifu.Framework.UI.BunifuImageButton btnEditCarros;
        private Bunifu.Framework.UI.BunifuImageButton btnRemoveCarros;
    }
}
