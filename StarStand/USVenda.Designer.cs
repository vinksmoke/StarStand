namespace StarStand
{
    partial class USvenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USvenda));
            this.btnDeleteVendas = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.labelMostrarlUtilizador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMostrarData = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.labelMostrarCombustivel = new System.Windows.Forms.Label();
            this.labelKms = new System.Windows.Forms.Label();
            this.labelMostrarModelo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMostraMarca = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelMostraMatricula = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.labelEstado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMostrarEstado = new System.Windows.Forms.Label();
            this.labelMostrarValor = new System.Windows.Forms.Label();
            this.panelPeças = new System.Windows.Forms.Panel();
            this.buttonVender = new System.Windows.Forms.Button();
            this.pictureBoxCarro = new System.Windows.Forms.PictureBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.listBoxHistVenda = new StarStand.ListBoxPersonal();
            this.btnFaturar = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteVendas)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelPeças.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFaturar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteVendas
            // 
            this.btnDeleteVendas.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeleteVendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteVendas.Image")));
            this.btnDeleteVendas.ImageActive = null;
            this.btnDeleteVendas.Location = new System.Drawing.Point(227, 18);
            this.btnDeleteVendas.Name = "btnDeleteVendas";
            this.btnDeleteVendas.Size = new System.Drawing.Size(31, 33);
            this.btnDeleteVendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeleteVendas.TabIndex = 52;
            this.btnDeleteVendas.TabStop = false;
            this.btnDeleteVendas.Zoom = 10;
            this.btnDeleteVendas.Click += new System.EventHandler(this.BtnDeleteVendas_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Maroon;
            this.bunifuCards1.Controls.Add(this.panel1);
            this.bunifuCards1.Controls.Add(this.panel2);
            this.bunifuCards1.Controls.Add(this.panelPeças);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(276, 57);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(625, 469);
            this.bunifuCards1.TabIndex = 53;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.labelMostrarlUtilizador);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelMostrarData);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.labelMostrarCombustivel);
            this.panel1.Controls.Add(this.labelKms);
            this.panel1.Controls.Add(this.labelMostrarModelo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelMostraMarca);
            this.panel1.Controls.Add(this.labelMarca);
            this.panel1.Controls.Add(this.labelValor);
            this.panel1.Controls.Add(this.labelMostraMatricula);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 121);
            this.panel1.TabIndex = 42;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(227, 89);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 13);
            this.label.TabIndex = 49;
            this.label.Text = "Utilizador:";
            // 
            // labelMostrarlUtilizador
            // 
            this.labelMostrarlUtilizador.AutoSize = true;
            this.labelMostrarlUtilizador.Location = new System.Drawing.Point(304, 89);
            this.labelMostrarlUtilizador.Name = "labelMostrarlUtilizador";
            this.labelMostrarlUtilizador.Size = new System.Drawing.Size(95, 13);
            this.labelMostrarlUtilizador.TabIndex = 50;
            this.labelMostrarlUtilizador.Text = "Nada Selecionado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Data:";
            // 
            // labelMostrarData
            // 
            this.labelMostrarData.AutoSize = true;
            this.labelMostrarData.Location = new System.Drawing.Point(78, 89);
            this.labelMostrarData.Name = "labelMostrarData";
            this.labelMostrarData.Size = new System.Drawing.Size(95, 13);
            this.labelMostrarData.TabIndex = 48;
            this.labelMostrarData.Text = "Nada Selecionado";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuSeparator1.LineThickness = 5;
            this.bunifuSeparator1.Location = new System.Drawing.Point(194, 3);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(27, 99);
            this.bunifuSeparator1.TabIndex = 46;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // labelMostrarCombustivel
            // 
            this.labelMostrarCombustivel.AutoSize = true;
            this.labelMostrarCombustivel.Location = new System.Drawing.Point(304, 54);
            this.labelMostrarCombustivel.Name = "labelMostrarCombustivel";
            this.labelMostrarCombustivel.Size = new System.Drawing.Size(95, 13);
            this.labelMostrarCombustivel.TabIndex = 45;
            this.labelMostrarCombustivel.Text = "Nada Selecionado";
            // 
            // labelKms
            // 
            this.labelKms.AutoSize = true;
            this.labelKms.Location = new System.Drawing.Point(227, 54);
            this.labelKms.Name = "labelKms";
            this.labelKms.Size = new System.Drawing.Size(64, 13);
            this.labelKms.TabIndex = 44;
            this.labelKms.Text = "Combustivel";
            // 
            // labelMostrarModelo
            // 
            this.labelMostrarModelo.AutoSize = true;
            this.labelMostrarModelo.Location = new System.Drawing.Point(304, 15);
            this.labelMostrarModelo.Name = "labelMostrarModelo";
            this.labelMostrarModelo.Size = new System.Drawing.Size(95, 13);
            this.labelMostrarModelo.TabIndex = 40;
            this.labelMostrarModelo.Text = "Nada Selecionado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Modelo:";
            // 
            // labelMostraMarca
            // 
            this.labelMostraMarca.AutoSize = true;
            this.labelMostraMarca.Location = new System.Drawing.Point(78, 15);
            this.labelMostraMarca.Name = "labelMostraMarca";
            this.labelMostraMarca.Size = new System.Drawing.Size(95, 13);
            this.labelMostraMarca.TabIndex = 0;
            this.labelMostraMarca.Text = "Nada Selecionado";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(19, 15);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 5;
            this.labelMarca.Text = "Marca:";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(19, 54);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(53, 13);
            this.labelValor.TabIndex = 36;
            this.labelValor.Text = "Matricula:";
            // 
            // labelMostraMatricula
            // 
            this.labelMostraMatricula.AutoSize = true;
            this.labelMostraMatricula.Location = new System.Drawing.Point(78, 54);
            this.labelMostraMatricula.Name = "labelMostraMatricula";
            this.labelMostraMatricula.Size = new System.Drawing.Size(95, 13);
            this.labelMostraMatricula.TabIndex = 39;
            this.labelMostraMatricula.Text = "Nada Selecionado";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.bunifuSeparator2);
            this.panel2.Controls.Add(this.labelEstado);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.labelMostrarEstado);
            this.panel2.Controls.Add(this.labelMostrarValor);
            this.panel2.Location = new System.Drawing.Point(434, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 121);
            this.panel2.TabIndex = 41;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuSeparator2.LineThickness = 5;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 3);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(27, 99);
            this.bunifuSeparator2.TabIndex = 47;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(145, 15);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(43, 13);
            this.labelEstado.TabIndex = 38;
            this.labelEstado.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Valor:";
            // 
            // labelMostrarEstado
            // 
            this.labelMostrarEstado.AutoSize = true;
            this.labelMostrarEstado.Location = new System.Drawing.Point(44, 15);
            this.labelMostrarEstado.Name = "labelMostrarEstado";
            this.labelMostrarEstado.Size = new System.Drawing.Size(95, 13);
            this.labelMostrarEstado.TabIndex = 42;
            this.labelMostrarEstado.Text = "Nada Selecionado";
            // 
            // labelMostrarValor
            // 
            this.labelMostrarValor.AutoSize = true;
            this.labelMostrarValor.Location = new System.Drawing.Point(44, 54);
            this.labelMostrarValor.Name = "labelMostrarValor";
            this.labelMostrarValor.Size = new System.Drawing.Size(95, 13);
            this.labelMostrarValor.TabIndex = 43;
            this.labelMostrarValor.Text = "Nada Selecionado";
            // 
            // panelPeças
            // 
            this.panelPeças.Controls.Add(this.buttonVender);
            this.panelPeças.Controls.Add(this.pictureBoxCarro);
            this.panelPeças.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPeças.Location = new System.Drawing.Point(0, 121);
            this.panelPeças.Name = "panelPeças";
            this.panelPeças.Size = new System.Drawing.Size(625, 348);
            this.panelPeças.TabIndex = 35;
            // 
            // buttonVender
            // 
            this.buttonVender.BackColor = System.Drawing.Color.Maroon;
            this.buttonVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVender.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonVender.Location = new System.Drawing.Point(274, 289);
            this.buttonVender.Name = "buttonVender";
            this.buttonVender.Size = new System.Drawing.Size(125, 39);
            this.buttonVender.TabIndex = 1;
            this.buttonVender.Text = "Vender";
            this.buttonVender.UseVisualStyleBackColor = false;
            this.buttonVender.Click += new System.EventHandler(this.ButtonVender_Click);
            // 
            // pictureBoxCarro
            // 
            this.pictureBoxCarro.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCarro.ErrorImage")));
            this.pictureBoxCarro.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCarro.Image")));
            this.pictureBoxCarro.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCarro.InitialImage")));
            this.pictureBoxCarro.Location = new System.Drawing.Point(22, 21);
            this.pictureBoxCarro.Name = "pictureBoxCarro";
            this.pictureBoxCarro.Size = new System.Drawing.Size(590, 252);
            this.pictureBoxCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCarro.TabIndex = 0;
            this.pictureBoxCarro.TabStop = false;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Maroon;
            this.labelTitulo.Location = new System.Drawing.Point(512, 10);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(144, 42);
            this.labelTitulo.TabIndex = 52;
            this.labelTitulo.Text = "VENDA";
            // 
            // listBoxHistVenda
            // 
            this.listBoxHistVenda.bgColorHead = System.Drawing.Color.DarkSlateGray;
            this.listBoxHistVenda.bgcolorList = System.Drawing.Color.LightCyan;
            this.listBoxHistVenda.Location = new System.Drawing.Point(29, 10);
            this.listBoxHistVenda.Name = "listBoxHistVenda";
            this.listBoxHistVenda.Size = new System.Drawing.Size(241, 568);
            this.listBoxHistVenda.TabIndex = 51;
            this.listBoxHistVenda.titleColor = System.Drawing.Color.White;
            this.listBoxHistVenda.titulo = "Historico de vendas";
            this.listBoxHistVenda.ChangeSeletedIndex += new System.EventHandler(this.ListBoxHistVenda_ChangeSeletedIndex);
            // 
            // btnFaturar
            // 
            this.btnFaturar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnFaturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaturar.Image = ((System.Drawing.Image)(resources.GetObject("btnFaturar.Image")));
            this.btnFaturar.ImageActive = null;
            this.btnFaturar.Location = new System.Drawing.Point(188, 18);
            this.btnFaturar.Name = "btnFaturar";
            this.btnFaturar.Size = new System.Drawing.Size(33, 34);
            this.btnFaturar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFaturar.TabIndex = 54;
            this.btnFaturar.TabStop = false;
            this.btnFaturar.Zoom = 10;
            this.btnFaturar.Click += new System.EventHandler(this.BtnFaturar_Click);
            // 
            // USvenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFaturar);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.btnDeleteVendas);
            this.Controls.Add(this.listBoxHistVenda);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "USvenda";
            this.Size = new System.Drawing.Size(956, 598);
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteVendas)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelPeças.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFaturar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnDeleteVendas;
        private ListBoxPersonal listBoxHistVenda;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label labelMostrarCombustivel;
        private System.Windows.Forms.Label labelKms;
        private System.Windows.Forms.Label labelMostrarModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMostraMarca;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelMostraMatricula;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMostrarEstado;
        private System.Windows.Forms.Label labelMostrarValor;
        private System.Windows.Forms.Panel panelPeças;
        private System.Windows.Forms.Button buttonVender;
        private System.Windows.Forms.PictureBox pictureBoxCarro;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelMostrarlUtilizador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMostrarData;
        private Bunifu.Framework.UI.BunifuImageButton btnFaturar;
    }
}
