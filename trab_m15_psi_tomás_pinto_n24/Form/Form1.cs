﻿/********************************************************************
    Copyright (C) 2016-2017 Tomás António Sanches Pinto <tomas.antonio.sp@gmail.com>
     
    This file is part of M14_14_TomásPinto_24.
    
    M14_14_TomásPinto_24 can not be copied and/or distributed without the express
    permission of Tomás António Sanches Pinto	

	created:	2016/11/22
	created:	22:11:2016   10:55
	filename: 	c:\users\legobrainiac\documents\visual studio 2015\projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24\form1.cs
	file path:	c:\users\legobrainiac\documents\visual studio 2015\projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24
	file base:	form1
	file ext:	cs
	author:		Tomás António Sanches Pinto
	
	purpose:	Main form
*********************************************************************/

using System;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Drawing;

namespace trab_m15_psi_tomás_pinto_n24
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Creates database in the executable directory
            string name = Directory.GetCurrentDirectory() + db_handler.name;

            Clipboard.SetText(name);

            if (File.Exists(name))
                return;
            db_handler.create_db(name);
        }

        private void listRecipePerItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            string sql = "select tbl1.name as Item, tbl2.name as [Crafting Item] from items_recipe inner join items tbl1 on tbl1.id=items_recipe.id_craftable inner join items tbl2 on tbl2.id = items_recipe.id_crafting_item";
            dgv_main.DataSource = db_handler.instance.query(sql);
        }

        private void listItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "select * from list_items;";
            dgv_main.DataSource = db_handler.instance.query(sql);
        }

        private void listPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "select * from list_players;";
            dgv_main.DataSource = db_handler.instance.query(sql);
        }

        private void removePlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player_ar ar = new player_ar();
            ar.Show();
        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            db_handler.instance.CloseConnection();
        }

        private void listInventoryPerPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "select * from list_inventories_items";
            dgv_main.DataSource = db_handler.instance.query(sql);
        }

        private void addNewItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item_ar_form = new items_ar();

            item_ar_form.Show();
        }

        private void giveTakeItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var player_gt_form = new player_gt_items();
            player_gt_form.Show();
        }

        private void addRecipeForItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var items_ar_recipe = new item_recipe_ar();
            items_ar_recipe.Show();
        }

        private void listItemsTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new recipe_tree_view();
            frm.Show();
        }

        //Found in http://stackoverflow.com/questions/561174/printing-a-net-datagridview
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = printDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                printDocument1.Print();
            }
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(dgv_main.Width, dgv_main.Height);
            dgv_main.DrawToBitmap(bm, new Rectangle(0, 0, dgv_main.Width, dgv_main.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void listFullItemCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "select items.name as [Name], sum(inventories.item_count) as [Amount] from inventories inner join items on items.id = inventories.id_item group by items.name";
            dgv_main.DataSource = db_handler.instance.query(sql);
        }
    }
}
