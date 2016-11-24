/********************************************************************
	created:	2016/11/24
	created:	24:11:2016   15:20
	filename: 	C:\Users\legobrainiac\Documents\Visual Studio 2015\Projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24\utils.cs
	file path:	C:\Users\legobrainiac\Documents\Visual Studio 2015\Projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24
	file base:	utils
	file ext:	cs
	author:		Tomás António Sanches Pinto
	
	purpose:	
*********************************************************************/

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
            catch 
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
            catch
            {
                return;
            }
        }

        //Self explanatory
        static public string ReadFile(string file)
        {
            return File.ReadAllText(file);
        }
    }
}
