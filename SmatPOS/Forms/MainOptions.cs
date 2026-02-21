using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SmatPOS.Forms
{
    public partial class MainOptions: Form
    {
        public MainOptions()
        {
            InitializeComponent();
        }
        private SqlDataAdapter adapter;
        private DataTable dt;
        private DataRow Row;
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void MainOptions_Load(object sender, EventArgs e)
        {
            adoClass.SetConnection();
            adapter = new SqlDataAdapter("SELECT Top 1 * FROM Optiones", adoClass.sqlcon);

            dt = new DataTable();
            try
            {

                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Row= dt.Rows[0];

                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        txtRestName.Text = dt.Rows[i]["RestaruntName"].ToString();
                        txtRestAddress1.Text = dt.Rows[i]["RestaruntAddress1"].ToString();
                        txtRestAddress2.Text = dt.Rows[i]["RestaruntAddress2"].ToString();
                        txtPhone.Text = dt.Rows[i]["Phone"].ToString();
                        txtPrinter.Text = dt.Rows[i]["PrinterName"].ToString();
                        txtReceiptLine1.Text = dt.Rows[i]["ReceiptLine1"].ToString();
                        txtReceiptLine2.Text = dt.Rows[i]["ReceiptLine2"].ToString();
                        pbLogo.BackgroundImage = clsHelper.ByteToImage(dt.Rows[i]["Logo"]);


                    }
                }
                else
                {
                    Row= null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
         if(MessageBox.Show("Save New Data","?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
              SaveData();
                return;
            }



        }
        private void SaveData()
        {
            if (txtRestName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Restaraunt Name ");
                txtRestName.Focus();
                return;
            }
            if (txtPhone.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Phone Number ");
                txtPhone.Focus();
                return;
            }
            if (Row == null)
            {
                Row = dt.NewRow();
                DataFillRow();
                dt.Rows.Add(Row);
            }
            else
            {
                Row.BeginEdit();
                DataFillRow();
                Row.EndEdit();
            }
            try
            {
                adoClass.Builder = new SqlCommandBuilder(adapter);
                adapter.Update(dt);
                MessageBox.Show("Data Has Been Updated");
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }

        }
        private void DataFillRow()
        {
            Row["RestaruntName"] =txtRestName.Text;
            Row["RestaruntAddress1"] = txtRestAddress1.Text;
            Row["RestaruntAddress2"] = txtRestAddress2.Text;
            Row["Phone"] = txtPhone.Text;
            Row["PrinterName"] = txtPrinter.Text;
            Row["ReceiptLine1"] = txtReceiptLine1.Text;
            Row["ReceiptLine2"] = txtReceiptLine2.Text;
            if (pbLogo.BackgroundImage!=null)
            {
                Row["Logo"]=clsHelper.ImageToByte(pbLogo.BackgroundImage);
            }

        }

        private void btnChoseLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images|* .png";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtLogoPath.Text = openFileDialog.FileName;
                pbLogo.BackgroundImage = new Bitmap(txtLogoPath.Text);
            }
        }
    }
}
