namespace StarStand
{
    partial class oficina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oficina));
            this.ButtonGerirSeviços = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.bunifuDropdown2 = new Bunifu.Framework.UI.BunifuDropdown();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // ButtonGerirSeviços
            // 
            this.ButtonGerirSeviços.ActiveBorderThickness = 1;
            this.ButtonGerirSeviços.ActiveCornerRadius = 20;
            this.ButtonGerirSeviços.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.ButtonGerirSeviços.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonGerirSeviços.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ButtonGerirSeviços.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonGerirSeviços.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonGerirSeviços.BackgroundImage")));
            this.ButtonGerirSeviços.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonGerirSeviços.ButtonText = "Gerir serviços";
            this.ButtonGerirSeviços.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGerirSeviços.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGerirSeviços.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonGerirSeviços.IdleBorderThickness = 1;
            this.ButtonGerirSeviços.IdleCornerRadius = 20;
            this.ButtonGerirSeviços.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonGerirSeviços.IdleForecolor = System.Drawing.Color.White;
            this.ButtonGerirSeviços.IdleLineColor = System.Drawing.Color.Chartreuse;
            this.ButtonGerirSeviços.Location = new System.Drawing.Point(821, 5);
            this.ButtonGerirSeviços.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonGerirSeviços.Name = "ButtonGerirSeviços";
            this.ButtonGerirSeviços.Size = new System.Drawing.Size(181, 41);
            this.ButtonGerirSeviços.TabIndex = 1;
            this.ButtonGerirSeviços.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(527, 54);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(217, 35);
            this.bunifuDropdown1.TabIndex = 2;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(358, 50);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(163, 355);
            this.listBox3.TabIndex = 5;
            // 
            // bunifuDropdown2
            // 
            this.bunifuDropdown2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown2.BorderRadius = 3;
            this.bunifuDropdown2.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown2.Items = new string[0];
            this.bunifuDropdown2.Location = new System.Drawing.Point(527, 111);
            this.bunifuDropdown2.Name = "bunifuDropdown2";
            this.bunifuDropdown2.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuDropdown2.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuDropdown2.selectedIndex = -1;
            this.bunifuDropdown2.Size = new System.Drawing.Size(217, 35);
            this.bunifuDropdown2.TabIndex = 6;
            this.bunifuDropdown2.onItemSelected += new System.EventHandler(this.BunifuDropdown2_onItemSelected);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(527, 219);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(217, 186);
            this.listBox4.TabIndex = 7;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(527, 152);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(217, 20);
            this.domainUpDown1.TabIndex = 8;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // oficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.bunifuDropdown2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.ButtonGerirSeviços);
            this.Name = "oficina";
            this.Size = new System.Drawing.Size(1007, 622);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 ButtonGerirSeviços;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private System.Windows.Forms.ListBox listBox3;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown2;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
    }
}
