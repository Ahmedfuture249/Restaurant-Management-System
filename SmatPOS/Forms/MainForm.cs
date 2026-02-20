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
    public partial class MainForm: Form
    {
        private Button CurrentButton;
        private Form ActiveForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            this.ControlBox = false;
            this.Text = string.Empty;
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActivateButton(btnSender);
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlMainForm.Controls.Add(childForm);
         //   this.pnlMainForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private Color SelectTheme()
        {
            if (CurrentButton.Text == "Point Of Sale")
            {
                return Color.Gray;
            }
            else if (CurrentButton.Text == "Reporting")
            {
                return Color.Blue;
            }
            else if (CurrentButton.Text == "Setup")
            {
                return Color.Red;
            }
            else if (CurrentButton.Text == "Options")
            {
                return Color.Green;
            }

            else
            {
                return Color.Gray;
            }
        }
        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                if (CurrentButton != (Button)sender)
                {

                   
                    UnSelectButton();
                   
                    CurrentButton = (Button)sender;
                    Color color = SelectTheme();
                    CurrentButton.BackColor = color;
                    CurrentButton.ForeColor = Color.White;
                    CurrentButton.Font = new Font("Tohoma", 11F, FontStyle.Bold);
                    pnlTitle.BackColor = color; 
                    lblTitle.Text = CurrentButton.Text; 
                }
            }
        }
        private void UnSelectButton()
        {
            foreach (Control previousBtn in pnMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Gray;
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new Font("Tohoma", 10F, FontStyle.Regular);
                }
            }
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainPointOfSale(),sender);
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainSetup(), sender);
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainReportes(), sender);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainOptions(), sender);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void pnlMainForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
