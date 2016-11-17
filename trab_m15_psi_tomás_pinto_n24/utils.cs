using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace trab_m15_psi_tomás_pinto_n24
{
    class utils
    {
        static public byte[] ImageToArray(string file)
        {
            byte[] data = null;

            try
            {
                using (var fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                {
                    data = new byte[fs.Length];
                    fs.Read(data, 0, (int)fs.Length);
                }
            }
            catch (System.Exception ex)
            {
                return null;
            }

            return data;
        }

        static public void ArrayToImage(byte[] image, string file)
        {
            try
            {
                using (var fs = new FileStream(file, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(image, 0, image.GetUpperBound(0));
                }
            }
            catch (System.Exception ex)
            {
                return;
            }
        }
    }
}
