using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SmatPOS.Tools;
using SmatPOS.Forms;
using Microsoft.Reporting.WinForms;
namespace SmatPOS
{
    
    public class clsPrintChecks
    {
        private SqlCommand cmd;
        private SqlDataReader dr;

        public void printCheck(int CheckID)
        {

            cmd = new SqlCommand("SELECT * FROM viewChecks WHERE ID = @CheckID", adoClass.sqlcon);
            cmd.Parameters.AddWithValue("@CheckID", CheckID);
            dsChecks checks =new dsChecks();
            try
            {
                if(adoClass.sqlcon.State!=ConnectionState.Open) adoClass.sqlcon.Open();               
                dr = cmd.ExecuteReader();
                while (dr.Read())
                { 
                    DataRow dro =checks.Tables["dtCheck"].NewRow();
                    dro["ID"] = dr["ID"];
                    dro["CheckDate"] = dr["CheckDate"];
                    dro["CheckTotal"] = dr["TotalCheck"];
                    dro["ItemName"] = dr["Description"];
                    dro["ItemQTY"] = dr["Quantity"];
                    dro["ItemPrice"] = dr["Price"];
                    dro["ItemTotalPrice"] = dr["TotalPrice"];
                    dro["ItemID"] = dr["ItemID"];
                    checks.Tables["dtCheck"].Rows.Add(dro);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while printing the check: " + ex.Message);
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
                if (adoClass.sqlcon.State == ConnectionState.Open)
                {
                    adoClass.sqlcon.Close();
                }
            }
            FormReports frm = new FormReports();    
            frm.MainReport.LocalReport.ReportEmbeddedResource = "SmatPOS.rptCheck.rdlc";
            frm.MainReport.LocalReport.DataSources.Clear();
            frm.MainReport.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", checks.Tables["dtCheck"]));
            ReportParameter[] rb = new ReportParameter[3];
            rb[0]=new ReportParameter("Line1", declarations.systemOptions["ReceiptLine1"].ToString());
            rb[1] = new ReportParameter("Line2", declarations.systemOptions["ReceiptLine2"].ToString());
            rb[2] = new ReportParameter("RestarauntName", declarations.systemOptions["RestaruntName"].ToString());
            frm.MainReport.LocalReport.SetParameters(rb);
            frm.ShowDialog();
        }
    }
}
