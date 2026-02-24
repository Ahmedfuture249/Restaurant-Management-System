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
    public partial class POSForm: Form
    {
        public POSForm()
        {
            InitializeComponent();
        }
        private SqlDataAdapter adapter;
        private DataTable _ItemDt;
        private void btnPrint_Click(object sender, EventArgs e)
        {

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
            FillCategories();
        }
        private void FillCategories()
        {
            adapter= new SqlDataAdapter("select Id,Description from categories",adoClass.sqlcon);
            _ItemDt=new DataTable();
            try
            {
                adapter.Fill(_ItemDt);
                DataRow[] dataRows = _ItemDt.Select();
                int x = 1;int y = 1;int count = 1;
                pnlItems.Controls.Clear();
                for(int i = 0;i<=dataRows.Length-1;i++)
                {
                    Button catbtn = new Button();
                    catbtn.AccessibleName = "CAT";
                    catbtn.AccessibleDescription = dataRows[i]["ID"].ToString();
                    catbtn.Name = "btncat" + dataRows[i]["ID"].ToString();
                    catbtn.Text = dataRows[i]["Description"].ToString();
                    catbtn.Size = new Size(100, 100);
                    catbtn.Location = new Point(x, y);
                    pnlItems.Controls.Add(catbtn);
                    x+=101;
                    if(count==7)
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

    }
}
