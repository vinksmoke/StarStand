namespace StarStand
{
    partial class UpDown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpDown));
            this.btnUp = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDown = new Bunifu.Framework.UI.BunifuImageButton();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUp
            // 
            this.btnUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUp.BackColor = System.Drawing.Color.White;
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.ImageActive = null;
            this.btnUp.Location = new System.Drawing.Point(235, 0);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(49, 48);
            this.btnUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUp.TabIndex = 0;
            this.btnUp.TabStop = false;
            this.btnUp.Zoom = 10;
            // 
            // btnDown
            // 
            this.btnDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDown.BackColor = System.Drawing.Color.White;
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.ImageActive = null;
            this.btnDown.Location = new System.Drawing.Point(235, 49);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(49, 51);
            this.btnDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDown.TabIndex = 2;
            this.btnDown.TabStop = false;
            this.btnDown.Zoom = 10;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(3, 3);
            this.textBoxValue.Multiline = true;
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(226, 94);
            this.textBoxValue.TabIndex = 3;
            this.textBoxValue.Leave += new System.EventHandler(this.TextBoxValue_Leave);
            // 
            // UpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Name = "UpDown";
            this.Size = new System.Drawing.Size(284, 100);
            ((System.ComponentModel.ISupportInitialize)(this.btnUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnUp;
        private Bunifu.Framework.UI.BunifuImageButton btnDown;
        private System.Windows.Forms.TextBox textBoxValue;
    }
}
