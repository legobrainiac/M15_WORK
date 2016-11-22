/********************************************************************
	created:	2016/11/22
	created:	22:11:2016   10:56
	filename: 	C:\Users\legobrainiac\Documents\Visual Studio 2015\Projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24\items_ar.cs
	file path:	C:\Users\legobrainiac\Documents\Visual Studio 2015\Projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24
	file base:	items_ar
	file ext:	cs
	author:		Tomás António Sanches Pinto
	
	purpose:	For for items
*********************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trab_m15_psi_tomás_pinto_n24
{
    public partial class items_ar : Form
    {
        public items_ar()
        {
            InitializeComponent();
        }

        private void items_ar_Load(object sender, EventArgs e)
        {
            //combo_box_items.DataSource = items_handler.ReadAllList();
        }

        private void btn_photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pb_image.Image = Image.FromFile(dialog.FileName);
            }
        }
    }
}
