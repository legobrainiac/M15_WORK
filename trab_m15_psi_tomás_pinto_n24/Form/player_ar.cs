/********************************************************************
    Copyright (C) 2016-2017 Tomás António Sanches Pinto <tomas.antonio.sp@gmail.com>
     
    This file is part of M14_14_TomásPinto_24.
    
    M14_14_TomásPinto_24 can not be copied and/or distributed without the express
    permission of Tomás António Sanches Pinto
	
    created:	2016/11/22
	created:	22:11:2016   10:56
	filename: 	C:\Users\legobrainiac\Documents\Visual Studio 2015\Projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24\player_ar.cs
	file path:	C:\Users\legobrainiac\Documents\Visual Studio 2015\Projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24
	file base:	player_ar
	file ext:	cs
	author:		Tomás António Sanches Pinto
	
	purpose:	For for players
*********************************************************************/

using System;
using System.Data;
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
            try
            {
                players_handler.Create(tb_name.Text);
            }
            catch
            {
                MessageBox.Show("You cant add an existing player!");
            }
            finally
            {
                update();
                clear();
            }
        }

        //Updates the datagridview and next id txt box
        private void update()
        {
            dgv_players.DataSource = db_handler.instance.query("select * from list_players");
            txt_nextid.Text = players_handler.NextId().ToString();
        }

        //Clears all the textboxes
        private void clear()
        {
            tb_name.Clear();
            tb_id.Clear();
            tb_name_edit.Clear();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                players_handler.Update(sel_id, tb_name_edit.Text);
            }
            catch
            {
                MessageBox.Show("You cant set the name to that of an existing player!");
            }
            finally
            {
                update();
                clear();
            }
        }

        private void dgv_players_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clear();
            DataTable tbl = dgv_players.DataSource as DataTable;
            try
            {
                sel_id = int.Parse(tbl.Rows[e.RowIndex][0].ToString());
                tb_name_edit.Text = tbl.Rows[e.RowIndex].Field<string>(1);
                tb_id.Text = sel_id.ToString();
            }
            catch { }
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
            tt.Show("ID may change if app is used by many people.", txt_nextid, 15, -35, 1000);
        }

        private void txt_nextid_MouseLeave(object sender, EventArgs e)
        {
            //tt.Dispose();
        }
    }
}
