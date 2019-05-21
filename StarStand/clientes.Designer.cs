namespace StarStand
{
    partial class clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientes));
            this.labelClientes = new System.Windows.Forms.Label();
            this.panelRightClientes = new System.Windows.Forms.Panel();
            this.btnRemoveClientes = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEditClientes = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddClientes = new Bunifu.Framework.UI.BunifuImageButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelRightClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClientes
            // 
            this.labelClientes.AutoSize = true;
            this.labelClientes.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientes.ForeColor = System.Drawing.Color.Maroon;
            this.labelClientes.Location = new System.Drawing.Point(3, 11);
            this.labelClientes.Name = "labelClientes";
            this.labelClientes.Size = new System.Drawing.Size(184, 42);
            this.labelClientes.TabIndex = 0;
            this.labelClientes.Text = "CLIENTES";
            // 
            // panelRightClientes
            // 
            this.panelRightClientes.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelRightClientes.Controls.Add(this.btnRemoveClientes);
            this.panelRightClientes.Controls.Add(this.btnEditClientes);
            this.panelRightClientes.Controls.Add(this.btnAddClientes);
            this.panelRightClientes.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightClientes.Location = new System.Drawing.Point(708, 0);
            this.panelRightClientes.Name = "panelRightClientes";
            this.panelRightClientes.Size = new System.Drawing.Size(306, 621);
            this.panelRightClientes.TabIndex = 1;
            // 
            // btnRemoveClientes
            // 
            this.btnRemoveClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveClientes.Image")));
            this.btnRemoveClientes.ImageActive = null;
            this.btnRemoveClientes.Location = new System.Drawing.Point(116, 375);
            this.btnRemoveClientes.Name = "btnRemoveClientes";
            this.btnRemoveClientes.Size = new System.Drawing.Size(73, 73);
            this.btnRemoveClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRemoveClientes.TabIndex = 31;
            this.btnRemoveClientes.TabStop = false;
            this.btnRemoveClientes.Zoom = 10;
            // 
            // btnEditClientes
            // 
            this.btnEditClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnEditClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnEditClientes.Image")));
            this.btnEditClientes.ImageActive = null;
            this.btnEditClientes.Location = new System.Drawing.Point(116, 259);
            this.btnEditClientes.Name = "btnEditClientes";
            this.btnEditClientes.Size = new System.Drawing.Size(73, 73);
            this.btnEditClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditClientes.TabIndex = 30;
            this.btnEditClientes.TabStop = false;
            this.btnEditClientes.Zoom = 10;
            // 
            // btnAddClientes
            // 
            this.btnAddClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnAddClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnAddClientes.Image")));
            this.btnAddClientes.ImageActive = null;
            this.btnAddClientes.Location = new System.Drawing.Point(116, 154);
            this.btnAddClientes.Name = "btnAddClientes";
            this.btnAddClientes.Size = new System.Drawing.Size(73, 73);
            this.btnAddClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddClientes.TabIndex = 28;
            this.btnAddClientes.TabStop = false;
            this.btnAddClientes.Zoom = 10;
            this.btnAddClientes.Click += new System.EventHandler(this.BtnAddClientes_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(600, 499);
            this.dataGridView1.TabIndex = 2;
            // 
            // clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelRightClientes);
            this.Controls.Add(this.labelClientes);
            this.Name = "clientes";
            this.Size = new System.Drawing.Size(1014, 621);
            this.panelRightClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClientes;
        private System.Windows.Forms.Panel panelRightClientes;
        private Bunifu.Framework.UI.BunifuImageButton btnAddClientes;
        private Bunifu.Framework.UI.BunifuImageButton btnEditClientes;
        private Bunifu.Framework.UI.BunifuImageButton btnRemoveClientes;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
