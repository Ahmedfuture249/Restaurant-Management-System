using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmatPOS
{
     public class adoClass
    {
        public static SqlConnection sqlcon;
        public static SqlCommandBuilder Builder;
        public static void SetConnection()
        {
            sqlcon = new SqlConnection(SmatPOS.Properties.Settings.Default.connection);

           
        }
    }
}
