using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmatPOS.Forms
{
    public partial class MainReportes: Form
    {
        public MainReportes()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainReportes_Load(object sender, EventArgs e)
        {
            SwitchLangouge langouge = new SwitchLangouge(declarations.Lang, typeof(MainForm));
            langouge.SetLangouge(this.Controls); 
            clsHelper.LoadPermissions(this.Controls, "MainReportes");
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            FormFilterDate frm = new FormFilterDate();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                clsPrintChecks checks = new clsPrintChecks();
                checks.PrintSaleReport(frm._From, frm._TO);
            }
        }

        private void btnDetailedsalesrpt_Click(object sender, EventArgs e)
        {
            FormFilterDate frm = new FormFilterDate();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                clsPrintChecks checks = new clsPrintChecks();
                checks.PrintDetailedSalesReport(frm._From, frm._TO);
            }
        }

        private void btnSalesbyCategories_Click(object sender, EventArgs e)
        {
            FormFilterDate frm = new FormFilterDate();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                clsPrintChecks checks = new clsPrintChecks();
                checks.PrintSalesByItemReport(frm._From, frm._TO,frm._catid);
            }
        }
    }
}
