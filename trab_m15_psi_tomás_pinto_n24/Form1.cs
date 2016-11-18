using System;
using System.Windows.Forms;
using System.IO;
using System.Data;

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
    }
}
