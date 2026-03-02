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
    public partial class MainSetup: Form
    {
        public MainSetup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormUsers form= new FormUsers();    
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FormCategories form= new FormCategories();  
            form.ShowDialog();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            FormItems formItems= new FormItems();   
            formItems.ShowDialog();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            FormPayments form= new FormPayments();
            form.ShowDialog();

        }

        private void btnPermissions_Click(object sender, EventArgs e)
        {
            FormPermissions form= new FormPermissions();    
            form.ShowDialog();  
        }
    }
}
