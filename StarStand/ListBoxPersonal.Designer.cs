namespace StarStand
{
    partial class ListBoxPersonal
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelHead = new System.Windows.Forms.Panel();
            this.lblSetText = new System.Windows.Forms.Label();
            this.panelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Items.AddRange(new object[] {
            ",lçknlagnvºaf",
            "´çakdnbanfºba",
            "ãdsf",
            "agçalfkhna",
            "asd",
            "asdf",
            "asdf",
            "bmçkafdnba",
            "bmçkdanç",
            "gaçdfhna",
            "mçahnçafdn",
            "opa",
            "res",
            "sagerhadçhfogn"});
            this.listBox1.Location = new System.Drawing.Point(0, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 216);
            this.listBox1.TabIndex = 0;
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.lblSetText);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(201, 50);
            this.panelHead.TabIndex = 1;
            // 
            // lblSetText
            // 
            this.lblSetText.AutoSize = true;
            this.lblSetText.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetText.Location = new System.Drawing.Point(23, 15);
            this.lblSetText.Name = "lblSetText";
            this.lblSetText.Size = new System.Drawing.Size(82, 21);
            this.lblSetText.TabIndex = 0;
            this.lblSetText.Text = "Set Text";
            // 
            // ListBoxPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panelHead);
            this.Name = "ListBoxPersonal";
            this.Size = new System.Drawing.Size(201, 266);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label lblSetText;
    }
}
