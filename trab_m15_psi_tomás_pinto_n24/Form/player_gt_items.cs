/********************************************************************
    Copyright (C) 2016-2017 Tomás António Sanches Pinto <tomas.antonio.sp@gmail.com>
     
    This file is part of M14_14_TomásPinto_24.
    
    M14_14_TomásPinto_24 can not be copied and/or distributed without the express
    permission of Tomás António Sanches Pinto

	created:	2016/11/25
	created:	25:11:2016   17:09
	filename: 	c:\users\legobrainiac\documents\visual studio 2015\projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24\player_gt_items.cs
	file path:	c:\users\legobrainiac\documents\visual studio 2015\projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24
	file base:	player_gt_items
	file ext:	cs
	author:		Tomás António Sanches Pinto
	
	purpose:	For for giving and taking items from players
*********************************************************************/

using System;
using System.Windows.Forms;

namespace trab_m15_psi_tomás_pinto_n24
{
    public partial class player_gt_items : Form
    {
        public player_gt_items()
        {
            InitializeComponent();
        }

        private void player_gt_items_Load(object sender, EventArgs e)
        {
            txt_count.Text = "1";
            cb_item.DataSource = items_handler.ReadAllList();
            cb_players.DataSource = players_handler.ReadAllList();
        }

        private void btn_give_Click(object sender, EventArgs e)
        {
            int item_count;
            try
            {
                 item_count = int.Parse(txt_count.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid amount...");
                return;
            }

            players_handler p_handler = (players_handler)cb_players.Items[cb_players.SelectedIndex];
            items_handler i_handler = (items_handler)cb_item.Items[cb_item.SelectedIndex];
            inventories_handler.Give(p_handler.id, i_handler.id, item_count);
            clear_frm();
        }

        private void clear_frm()
        {
            txt_count.Clear();
        }
    }
}
