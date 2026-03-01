using SmatPOS.Forms;
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
    public partial class FormPayments: Form
    {

        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private DataRow row;
        private int Index;
        public FormPayments()
        {
            InitializeComponent();
        }

        private void FormPayments_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select  * from Payments", adoClass.sqlcon);
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
                txtDes.Text = dataTable.Rows[_Index]["Description"].ToString();

            }
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
                dataRows = dataTable.Select("ID = '" + ID + "'");
            }
            if (dataRows.Length > 0)
            {
                row = dataRows[0];
                txtDes.Text = row["Description"].ToString();

            }

        }
        private void DataFillRow()
        {
            row["Description"] = txtDes.Text;

        }
        private void SaveData()
        {
            if (txtDes.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Desctiption ");
                txtDes.Focus();
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
            txtDes.Focus();
        }

        private void toolStripBtnSve_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save New Data", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveData();
                return;
            }
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
            if (Index < dataTable.Rows.Count - 1)
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
            FormSelect select = new FormSelect("select ID,Description FROM Payments");
            select.des = "Description";
            if (select.ShowDialog() == DialogResult.OK)
            {
                LoadData(int.Parse(select.result));
            }

        }

        private void toolStripBtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
