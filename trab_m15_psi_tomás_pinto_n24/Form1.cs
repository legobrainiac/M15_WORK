using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace trab_m15_psi_tomás_pinto_n24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Creates database in the executable directory
            string name = Directory.GetCurrentDirectory() + "\\m15_trab.mdf";

            Clipboard.SetText(name);

            if (!File.Exists(name))
                db_handler.create_db(name);
        }
    }
}
