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
    public partial class FormItems: Form
    {
        public FormItems()
        {
            InitializeComponent();
        }
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private DataRow row;
        private int Index;
        private void FormItems_Load(object sender, EventArgs e)
        {
            SwitchLangouge langouge = new SwitchLangouge(declarations.Lang, typeof(MainForm));
            langouge.SetLangouge(this.Controls); 
            clsHelper.fillComboBox(comboBoxCategories, "Select ID,Description from categories");
            adapter = new SqlDataAdapter("Select  * from Items", adoClass.sqlcon);
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
                txtDES.Text = dataTable.Rows[_Index]["Description"].ToString();
                txtNotes.Text = dataTable.Rows[_Index]["Notes"].ToString();
                
                txtPrice.Text = dataTable.Rows[_Index]["Price"].ToString();
                comboBoxCategories.Text = clsHelper.getComboItemVal(comboBoxCategories, row["CategoryID"].ToString());
                if (row["ItemImage"] != DBNull.Value)
                {
                    pictureBoXImage.BackgroundImage = clsHelper.ByteToImage(row["ItemImage"]);
                }
                else
                {
                    pictureBoXImage.BackgroundImage = null;
                }

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
                txtDES.Text = row["Description"].ToString();
                txtNotes.Text = row["Notes"].ToString();
                txtPrice.Text =   row["Price"].ToString();
                comboBoxCategories.Text = clsHelper.getComboItemVal(comboBoxCategories, row["CategoryID"].ToString());
                if (row["ItemImage"] != DBNull.Value)
                {
                    pictureBoXImage.BackgroundImage = clsHelper.ByteToImage(row["ItemImage"]);
                }
                else
                {
                    pictureBoXImage.BackgroundImage = null;
                }

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
                if (control is ComboBox)
                {
                    control.Text = "";
                }
            }
            pictureBoXImage.BackgroundImage = null;
            txtDES.Focus();
        }
        private void SaveData()
        {
            if (txtDES.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Description ");
                txtDES.Focus();
                return;
            }
            if (txtPrice.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Item Price ");
                txtPrice.Focus();
                return;
            }
            if (comboBoxCategories.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Item Item Categorey ");
                txtPrice.Focus();
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
            row["Description"] = txtDES.Text;
            row["price"] = txtPrice.Text;
            row["Notes"] = txtNotes.Text;
            row["categoryID"]=((comboItem)comboBoxCategories.SelectedItem).Id;
            if(pictureBoXImage != null)
            {
                row["ItemImage"]=clsHelper.ImageToByte(pictureBoXImage.BackgroundImage);
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

        private void toolStripBtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripBtnSelect_Click(object sender, EventArgs e)
        {
            FormSelect select = new FormSelect("select ID,Description FROM items");
            select.des = "Description";
            if (select.ShowDialog() == DialogResult.OK)
            {
                LoadData(int.Parse(select.result));
            }
        }

        private void btnChoseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images|* .png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = openFileDialog.FileName;
                pictureBoXImage.BackgroundImage = new Bitmap(txtImagePath.Text);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
