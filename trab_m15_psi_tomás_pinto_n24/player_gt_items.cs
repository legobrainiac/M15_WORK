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
    public partial class player_gt_items : Form
    {
        public player_gt_items()
        {
            InitializeComponent();
        }

        private void player_gt_items_Load(object sender, EventArgs e)
        {
            cb_item.DataSource = items_handler.ReadAllList();
            cb_players.DataSource = players_handler.ReadAllList();
        }
    }
}
