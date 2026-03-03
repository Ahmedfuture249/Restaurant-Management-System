namespace SmatPOS.Forms
{
    partial class FormPermissions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPermissions));
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnSve = new System.Windows.Forms.ToolStripButton();
            this.btnCheckAll = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnExit = new System.Windows.Forms.ToolStripButton();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkboxSetup = new System.Windows.Forms.CheckBox();
            this.checkBoxReports = new System.Windows.Forms.CheckBox();
            this.checkBoxOptions = new System.Windows.Forms.CheckBox();
            this.checkBoxPointOfSale = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxTaples = new System.Windows.Forms.CheckBox();
            this.checkBoxUserPermissions = new System.Windows.Forms.CheckBox();
            this.checkBoxItems = new System.Windows.Forms.CheckBox();
            this.checkBoxPayments = new System.Windows.Forms.CheckBox();
            this.checkBoxUsers = new System.Windows.Forms.CheckBox();
            this.checkBoxCategories = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBoxSalesReport = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkBoxSave = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 73);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 73);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 73);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(46, 46);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripBtnSve,
            this.btnCheckAll,
            this.btnRemoveAll,
            this.toolStripSeparator2,
            this.toolStripBtnExit,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(855, 73);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "Point of sale";
            // 
            // toolStripBtnSve
            // 
            this.toolStripBtnSve.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSve.Image")));
            this.toolStripBtnSve.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSve.Name = "toolStripBtnSve";
            this.toolStripBtnSve.Size = new System.Drawing.Size(50, 70);
            this.toolStripBtnSve.Text = "Save";
            this.toolStripBtnSve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnSve.Click += new System.EventHandler(this.toolStripBtnSve_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckAll.Image")));
            this.btnCheckAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(72, 70);
            this.btnCheckAll.Text = "check All";
            this.btnCheckAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveAll.Image")));
            this.btnRemoveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(89, 70);
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // toolStripBtnExit
            // 
            this.toolStripBtnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnExit.Image")));
            this.toolStripBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnExit.Name = "toolStripBtnExit";
            this.toolStripBtnExit.Size = new System.Drawing.Size(50, 70);
            this.toolStripBtnExit.Text = "Exit";
            this.toolStripBtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnExit.Click += new System.EventHandler(this.toolStripBtnExit_Click);
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(121, 95);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(211, 30);
            this.comboBoxUsers.TabIndex = 2;
            this.comboBoxUsers.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Users";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.checkboxSetup);
            this.panel1.Controls.Add(this.checkBoxReports);
            this.panel1.Controls.Add(this.checkBoxOptions);
            this.panel1.Controls.Add(this.checkBoxPointOfSale);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(12, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 326);
            this.panel1.TabIndex = 4;
            // 
            // checkboxSetup
            // 
            this.checkboxSetup.AccessibleDescription = "Main";
            this.checkboxSetup.AccessibleName = "SetUp";
            this.checkboxSetup.AutoSize = true;
            this.checkboxSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxSetup.Location = new System.Drawing.Point(157, 15);
            this.checkboxSetup.Name = "checkboxSetup";
            this.checkboxSetup.Size = new System.Drawing.Size(82, 24);
            this.checkboxSetup.TabIndex = 9;
            this.checkboxSetup.Text = "Set Up";
            this.checkboxSetup.UseVisualStyleBackColor = true;
            // 
            // checkBoxReports
            // 
            this.checkBoxReports.AccessibleDescription = "Main";
            this.checkBoxReports.AccessibleName = "Reports";
            this.checkBoxReports.AutoSize = true;
            this.checkBoxReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxReports.Location = new System.Drawing.Point(309, 15);
            this.checkBoxReports.Name = "checkBoxReports";
            this.checkBoxReports.Size = new System.Drawing.Size(90, 24);
            this.checkBoxReports.TabIndex = 8;
            this.checkBoxReports.Text = "Reports";
            this.checkBoxReports.UseVisualStyleBackColor = true;
            // 
            // checkBoxOptions
            // 
            this.checkBoxOptions.AccessibleDescription = "Main";
            this.checkBoxOptions.AccessibleName = "Options";
            this.checkBoxOptions.AutoSize = true;
            this.checkBoxOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOptions.Location = new System.Drawing.Point(445, 15);
            this.checkBoxOptions.Name = "checkBoxOptions";
            this.checkBoxOptions.Size = new System.Drawing.Size(89, 24);
            this.checkBoxOptions.TabIndex = 7;
            this.checkBoxOptions.Text = "Options";
            this.checkBoxOptions.UseVisualStyleBackColor = true;
            // 
            // checkBoxPointOfSale
            // 
            this.checkBoxPointOfSale.AccessibleDescription = "Main";
            this.checkBoxPointOfSale.AccessibleName = "PointOfSale";
            this.checkBoxPointOfSale.AutoSize = true;
            this.checkBoxPointOfSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPointOfSale.Location = new System.Drawing.Point(7, 15);
            this.checkBoxPointOfSale.Name = "checkBoxPointOfSale";
            this.checkBoxPointOfSale.Size = new System.Drawing.Size(130, 24);
            this.checkBoxPointOfSale.TabIndex = 6;
            this.checkBoxPointOfSale.Text = "Point Of Sale";
            this.checkBoxPointOfSale.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(822, 274);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.checkBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(814, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "point Of Sale";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AccessibleDescription = "PointOfSale";
            this.checkBox1.AccessibleName = "TablesVeiw";
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(6, 77);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 24);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Tables View";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AccessibleDescription = "PointOfSale";
            this.checkBox2.AccessibleName = "POSChecks";
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(6, 17);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(187, 24);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Point of Sale Checks";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AccessibleDescription = "PointOfSale";
            this.checkBox3.AccessibleName = "OpenChecks";
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(6, 47);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(132, 24);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Open Checks";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxTaples);
            this.tabPage2.Controls.Add(this.checkBoxUserPermissions);
            this.tabPage2.Controls.Add(this.checkBoxItems);
            this.tabPage2.Controls.Add(this.checkBoxPayments);
            this.tabPage2.Controls.Add(this.checkBoxUsers);
            this.tabPage2.Controls.Add(this.checkBoxCategories);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(814, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Set Up";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxTaples
            // 
            this.checkBoxTaples.AccessibleDescription = "SetUp";
            this.checkBoxTaples.AccessibleName = "Taples";
            this.checkBoxTaples.AutoSize = true;
            this.checkBoxTaples.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTaples.Location = new System.Drawing.Point(21, 121);
            this.checkBoxTaples.Name = "checkBoxTaples";
            this.checkBoxTaples.Size = new System.Drawing.Size(81, 24);
            this.checkBoxTaples.TabIndex = 16;
            this.checkBoxTaples.Text = "Taples";
            this.checkBoxTaples.UseVisualStyleBackColor = true;
            // 
            // checkBoxUserPermissions
            // 
            this.checkBoxUserPermissions.AccessibleDescription = "SetUp";
            this.checkBoxUserPermissions.AccessibleName = "UserPermissions";
            this.checkBoxUserPermissions.AutoSize = true;
            this.checkBoxUserPermissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUserPermissions.Location = new System.Drawing.Point(192, 20);
            this.checkBoxUserPermissions.Name = "checkBoxUserPermissions";
            this.checkBoxUserPermissions.Size = new System.Drawing.Size(174, 24);
            this.checkBoxUserPermissions.TabIndex = 15;
            this.checkBoxUserPermissions.Text = "Users Permissions";
            this.checkBoxUserPermissions.UseVisualStyleBackColor = true;
            // 
            // checkBoxItems
            // 
            this.checkBoxItems.AccessibleDescription = "SetUp";
            this.checkBoxItems.AccessibleName = "Items";
            this.checkBoxItems.AutoSize = true;
            this.checkBoxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxItems.Location = new System.Drawing.Point(192, 50);
            this.checkBoxItems.Name = "checkBoxItems";
            this.checkBoxItems.Size = new System.Drawing.Size(72, 24);
            this.checkBoxItems.TabIndex = 14;
            this.checkBoxItems.Text = "Items";
            this.checkBoxItems.UseVisualStyleBackColor = true;
            // 
            // checkBoxPayments
            // 
            this.checkBoxPayments.AccessibleDescription = "SetUp";
            this.checkBoxPayments.AccessibleName = "Payments";
            this.checkBoxPayments.AutoSize = true;
            this.checkBoxPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPayments.Location = new System.Drawing.Point(21, 80);
            this.checkBoxPayments.Name = "checkBoxPayments";
            this.checkBoxPayments.Size = new System.Drawing.Size(105, 24);
            this.checkBoxPayments.TabIndex = 12;
            this.checkBoxPayments.Text = "Payments";
            this.checkBoxPayments.UseVisualStyleBackColor = true;
            // 
            // checkBoxUsers
            // 
            this.checkBoxUsers.AccessibleDescription = "SetUp";
            this.checkBoxUsers.AccessibleName = "Users";
            this.checkBoxUsers.AutoSize = true;
            this.checkBoxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUsers.Location = new System.Drawing.Point(21, 20);
            this.checkBoxUsers.Name = "checkBoxUsers";
            this.checkBoxUsers.Size = new System.Drawing.Size(76, 24);
            this.checkBoxUsers.TabIndex = 11;
            this.checkBoxUsers.Text = "Users";
            this.checkBoxUsers.UseVisualStyleBackColor = true;
            // 
            // checkBoxCategories
            // 
            this.checkBoxCategories.AccessibleDescription = "SetUp";
            this.checkBoxCategories.AccessibleName = "Categories";
            this.checkBoxCategories.AutoSize = true;
            this.checkBoxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCategories.Location = new System.Drawing.Point(21, 50);
            this.checkBoxCategories.Name = "checkBoxCategories";
            this.checkBoxCategories.Size = new System.Drawing.Size(112, 24);
            this.checkBoxCategories.TabIndex = 10;
            this.checkBoxCategories.Text = "Categories";
            this.checkBoxCategories.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBoxSalesReport);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(814, 245);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reports";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBoxSalesReport
            // 
            this.checkBoxSalesReport.AccessibleDescription = "Reports";
            this.checkBoxSalesReport.AccessibleName = "SalesReport";
            this.checkBoxSalesReport.AutoSize = true;
            this.checkBoxSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSalesReport.Location = new System.Drawing.Point(21, 23);
            this.checkBoxSalesReport.Name = "checkBoxSalesReport";
            this.checkBoxSalesReport.Size = new System.Drawing.Size(131, 24);
            this.checkBoxSalesReport.TabIndex = 16;
            this.checkBoxSalesReport.Text = "Sales Repote";
            this.checkBoxSalesReport.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkBoxSave);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(814, 245);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Options";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkBoxSave
            // 
            this.checkBoxSave.AccessibleDescription = "Options";
            this.checkBoxSave.AccessibleName = "Save";
            this.checkBoxSave.AutoSize = true;
            this.checkBoxSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSave.Location = new System.Drawing.Point(6, 28);
            this.checkBoxSave.Name = "checkBoxSave";
            this.checkBoxSave.Size = new System.Drawing.Size(66, 24);
            this.checkBoxSave.TabIndex = 8;
            this.checkBoxSave.Text = "save";
            this.checkBoxSave.UseVisualStyleBackColor = true;
            // 
            // FormPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPermissions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPermissions";
            this.Load += new System.EventHandler(this.FormPermissions_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtnSve;
        private System.Windows.Forms.ToolStripButton btnCheckAll;
        private System.Windows.Forms.ToolStripButton btnRemoveAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBtnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxPointOfSale;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkboxSetup;
        private System.Windows.Forms.CheckBox checkBoxReports;
        private System.Windows.Forms.CheckBox checkBoxOptions;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox checkBoxSave;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBoxPayments;
        private System.Windows.Forms.CheckBox checkBoxUsers;
        private System.Windows.Forms.CheckBox checkBoxCategories;
        private System.Windows.Forms.CheckBox checkBoxTaples;
        private System.Windows.Forms.CheckBox checkBoxUserPermissions;
        private System.Windows.Forms.CheckBox checkBoxItems;
        private System.Windows.Forms.CheckBox checkBoxSalesReport;
    }
}