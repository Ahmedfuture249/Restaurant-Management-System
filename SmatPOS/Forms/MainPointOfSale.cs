using SmatPOS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmatPOS
{
    public partial class MainPointOfSale: Form
    {
        public MainPointOfSale()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            POSForm frm= new POSForm();
            frm.ShowDialog();
        }

        private void MainPointOfSale_Load(object sender, EventArgs e)
        {
            SwitchLangouge langouge = new SwitchLangouge(declarations.Lang, typeof(MainForm));
            langouge.SetLangouge(this.Controls);

        }
    }
}
