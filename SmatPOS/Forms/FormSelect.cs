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
    public partial class FormSelect: Form
    {
        public FormSelect(string selecttext)
        {
            selectText = selecttext;
            InitializeComponent();
        }
        private DataTable dataTable;
        private SqlDataAdapter adapter;
        public string des { set; get; }
        public string selectText { set; get; }
        public string result { set; get; }  

        private void txtDes_KeyUp(object sender, KeyEventArgs e)
        {
            loadselect();
        }
        private void loadselect()
        {
            dataTable.DefaultView.Sort = "ID";
            DataRow[] rows = dataTable.Select($"{des} LIKE '%{txtDes.Text}%'");

        
            dataGridView1.Rows.Clear();
            for (int i = 0; i <= rows.Length - 1; i++)
            {
                dataGridView1.Rows.Add(new object[] 
                { 
                    rows[i][0], rows[i][des]
                });
            }
        }

        private void FormSelect_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter(selectText, adoClass.sqlcon);
            dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                loadselect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                result = dataGridView1[ColID.Index,dataGridView1.CurrentRow.Index].Value.ToString();   
                this.DialogResult = DialogResult.OK;
                Close();

            }
        }
    }
}
