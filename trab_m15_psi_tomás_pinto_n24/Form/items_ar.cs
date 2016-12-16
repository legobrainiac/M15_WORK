/********************************************************************
    Copyright (C) 2016-2017 Tomás António Sanches Pinto <tomas.antonio.sp@gmail.com>
     
    This file is part of M14_14_TomásPinto_24.
    
    M14_14_TomásPinto_24 can not be copied and/or distributed without the express
    permission of Tomás António Sanches Pinto

	created:	2016/11/22
	created:	22:11:2016   10:56
	filename: 	C:\Users\legobrainiac\Documents\Visual Studio 2015\Projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24\items_ar.cs
	file path:	C:\Users\legobrainiac\Documents\Visual Studio 2015\Projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24
	file base:	items_ar
	file ext:	cs
	author:		Tomás António Sanches Pinto
	
	purpose:	Form for items
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
        string filepath = null;

        public items_ar()
        {
            InitializeComponent();
        }

        private void items_ar_Load(object sender, EventArgs e)
        {
            Update_dgv();
            //combo_box_items.DataSource = items_handler.ReadAllList();
        }

        private void btn_photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                filepath = dialog.FileName;
                try
                {
                    pb_image.Image = Image.FromFile(filepath);
                }
                catch                {
                    MessageBox.Show("Image of wrong type");
                }
                
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string description = txt_desc.Text;
            byte[] image = new byte[0];

            if (filepath == null || name == "")
            {
                MessageBox.Show("Fill all fields...");
                return;
            }

            pb_image.Image = null;
            GC.Collect();
            image = utils.ImageToArray(filepath);
            items_handler.Create(name, description, image);
            Clear();
        }

        private void Clear()
        {
            filepath = null;
            txt_desc.Text = null;
            txt_name.Text = null;
        }

        private void Update_dgv()
        {
            dgv_items.DataSource = items_handler.ReadAll();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Update_dgv();            
        }

        private void tsb_autorestart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }
    }
}
