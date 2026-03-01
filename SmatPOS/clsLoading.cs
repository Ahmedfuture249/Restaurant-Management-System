using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmatPOS
{
    public class clsLoading
    {
        private SqlCommand command;
        private SqlDataReader reader;
        public void LoadSystemOptoions()
        {
            command = new SqlCommand("select top 1 * from optiones", adoClass.sqlcon);
            reader = null;
            try
            {
                if (adoClass.sqlcon.State != ConnectionState.Open) { adoClass.sqlcon.Open(); }
                reader = command.ExecuteReader();
                declarations.systemOptions = new Dictionary<string, object>();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        declarations.systemOptions.Add(reader.GetName(i), reader.GetValue(i));
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading system options: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
                adoClass.sqlcon.Close();
            }
        }
    }
}
