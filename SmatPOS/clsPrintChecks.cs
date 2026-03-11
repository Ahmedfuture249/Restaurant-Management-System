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
using System.Windows.Forms;
namespace SmatPOS
{
    
    public class clsPrintChecks
    {
        private SqlCommand cmd;
        private SqlDataReader dr;
        private SqlDataAdapter dataAdapter;
        private DataTable dt;

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
            frm.MainReport.LocalReport.ReportEmbeddedResource = "SmatPOS.Report1.rdlc";
            frm.MainReport.LocalReport.DataSources.Clear();
            frm.MainReport.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", checks.Tables["dtCheck"]));
            ReportParameter[] rb = new ReportParameter[4];
            //rb[0]=new ReportParameter("Line1", declarations.systemOptions["ReceiptLine1"].ToString());
            //rb[1] = new ReportParameter("Line2", declarations.systemOptions["ReceiptLine2"].ToString());
           // rb[2] = new ReportParameter("RestarauntName", declarations.systemOptions["RestaruntName"].ToString());
           // byte[] imagebytes = (byte[])declarations.systemOptions["logo"];
          //  rb[3] = new ReportParameter("image", Convert.ToBase64String(imagebytes));
            LocalReport report = new LocalReport();
            string path = Application.StartupPath + @"\Reports\Report1.rdlc";
            report.ReportPath = path;
            report.DataSources.Clear();
            report.DataSources.Add(new ReportDataSource("DataSet1", checks.Tables["dtCheck"]));
           // report.SetParameters(rb);
            PrinterClass.PrintToPrinter(report);    
            //frm.MainReport.LocalReport.SetParameters(rb);
            //frm.ShowDialog();
        }
        public void printorderCheck(int CheckID)
        {

            cmd = new SqlCommand("SELECT * FROM viewChecks WHERE ID = @CheckID", adoClass.sqlcon);
            cmd.Parameters.AddWithValue("@CheckID", CheckID);
            dsChecks checks = new dsChecks();
            try
            {
                if (adoClass.sqlcon.State != ConnectionState.Open) adoClass.sqlcon.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DataRow dro = checks.Tables["dtCheck"].NewRow();
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
            frm.MainReport.LocalReport.ReportEmbeddedResource = "SmatPOS.check2.rdlc";
            frm.MainReport.LocalReport.DataSources.Clear();
            frm.MainReport.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", checks.Tables["dtCheck"]));
            ReportParameter[] rb = new ReportParameter[4];
            //rb[0]=new ReportParameter("Line1", declarations.systemOptions["ReceiptLine1"].ToString());
            //rb[1] = new ReportParameter("Line2", declarations.systemOptions["ReceiptLine2"].ToString());
            // rb[2] = new ReportParameter("RestarauntName", declarations.systemOptions["RestaruntName"].ToString());
            // byte[] imagebytes = (byte[])declarations.systemOptions["logo"];
            //  rb[3] = new ReportParameter("image", Convert.ToBase64String(imagebytes));
            LocalReport report = new LocalReport();
            string path = Application.StartupPath + @"\Reports\check2.rdlc";
            report.ReportPath = path;
            report.DataSources.Clear();
            report.DataSources.Add(new ReportDataSource("DataSet1", checks.Tables["dtCheck"]));
            // report.SetParameters(rb);
            PrinterClass.PrintToPrinter(report);
            //frm.MainReport.LocalReport.SetParameters(rb);
            //frm.ShowDialog();
        }
        public  void PrintSaleReport(DateTime _from, DateTime _to)
        {
            string query = "select * from ViewSaleChecks where checkdate between '"
+ _from.ToString("yyyy-MM-dd") +
"' and '" + _to.ToString("yyyy-MM-dd") + "'";
            dataAdapter = new SqlDataAdapter(query, adoClass.sqlcon);
            dsReports report=new dsReports();
            try
            {
                dataAdapter.Fill(report.Tables["ViewSaleChecks"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error!!");
            }
            FormReports frm = new FormReports();
            frm.MainReport.LocalReport.ReportEmbeddedResource = "SmatPOS.rptchecksales.rdlc";
            frm.MainReport.LocalReport.DataSources.Clear();
            frm.MainReport.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", report.Tables["ViewSaleChecks"]));
            ReportParameter[] rb = new ReportParameter[4];
            rb[0] = new ReportParameter("From", _from.ToString("yyyy-MM-dd"));
            rb[1] = new ReportParameter("To", _to.ToString("yyyy-MM-dd"));
            rb[2] = new ReportParameter("restname", declarations.systemOptions["RestaruntName"].ToString());
            byte[] imagebytes = (byte[])declarations.systemOptions["logo"];
            rb[3] = new ReportParameter("Image", Convert.ToBase64String(imagebytes));
            frm.MainReport.LocalReport.SetParameters(rb);
            frm.ShowDialog();


        }
        public void PrintDetailedSalesReport(DateTime _from, DateTime _to)
        {
            string query = "select * from ViewSaledetailes where checkdate between '"
+ _from.ToString("yyyy-MM-dd") +
"' and '" + _to.ToString("yyyy-MM-dd") + "'";
            dataAdapter = new SqlDataAdapter(query, adoClass.sqlcon);
            dsReports report = new dsReports();
            report.EnforceConstraints = false;
            try
            {
                dataAdapter.Fill(report.Tables["ViewSaledetailes"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error!!");
            }
            FormReports frm = new FormReports();
            frm.MainReport.LocalReport.ReportEmbeddedResource = "SmatPOS.DetailedSalesReport.rdlc";
            frm.MainReport.LocalReport.DataSources.Clear();
            frm.MainReport.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", report.Tables["ViewSaledetailes"]));
            ReportParameter[] rb = new ReportParameter[4];
            rb[0] = new ReportParameter("From", _from.ToString("yyyy-MM-dd"));
            rb[1] = new ReportParameter("To", _to.ToString("yyyy-MM-dd"));
            rb[2] = new ReportParameter("restname", declarations.systemOptions["RestaruntName"].ToString());
            byte[] imagebytes = (byte[])declarations.systemOptions["logo"];
            rb[3] = new ReportParameter("Image", Convert.ToBase64String(imagebytes));
            frm.MainReport.LocalReport.SetParameters(rb);
            frm.ShowDialog();


        }
        public void PrintSalesByItemReport(DateTime _from, DateTime _to,string catid)
        {
            string query = "select * from ViewSalesbyitem where checkdate between '"
+ _from.ToString("yyyy-MM-dd") +
"' and '" + _to.ToString("yyyy-MM-dd") + " '";
            query += "and id= '" + catid+" '";
            dataAdapter = new SqlDataAdapter(query, adoClass.sqlcon);
            dsReports report = new dsReports();
            report.EnforceConstraints = false;
            try
            {
                dataAdapter.Fill(report.Tables["ViewSalesbyitem"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error!!");
            }
            FormReports frm = new FormReports();
            frm.MainReport.LocalReport.ReportEmbeddedResource = "SmatPOS.rptsalesbyitem.rdlc";
            frm.MainReport.LocalReport.DataSources.Clear();
            frm.MainReport.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", report.Tables["ViewSalesbyitem"]));
            ReportParameter[] rb = new ReportParameter[4];
            rb[0] = new ReportParameter("From", _from.ToString("yyyy-MM-dd"));
            rb[1] = new ReportParameter("To", _to.ToString("yyyy-MM-dd"));
            rb[2] = new ReportParameter("restname", declarations.systemOptions["RestaruntName"].ToString());
            byte[] imagebytes = (byte[])declarations.systemOptions["logo"];
            rb[3] = new ReportParameter("Image", Convert.ToBase64String(imagebytes));
            frm.MainReport.LocalReport.SetParameters(rb);
            frm.ShowDialog();


        }
    }
}
