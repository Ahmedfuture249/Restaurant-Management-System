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

namespace SmatPOS.Forms
{
    public partial class FormUsers: Form
    {
        
        public FormUsers()
        {
            InitializeComponent();
        }
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private DataRow row;

        private void FormUsers_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select top 1 from Users", adoClass.sqlcon);
            dataTable = new DataTable();
            LoadData(0);
        }

        private void label3_Click(object sender, EventArgs e)
        {
               
        }
        private void LoadData(int ID)
        {
            DataRow[] dataRows = null;
            if (ID == 0)
            {
                dataRows = dataTable.Select();
            }
            else
            {
                dataRows=dataTable.Select("ID = '"+ID+"'");
            }
            if (dataRows.Length > 0)
            {
                row= dataRows[0];
                txtEmail.Text = dataRows[0]["Email"].ToString();
                txtFullName.Text = dataRows[0]["FullName"].ToString();
                txtJopDes.Text = dataRows[0]["jobDES"].ToString();
                txtPassword.Text = dataRows[0]["Password"].ToString();
                txtPhone.Text = dataRows[0]["Phone"].ToString();
                txtUserName.Text = dataRows[0]["UserName"].ToString();
            }

        }

        private void toolStripBtnNew_Click(object sender, EventArgs e)
        {
            row = null;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
            }
        }

        private void toolStripBtnSve_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save New Data", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveData();
                return;
            }
        }
        private void SaveData()
        {
            if (txtUserName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter User Name ");
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Please Enter  your Password ");
                txtPassword.Focus();
                return;
            }
            if (txtFullName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Full Name ");
                txtFullName.Focus();
                return;
            }
            if (row == null)
            {
                row = dataTable.NewRow();
                DataFillRow();
                dataTable.Rows.Add(row);
            }
            else
            {
                row.BeginEdit();
                DataFillRow();
                row.EndEdit();
            }
            try
            {
                adoClass.Builder = new SqlCommandBuilder(adapter);
                adapter.Update(dataTable);
                MessageBox.Show("Data Updated Succesfuly");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DataFillRow()
        {
            row["UserName"]=txtUserName.Text;
            row["Password"]=txtPassword.Text;
            row["FullName"] = txtFullName.Text; 
            row["Phone"]=txtPhone.Text;
            row["Email"] = txtEmail.Text; 
            row["jobDes"]=txtJopDes.Text; 
        }
    }
}
