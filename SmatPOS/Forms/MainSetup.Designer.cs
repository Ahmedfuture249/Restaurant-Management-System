namespace SmatPOS.Forms
{
    partial class MainSetup
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
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::SmatPOS.Properties.Resources.log_out;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(705, 433);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 99);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.Image = global::SmatPOS.Properties.Resources.maintenance;
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCategories.Location = new System.Drawing.Point(25, 131);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(179, 115);
            this.btnCategories.TabIndex = 4;
            this.btnCategories.Text = "Categories";
            this.btnCategories.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategories.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Image = global::SmatPOS.Properties.Resources.man;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsers.Location = new System.Drawing.Point(25, 10);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(179, 115);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.Image = global::SmatPOS.Properties.Resources.online_payment;
            this.btnPayments.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPayments.Location = new System.Drawing.Point(25, 261);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(179, 115);
            this.btnPayments.TabIndex = 2;
            this.btnPayments.Text = "Payments ";
            this.btnPayments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPayments.UseVisualStyleBackColor = true;
            // 
            // btnItems
            // 
            this.btnItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.Image = global::SmatPOS.Properties.Resources.food_delivery;
            this.btnItems.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnItems.Location = new System.Drawing.Point(25, 397);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(179, 115);
            this.btnItems.TabIndex = 1;
            this.btnItems.Text = "Items";
            this.btnItems.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnItems.UseVisualStyleBackColor = true;
            // 
            // MainSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.btnItems);
            this.Name = "MainSetup";
            this.Text = "MainSetup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnExit;
    }
}