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
using static System.Net.Mime.MediaTypeNames;

namespace SmatPOS.Forms
{
    public partial class FormPermissions: Form
    {
        public FormPermissions()
        {
            InitializeComponent();
        }
        private SqlCommand cmd;
        private SqlDataReader reader;
        private int counter = 1;
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

        private void  savecmd(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please select a user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            cmd = new SqlCommand(" text , adoClass.sqlcon");
            
            try
            {
                if (adoClass.sqlcon.State != ConnectionState.Open) { adoClass.sqlcon.Open(); }
                cmd = new SqlCommand(text, adoClass.sqlcon);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                adoClass.sqlcon.Close();
            }
        }
        private void saveData(string userId)
        {
           
            string query = " delete From userPermission  WHERE Userid =  ' " + userId+ "'";
            savecmd(query);
            counter = 1;
            string InsertText = (getDataCheckBox(this.Controls, userId));
            savecmd(InsertText);
            MessageBox.Show("success");
        }
        private string getDataCheckBox(Control.ControlCollection controls, string userID)
        {
            string xresult = string.Empty;
            foreach (Control c in controls)
            {
                if (c is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)c;
                    xresult += "insert into userPermission (pindex,mainscreen,permission,UserId,thecase) ";
                    xresult += "values (" + counter;
                    xresult += ",'" + checkBox.AccessibleDescription + "'";
                    xresult += ",'" + checkBox.AccessibleName + "'";
                    xresult += "," + userID;
                    xresult += "," + (checkBox.Checked?1:0)+")";
                    xresult += "\n";
                    counter++;

                }
                if (c.Controls.Count > 0)
                {
                    xresult += getDataCheckBox(c.Controls, userID);
                }
            }
            return xresult; 
        }
        private void toolStripBtnSve_Click(object sender, EventArgs e)
        {
            if (comboBoxUsers.Text == "")
            {
                MessageBox.Show("Select user First");
                return; 
            }
            string userID=((comboItem)comboBoxUsers.SelectedItem).Id;
            saveData(userID);

        }
        private void fillDataPermission(string userID)

        {
            cmd = new SqlCommand("SELECT * FROM userPermission WHERE UserId = '" + userID + "'", adoClass.sqlcon);
            reader = null;

            try
            {
                if (adoClass.sqlcon.State != ConnectionState.Open) { adoClass.sqlcon.Open(); }
              
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Checchbox(this.Controls, reader.GetBoolean(reader.GetOrdinal("thecase")), reader.GetString(reader.GetOrdinal("mainscreen")), reader.GetString(reader.GetOrdinal("permission")));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null) { reader.Close(); }
                adoClass.sqlcon.Close();
            }
        }
        private void Checchbox(Control.ControlCollection controls,bool status,string mainscreen,string permission)
        {
            foreach (Control control in controls)
            {
                if(control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox) control;
                    if(checkBox.AccessibleDescription == mainscreen && checkBox.AccessibleName == permission)
                    {
                        checkBox.Checked = status;
                    }


                }
                if(control.Controls.Count > 0)
                {
                    Checchbox(control.Controls, status, mainscreen, permission);
                }
            }
        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxUsers.Text=="")
            {
                return;
            }
            CheckAll(this.Controls,false);
            string userID = ((comboItem)comboBoxUsers.SelectedItem).Id;
            fillDataPermission(userID);

        }
    }
}
