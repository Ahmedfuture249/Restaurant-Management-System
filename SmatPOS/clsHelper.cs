using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
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
    }
}
