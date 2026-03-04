using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace SmatPOS
{
   public class clsHelper
    {
        public static Byte[] ImageToByte(Image image)
        {
            Byte[] bresult = null;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                bresult = ms.ToArray(); 
            }
            return bresult;
        }
        public static Image ByteToImage(Object obj)
        {
            Byte[] myimage = (Byte[])obj;
            Image image = null;
            using (MemoryStream ms = new MemoryStream(myimage, 0, myimage.Length))
            {
                ms.Write(myimage, 0, myimage.Length);
                image=Image.FromStream(ms,true);
            }
            return image;   
        }
        public static string getComboItemVal(ComboBox    combo, string key)
        {
            string x = string.Empty;
            foreach (var item in combo.Items)
            {
                comboItem cItem = (comboItem)item;
                if (cItem.Id == key)
                {
                    x = cItem.DES;
                }
            }
            return x;
        }
        public static void fillComboBox(ComboBox combo, string selectTxt)
        {
            SqlCommand sqlCmd = new SqlCommand(selectTxt, adoClass.sqlcon);
            SqlDataReader reader = null;

            try
            {
                if (adoClass.sqlcon.State != ConnectionState.Open)
                    adoClass.sqlcon.Open();

                combo.Items.Clear();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    comboItem item = new comboItem(
                        reader[0].ToString(),
                        reader[1].ToString());

                    combo.Items.Add(item);
                }
                combo.Items.Add(new comboItem("", ""));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoClass.sqlcon.Close();
            }
        }
        public static void LoadPermissions(Control.ControlCollection controls, string MainScreen)
        {
            foreach (Control control in controls)
            {
               
                   declarations.ModelPermission permission = declarations.permissions.FirstOrDefault(p => p.mainscreen == MainScreen && p.permission == control.AccessibleName);
                    if (permission != null)
                    {
                        control.Enabled = permission.thecase;
                    }
                
                if (control.Controls.Count > 0)
                {
                    LoadPermissions(control.Controls, MainScreen);
                }
            }
        }
    }
}
