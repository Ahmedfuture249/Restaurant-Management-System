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
    public partial class POSForm : Form
    {
        public POSForm()
        {
            InitializeComponent();
            checkID = "0";
        }
        private SqlDataAdapter adapter;
        private DataTable _ItemDt;
        private string checkID;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (checkID == "0")
            {
                MessageBox.Show("Please save the check before print");
                return;
            }
            else
            { 
            clsPrintChecks checks = new clsPrintChecks();
            checks.printCheck(int.Parse(checkID));
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void POSForm_Load(object sender, EventArgs e)
        {
            clsHelper.fillComboBox(comboBox1, "select * from Payments");
            comboBox1.Text=clsHelper.getComboItemVal(comboBox1, "1");   
            FillCategories();
            button0.Click += num_Click;
            button1.Click += num_Click;
            button2.Click += num_Click;
            button3.Click += num_Click;
            button4.Click += num_Click;
            button5.Click += num_Click;
            button6.Click += num_Click;
            button7.Click += num_Click;
            button8.Click += num_Click;
            button9.Click += num_Click;
            buttonC.Click += num_Click;
            buttonDOT.Click += num_Click;
        }
        private void FillCategories()
        {
            adapter = new SqlDataAdapter("select Id,Description from categories", adoClass.sqlcon);
            _ItemDt = new DataTable();
            try
            {
                adapter.Fill(_ItemDt);
                DataRow[] dataRows = _ItemDt.Select();
                int x = 1; int y = 1; int count = 1;
                pnlItems.Controls.Clear();
                for (int i = 0; i <= dataRows.Length - 1; i++)
                {
                    Button catbtn = new Button();
                    catbtn.AccessibleName = "CAT";
                    catbtn.AccessibleDescription = dataRows[i]["ID"].ToString();
                    catbtn.Name = "btncat" + dataRows[i]["ID"].ToString();
                    catbtn.Text = dataRows[i]["Description"].ToString();
                    catbtn.Size = new Size(100, 100);
                    catbtn.Location = new Point(x, y);
                    catbtn.Click += cBtn_Click;

                    pnlItems.Controls.Add(catbtn);
                    x += 101;
                    if (count == 7)
                    {
                        y += 101;
                        x = 1;
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.AccessibleName == "CAT")
            {
                string CatID = button.AccessibleDescription;
                FillItems(CatID);
            }
            else if (button.AccessibleName == "IT")
            {
                double x = 0;
                double.TryParse(txtItemQTY.Text, out x);
                double totalPrice = 0;
                double ItemPrice = 0;
                double.TryParse(button.Tag.ToString(), out ItemPrice);
              
                if (x == 0)
                {
                    x = 1;
                }
                totalPrice = x * ItemPrice;
                dgvItems.Rows.Add(new object[]
                {
                    button.AccessibleDescription,
                    button.Text,
                    x,
                   
                    totalPrice
                    ,ItemPrice
                }
                    );
                txtItemQTY.Text = "0";
            }
            else
            {
                FillCategories();
            }
            CalculateCheck();
        }
        private void FillItems(string catID)
        {
            adapter = new SqlDataAdapter("select * from items where categoryID='" + catID + "'", adoClass.sqlcon);
            _ItemDt = new DataTable();
            try
            {
                adapter.Fill(_ItemDt);
                DataRow[] dataRows = _ItemDt.Select();
                int x = 1; int y = 1; int count = 1;
                pnlItems.Controls.Clear();
                for (int i = 0; i <= dataRows.Length - 1; i++)
                {
                    Button catbtn = new Button();
                    catbtn.AccessibleName = "IT";
                    catbtn.AccessibleDescription = dataRows[i]["ID"].ToString();
                    catbtn.Name = "btncat" + dataRows[i]["ID"].ToString();
                    catbtn.Text = dataRows[i]["Description"].ToString();
                    catbtn.Tag = dataRows[i]["Price"].ToString();
                    catbtn.TextAlign = ContentAlignment.BottomRight;
                    catbtn.BackgroundImage = clsHelper.ByteToImage(dataRows[i]["ItemImage"]);
                    catbtn.BackgroundImageLayout = ImageLayout.Zoom;
                    catbtn.Size = new Size(100, 100);
                    catbtn.Location = new Point(x, y);
                    catbtn.Click += cBtn_Click;

                    pnlItems.Controls.Add(catbtn);
                    x += 101;
                    if (count == 7)
                    {
                        y += 101;
                        x = 1;
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }

                }
                Button cbtn = new Button();
                cbtn.AccessibleName = "c";
                cbtn.Name = "btnEnd" + catID;
                cbtn.Text = "Cancel";
                cbtn.Location = new Point(x, y);
                cbtn.Size = new Size(100, 100);
                cbtn.Click += cBtn_Click;
                pnlItems.Controls.Add(cbtn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void pnlItems_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CalculateCheck()
        {
            double x = 0;
            double result = 0;
            for (int i = 0; i <= dgvItems.Rows.Count - 1; i++)
            {
                double.TryParse(dgvItems[ColPrice.Index, i].Value.ToString(), out x);
                result += x;
            }
            txtTotal.Text = result.ToString();
        }
        private void num_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "C")
            {
                txtItemQTY.Text = "0";
            }
            else if (button.Text == ".")
            {
                if (!txtItemQTY.Text.Contains("."))
                    if (int.Parse(txtItemQTY.Text) == 0)
                    {
                        button.Text = "0.";
                    }
                    else
                    {
                        txtItemQTY.Text += button.Text;
                    }
            }
            else
            {
                if (int.Parse(txtItemQTY.Text) == 0)
                {
                    txtItemQTY.Text = "";

                }
                txtItemQTY.Text += button.Text;
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvItems.Rows.Clear();
            CalculateCheck();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvItems.Rows.Count > 0)
            {
                dgvItems.Rows.Remove(dgvItems.CurrentRow);
            }
            CalculateCheck();
        }
        private void SaveCheck()
        {
            string insertSgl = "insert into Checks(CheckDate,userID,TotalCheck,Status) values(@CheckDate,@userID,@TotalCheck,@Status)";
            insertSgl += "select @CheckID= SCOPE_IDENTITY();";
            SqlCommand sqlCommand = new SqlCommand(insertSgl, adoClass.sqlcon);
            sqlCommand.Parameters.Add("@CheckDate", SqlDbType.DateTime);
            sqlCommand.Parameters.Add("@userID", SqlDbType.Int);
            sqlCommand.Parameters.Add("@TotalCheck", SqlDbType.Decimal);
            sqlCommand.Parameters.Add("@Status", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@CheckID", SqlDbType.Int);
            try
            {
                sqlCommand.Parameters["@CheckDate"].Value= DateTime.Now;
                sqlCommand.Parameters["@userID"].Value = declarations.UserID;
                sqlCommand.Parameters["@TotalCheck"].Value= double.Parse(txtTotal.Text);
                sqlCommand.Parameters["@Status"].Value = "Close"    ;
                sqlCommand.Parameters["@CheckID"].Direction  = ParameterDirection.Output;
                 if(adoClass.sqlcon.State!=ConnectionState.Open)
                {
                    adoClass.sqlcon.Open(); 
                }
                sqlCommand.ExecuteNonQuery();   
                 checkID = sqlCommand.Parameters["@CheckID"].Value.ToString();
                this.Text += ":ID : " + checkID + " : ";
                SaveDataItems(checkID);
                SaveDataIPayments(checkID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void SaveDataItems(string checkID)
        {
             adapter = new SqlDataAdapter("select * from checksItems", adoClass.sqlcon);
             _ItemDt = new DataTable();
            {
                try
                {

                    adapter.Fill(_ItemDt);
                    for (int i = 0; i <= dgvItems.Rows.Count - 1; i++)
                    {
                        DataRow row = _ItemDt.NewRow();
                        row["checkID"] = int.Parse(checkID);
                        row["ItemID"] = dgvItems[ColID.Index, i].Value;
                        row["Quantity"] = dgvItems[colQTY.Index, i].Value;
                        row["Price"] = dgvItems[ColPrice.Index, i].Value;
                        row["totalprice"] = dgvItems[colItemprice.Index, i].Value;
                        _ItemDt.Rows.Add(row);


                    }
                    SaveDate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void SaveDate()
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(_ItemDt);
        }
        private void SaveDataIPayments(string checkID)
        {
             adapter = new SqlDataAdapter("select * from ChecksPayments", adoClass.sqlcon);
           _ItemDt = new DataTable();
            {
                try
                {

                    adapter.Fill(_ItemDt);
                   
                        DataRow row = _ItemDt.NewRow();
                        row["CheckID"] = int.Parse(checkID);
                        row["PaymentID"] = (comboBox1.SelectedItem as comboItem).Id;
                    row["paymentValue"] = decimal.Parse(txtPaid.Text);

                    _ItemDt.Rows.Add(row);  



                    SaveDate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            double totalCheck = 0;
            double totalPay = 0;
            double.TryParse(txtTotal.Text, out totalCheck);
            double.TryParse(txtItemQTY.Text, out totalPay);
            if (totalCheck == 0)
            {
                MessageBox.Show("No items in the check");
                return;
            }
            else if (totalPay == 0)
            {
                MessageBox.Show("Can't Pay Without Money");
                return;
            }
            if(totalPay<totalCheck)
            {
                MessageBox.Show("The paymetn not enough");
            }
            if(comboBox1.Text==string.Empty) {
                MessageBox.Show("Please select the payment method");
                return;
            }
           
            txtPaid.Text = totalPay.ToString();
            txtchange.Text=(totalPay-totalCheck).ToString();
            SaveCheck();
        }
        }
}
