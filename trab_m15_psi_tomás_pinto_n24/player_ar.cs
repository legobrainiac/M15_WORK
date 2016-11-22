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
    public partial class player_ar : Form
    {
        int sel_id;
        ToolTip tt;

        public player_ar()
        {
            InitializeComponent();
        }

        private void player_ar_Load(object sender, EventArgs e)
        {
            update();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            players_handler.Create(tb_name.Text);
            update();
        }

        private void update()
        {
            dgv_players.DataSource = db_handler.instance.query("select * from list_players");
            txt_nextid.Text = players_handler.NextId().ToString();
        }

        private void clear()
        {
            tb_name.Clear();
            tb_id.Clear();
            tb_name_edit.Clear();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            players_handler.Update(sel_id, tb_name_edit.Text);
            clear();
            update();
        }

        private void dgv_players_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clear();
            DataTable tbl = dgv_players.DataSource as DataTable;
            sel_id = int.Parse(tbl.Rows[e.RowIndex][0].ToString());

            tb_name_edit.Text = tbl.Rows[e.RowIndex].Field<string>(1);
            tb_id.Text = sel_id.ToString();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            players_handler.Delete(sel_id);
            clear();
            update();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            clear();
            update();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txt_nextid_MouseHover(object sender, EventArgs e)
        {
            tt = new ToolTip();
            tt.IsBalloon = true;
            tt.Show("ID may change if app is used by many people.", txt_nextid, 15, -35,1000);
        }

        private void txt_nextid_MouseLeave(object sender, EventArgs e)
        {
            //tt.Dispose();
        }
    }
}
