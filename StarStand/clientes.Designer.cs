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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelClientes = new System.Windows.Forms.Label();
            this.panelRightClientes = new System.Windows.Forms.Panel();
            this.btnRemoveClientes = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEditClientes = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddClientes = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgv_Clientes = new System.Windows.Forms.DataGridView();
            this.idUtilizadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telemovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilizadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelRightClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadoresBindingSource)).BeginInit();
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
            this.btnRemoveClientes.Click += new System.EventHandler(this.btnRemoveClientes_Click);
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
            this.btnEditClientes.Click += new System.EventHandler(this.btnEditClientes_Click);
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
            this.btnAddClientes.Click += new System.EventHandler(this.btnAddClientes_Click);
            // 
            // dgv_Clientes
            // 
            this.dgv_Clientes.AutoGenerateColumns = false;
            this.dgv_Clientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUtilizadorDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.nIFDataGridViewTextBoxColumn,
            this.moradaDataGridViewTextBoxColumn,
            this.telemovelDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgv_Clientes.DataSource = this.utilizadoresBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Clientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Clientes.EnableHeadersVisualStyles = false;
            this.dgv_Clientes.Location = new System.Drawing.Point(53, 71);
            this.dgv_Clientes.Name = "dgv_Clientes";
            this.dgv_Clientes.RowHeadersVisible = false;
            this.dgv_Clientes.Size = new System.Drawing.Size(603, 499);
            this.dgv_Clientes.TabIndex = 32;
            // 
            // idUtilizadorDataGridViewTextBoxColumn
            // 
            this.idUtilizadorDataGridViewTextBoxColumn.DataPropertyName = "IdUtilizador";
            this.idUtilizadorDataGridViewTextBoxColumn.HeaderText = "IdUtilizador";
            this.idUtilizadorDataGridViewTextBoxColumn.Name = "idUtilizadorDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // nIFDataGridViewTextBoxColumn
            // 
            this.nIFDataGridViewTextBoxColumn.DataPropertyName = "NIF";
            this.nIFDataGridViewTextBoxColumn.HeaderText = "NIF";
            this.nIFDataGridViewTextBoxColumn.Name = "nIFDataGridViewTextBoxColumn";
            // 
            // moradaDataGridViewTextBoxColumn
            // 
            this.moradaDataGridViewTextBoxColumn.DataPropertyName = "Morada";
            this.moradaDataGridViewTextBoxColumn.HeaderText = "Morada";
            this.moradaDataGridViewTextBoxColumn.Name = "moradaDataGridViewTextBoxColumn";
            // 
            // telemovelDataGridViewTextBoxColumn
            // 
            this.telemovelDataGridViewTextBoxColumn.DataPropertyName = "Telemovel";
            this.telemovelDataGridViewTextBoxColumn.HeaderText = "Telemovel";
            this.telemovelDataGridViewTextBoxColumn.Name = "telemovelDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // utilizadoresBindingSource
            // 
            this.utilizadoresBindingSource.DataSource = typeof(StarStand.Utilizadores);
            // 
            // clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.dgv_Clientes);
            this.Controls.Add(this.panelRightClientes);
            this.Controls.Add(this.labelClientes);
            this.Name = "clientes";
            this.Size = new System.Drawing.Size(1014, 621);
            this.panelRightClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClientes;
        private System.Windows.Forms.Panel panelRightClientes;
        private Bunifu.Framework.UI.BunifuImageButton btnAddClientes;
        private Bunifu.Framework.UI.BunifuImageButton btnEditClientes;
        private Bunifu.Framework.UI.BunifuImageButton btnRemoveClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtilizadoresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource utilizadoresBindingSource;
        private System.Windows.Forms.DataGridView dgv_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtilizadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telemovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}
