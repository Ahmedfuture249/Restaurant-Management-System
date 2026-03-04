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
                return;
            }
            finally
            {
                if (Reader != null && !Reader.IsClosed)
                    Reader.Close();

               adoClass.sqlcon.Close();
            }
            if(declarations.UserID != 0)
            {
                LoadPermission();
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
        //private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        btnOk.PerformClick();
        //    }
        //}
        //private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        txtPassword.Focus();
        //    }
        //}
        private void LoadPermission()
        {
            string query = "SELECT * FROM UserPermission WHERE UserID = @UserID";
            SqlCommand cmd = new SqlCommand(query, adoClass.sqlcon);
            cmd.Parameters.AddWithValue("@UserID", declarations.UserID);
            declarations.permissions= new List<declarations.ModelPermission>();
            try
            {
                
                if (adoClass.sqlcon.State != ConnectionState.Open) { adoClass.sqlcon.Open(); }
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {

                    declarations.ModelPermission model = new declarations.ModelPermission();


                    model.mainscreen = Reader["mainscreen"].ToString();
                    model.permission = Reader["permission"].ToString();
                    model.thecase = Convert.ToBoolean(Reader["thecase"]);

                    declarations.permissions.Add(model);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading permissions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Reader != null && !Reader.IsClosed)
                    Reader.Close();
                adoClass.sqlcon.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOk.PerformClick();
            }
        }
    }
}
