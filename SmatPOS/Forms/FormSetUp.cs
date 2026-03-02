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
    public partial class FormSatrtUp: Form
    {
        public FormSatrtUp()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblinfo.Text = "Loading System Options... ";
            if(progressBar1.Value==30)
            {
                clsLoading loading = new clsLoading();
                loading.LoadSystemOptoions();
            }
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                this.DialogResult = DialogResult.OK;
                Close();
                return;
            }
            progressBar1.Value += 5;
            progressBar1.Refresh();
        }

        private void FormSetUp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
