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
    public partial class FormPermissions: Form
    {
        public FormPermissions()
        {
            InitializeComponent();
        }

        private void FormPermissions_Load(object sender, EventArgs e)
        {
            clsHelper.fillComboBox(comboBoxUsers, "SELECT * FROM USERS");
        }

        private void toolStripBtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void CheckAll(Control.ControlCollection controls,bool status)
        {
            foreach(Control control in controls)
            {
               if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = status;
                }
               if(control.Controls.Count > 0)   
                {
                    CheckAll(control.Controls, status);
                }   
            }
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            CheckAll(this.Controls, true);
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            CheckAll(this.Controls, false);
        }
    }
}
