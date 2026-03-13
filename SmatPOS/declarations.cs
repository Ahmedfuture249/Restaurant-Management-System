using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmatPOS
{
    public class declarations
    {
        public static int UserID { get; set; }
        public static string UserName { get; set; }
        public static Dictionary<string, Object> systemOptions ;
        public static List<ModelPermission> permissions = new List<ModelPermission>();
        public static string Lang { set; get; }

        public class ModelPermission
        {
            public string mainscreen { get; set; }
            public string permission { get; set; }
            public bool thecase{ get; set; }
            

        }
    }
}
