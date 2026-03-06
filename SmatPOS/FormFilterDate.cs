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
    public partial class FormFilterDate: Form
    {
        public FormFilterDate()
        {
            InitializeComponent();
        }
        public DateTime _From { get =>dtpFrom.Value; }
        public DateTime _TO { get => dtpTo.Value; }
        public string _catid
        {
            get
            {
                if (comboBoxCategories.Text != "")
                {
                    return ((comboItem)comboBoxCategories.SelectedItem).Id;
                }
                else
                {
                    return "0";
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            Close();
        }

        private void FormFilterDate_Load(object sender, EventArgs e)
        {
           dtpFrom.Value= DateTime.Now;
            dtpTo.Value= DateTime.Now;
            clsHelper.fillComboBox(comboBoxCategories, "Select ID,Description from categories");
        }
    }
}
