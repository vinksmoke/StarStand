namespace StarStand
{
    partial class aluguer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aluguer));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panelPeças = new System.Windows.Forms.Panel();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelKms = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelMostraMarca = new System.Windows.Forms.Label();
            this.labelMostraValor = new System.Windows.Forms.Label();
            this.labelMostraEstado = new System.Windows.Forms.Label();
            this.labelMostraKms = new System.Windows.Forms.Label();
            this.pictureBoxCarro = new System.Windows.Forms.PictureBox();
            this.buttonAlugar = new System.Windows.Forms.Button();
            this.listBoxPersonal1 = new StarStand.ListBoxPersonal();
            this.listBoxPersonal2 = new StarStand.ListBoxPersonal();
            this.bunifuCards1.SuspendLayout();
            this.panelPeças.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarro)).BeginInit();
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
            this.bunifuCards1.Location = new System.Drawing.Point(303, 75);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(420, 469);
            this.bunifuCards1.TabIndex = 4;
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
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(13, 20);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 5;
            this.labelMarca.Text = "Marca:";
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
            // labelKms
            // 
            this.labelKms.AutoSize = true;
            this.labelKms.Location = new System.Drawing.Point(180, 64);
            this.labelKms.Name = "labelKms";
            this.labelKms.Size = new System.Drawing.Size(30, 13);
            this.labelKms.TabIndex = 37;
            this.labelKms.Text = "Kms:";
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
            // labelMostraMarca
            // 
            this.labelMostraMarca.AutoSize = true;
            this.labelMostraMarca.Location = new System.Drawing.Point(59, 20);
            this.labelMostraMarca.Name = "labelMostraMarca";
            this.labelMostraMarca.Size = new System.Drawing.Size(95, 13);
            this.labelMostraMarca.TabIndex = 0;
            this.labelMostraMarca.Text = "Nada Selecionado";
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
            // labelMostraEstado
            // 
            this.labelMostraEstado.AutoSize = true;
            this.labelMostraEstado.Location = new System.Drawing.Point(229, 20);
            this.labelMostraEstado.Name = "labelMostraEstado";
            this.labelMostraEstado.Size = new System.Drawing.Size(95, 13);
            this.labelMostraEstado.TabIndex = 40;
            this.labelMostraEstado.Text = "Nada Selecionado";
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
            // listBoxPersonal1
            // 
            this.listBoxPersonal1.bgColorHead = System.Drawing.Color.DarkSlateGray;
            this.listBoxPersonal1.bgcolorList = System.Drawing.Color.LightCyan;
            this.listBoxPersonal1.Location = new System.Drawing.Point(36, 40);
            this.listBoxPersonal1.Name = "listBoxPersonal1";
            this.listBoxPersonal1.Size = new System.Drawing.Size(223, 568);
            this.listBoxPersonal1.TabIndex = 10;
            this.listBoxPersonal1.titleColor = System.Drawing.Color.White;
            this.listBoxPersonal1.titulo = "Clientes";
            // 
            // listBoxPersonal2
            // 
            this.listBoxPersonal2.bgColorHead = System.Drawing.Color.DarkSlateGray;
            this.listBoxPersonal2.bgcolorList = System.Drawing.Color.LightCyan;
            this.listBoxPersonal2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBoxPersonal2.Location = new System.Drawing.Point(773, 40);
            this.listBoxPersonal2.Name = "listBoxPersonal2";
            this.listBoxPersonal2.Size = new System.Drawing.Size(223, 568);
            this.listBoxPersonal2.TabIndex = 11;
            this.listBoxPersonal2.titleColor = System.Drawing.Color.White;
            this.listBoxPersonal2.titulo = "Carros para Alugar";
            // 
            // aluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.listBoxPersonal2);
            this.Controls.Add(this.listBoxPersonal1);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "aluguer";
            this.Size = new System.Drawing.Size(1014, 621);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.panelPeças.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarro)).EndInit();
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
        private ListBoxPersonal listBoxPersonal1;
        private ListBoxPersonal listBoxPersonal2;
    }
}
