/********************************************************************
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
            string name = Directory.GetCurrentDirectory() + "\\m15_trab.mdf";

            Clipboard.SetText(utils.ReadFile(Directory.GetCurrentDirectory() + "\\trab_m15.sql"));

            if (!File.Exists(name))
                db_handler.create_db(name);
        }

        private void listRecipePerItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "select * from list_items_recipe order by id_craftable;";
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
    }
}
