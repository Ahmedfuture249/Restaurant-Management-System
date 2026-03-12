namespace SmatPOS.Forms
{
    partial class MainReportes
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnDetailedsalesrpt = new System.Windows.Forms.Button();
            this.btnSalesbyCategories = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::SmatPOS.Properties.Resources.log_out;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(705, 339);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 99);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnItems
            // 
            this.btnItems.AccessibleName = "SaleReport";
            this.btnItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.Image = global::SmatPOS.Properties.Resources.business_report;
            this.btnItems.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnItems.Location = new System.Drawing.Point(12, 12);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(168, 115);
            this.btnItems.TabIndex = 2;
            this.btnItems.Text = "Sale";
            this.btnItems.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnDetailedsalesrpt
            // 
            this.btnDetailedsalesrpt.AccessibleName = "Detailedsalesrpt";
            this.btnDetailedsalesrpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailedsalesrpt.Image = global::SmatPOS.Properties.Resources.business_report;
            this.btnDetailedsalesrpt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDetailedsalesrpt.Location = new System.Drawing.Point(208, 12);
            this.btnDetailedsalesrpt.Name = "btnDetailedsalesrpt";
            this.btnDetailedsalesrpt.Size = new System.Drawing.Size(168, 115);
            this.btnDetailedsalesrpt.TabIndex = 7;
            this.btnDetailedsalesrpt.Text = "Detailed Sales Report";
            this.btnDetailedsalesrpt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDetailedsalesrpt.UseVisualStyleBackColor = true;
            this.btnDetailedsalesrpt.Click += new System.EventHandler(this.btnDetailedsalesrpt_Click);
            // 
            // btnSalesbyCategories
            // 
            this.btnSalesbyCategories.AccessibleName = "SalesbyCategories";
            this.btnSalesbyCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesbyCategories.Image = global::SmatPOS.Properties.Resources.business_report;
            this.btnSalesbyCategories.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalesbyCategories.Location = new System.Drawing.Point(410, 12);
            this.btnSalesbyCategories.Name = "btnSalesbyCategories";
            this.btnSalesbyCategories.Size = new System.Drawing.Size(168, 115);
            this.btnSalesbyCategories.TabIndex = 8;
            this.btnSalesbyCategories.Text = "Sales by Categories";
            this.btnSalesbyCategories.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalesbyCategories.UseVisualStyleBackColor = true;
            this.btnSalesbyCategories.Click += new System.EventHandler(this.btnSalesbyCategories_Click);
            // 
            // MainReportes
            // 
            this.AccessibleName = "Reports";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalesbyCategories);
            this.Controls.Add(this.btnDetailedsalesrpt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnItems);
            this.Name = "MainReportes";
            this.Text = "MainReportes";
            this.Load += new System.EventHandler(this.MainReportes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDetailedsalesrpt;
        private System.Windows.Forms.Button btnSalesbyCategories;
    }
}