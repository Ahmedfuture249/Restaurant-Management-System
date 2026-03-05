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
            clsHelper.LoadPermissions(this.Controls, ";MainReportes");
        }
    }
}
