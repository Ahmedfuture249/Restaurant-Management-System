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
        private int Index;

        private void FormUsers_Load(object sender, EventArgs e)
        {
            SwitchLangouge langouge = new SwitchLangouge(declarations.Lang, typeof(MainForm));
            langouge.SetLangouge(this.Controls); 
            adapter = new SqlDataAdapter("Select  * from Users", adoClass.sqlcon);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            Index = 0;  
            LoadData(0);
        }

        private void LoadDataOfIndex(int _Index)

        {
            Index = _Index;
            if (dataTable.Rows.Count > 0 && _Index >= 0 && _Index <= dataTable.Rows.Count - 1)
            {
                row = dataTable.Rows[_Index];
                txtEmail.Text = dataTable.Rows[_Index]["Email"].ToString();
                txtFullName.Text = dataTable.Rows[_Index]["FullName"].ToString();
                txtJopDes.Text = dataTable.Rows[_Index]["jobDES"].ToString();
                txtPassword.Text = dataTable.Rows[_Index]["Password"].ToString();
                txtPhone.Text = dataTable.Rows[_Index]["Phone"].ToString();
                txtUserName.Text = dataTable.Rows[_Index]["UserName"].ToString();
            }
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
            Update();
        }
        private void Update()
        {
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

        private void toolStripBtnFirst_Click(object sender, EventArgs e)
        {
            LoadDataOfIndex(0);
        }

        private void toolStripBtnBack_Click(object sender, EventArgs e)
        {
            if (Index > 0)
            {
                Index--;
                LoadDataOfIndex(Index);
            }
        }

        private void toolStripBtnNext_Click(object sender, EventArgs e)
        {
            if (Index < dataTable.Rows.Count-1)
            {
                Index++;
                LoadDataOfIndex(Index);
            }
        }

        private void toolStripBtnLast_Click(object sender, EventArgs e)
        {
            LoadDataOfIndex(dataTable.Rows.Count - 1);
        }

        private void toolStripBtnSelect_Click(object sender, EventArgs e)
        {
            FormSelect select=new FormSelect("select ID,FullName FROM USERS");
            select.des = "FullName";
            if (select.ShowDialog() == DialogResult.OK)
            {
                LoadData(int.Parse(select.result));
            }


        }

        private void toolStripBtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("confirm Delete ?", "Q", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                row.Delete();
                Update();
                LoadDataOfIndex(0);

            }
        }
    }
}
