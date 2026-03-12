using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmatPOS
{
    public class SwitchLangouge
    {
        public SwitchLangouge(string Lang, Type t)
        {
            rm = new ResourceManager("SmatPOS.Languages.Language", t.Assembly);
            culture=new CultureInfo(Lang);
        }
        ResourceManager rm;
        CultureInfo culture;

        public void SetLangouge(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (!string.IsNullOrEmpty(control.AccessibleName))
                {
                    control.Text = rm.GetString(control.AccessibleName, culture);

                }
                if (control.Controls.Count > 0)
                {
                    SetLangouge(control.Controls);
                }
            }
        }
    }
}
