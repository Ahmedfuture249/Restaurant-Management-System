namespace SmatPOS.Forms
{
    partial class FormSelect
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
            this.lblDes = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDes
            // 
            this.lblDes.AccessibleName = "Description";
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(22, 21);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(75, 16);
            this.lblDes.TabIndex = 0;
            this.lblDes.Text = "Description";
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(103, 18);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(246, 22);
            this.txtDes.TabIndex = 1;
            this.txtDes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDes_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColDes});
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(378, 396);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.MinimumWidth = 6;
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 125;
            // 
            // ColDes
            // 
            this.ColDes.FillWeight = 200F;
            this.ColDes.HeaderText = "Description";
            this.ColDes.MinimumWidth = 6;
            this.ColDes.Name = "ColDes";
            this.ColDes.ReadOnly = true;
            this.ColDes.Width = 200;
            // 
            // FormSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 459);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.lblDes);
            this.Name = "FormSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSelect";
            this.Load += new System.EventHandler(this.FormSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDes;
    }
}