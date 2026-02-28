using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmatPOS
{
    public partial class FormLogin: Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private SqlDataAdapter adapter;
        private SqlDataReader Reader;

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();    
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

        }
        private void Login()
        {
            try
            {
                string query = "SELECT * FROM Users WHERE UserName = @UserName AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, adoClass.sqlcon);
                cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                if (adoClass.sqlcon.State != ConnectionState.Open) { adoClass.sqlcon.Open(); }
                Reader = cmd.ExecuteReader();
                if (Reader.Read())
                {
                    declarations.UserID = Convert.ToInt32(Reader["id"]);
                    declarations.UserName = Reader["FullName"].ToString();
                    this.DialogResult = DialogResult.OK;
                    Close();


                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Reader != null && !Reader.IsClosed)
                    Reader.Close();

               adoClass.sqlcon.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length == 0)
            {
                MessageBox.Show("Please enter your username.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Please enter your password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            Login();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
