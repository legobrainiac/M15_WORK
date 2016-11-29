﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace trab_m15_psi_tomás_pinto_n24
{
    public partial class item_recipe_ar : Form
    {
        public item_recipe_ar()
        {
            InitializeComponent();
        }

        private void item_recipe_ar_Load(object sender, EventArgs e)
        {
            lb_items.DataSource = items_handler.ReadAllList();
            clb_recipe_items.DataSource = items_handler.ReadAllList();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int[] r = GetRecipeIds();
            items_handler item = (items_handler)lb_items.Items[lb_items.SelectedIndex];
            int selected_id = item.id;
            items_recipes_handler.AddRecipe(selected_id, r);
        }

        private int[] GetRecipeIds()
        {
            List<int> recipe_list = new List<int>();

            for (int i = 0; i < clb_recipe_items.Items.Count; i++)
            {
                if (clb_recipe_items.GetItemChecked(i) == true)
                {
                    items_handler item = (items_handler)clb_recipe_items.Items[i];
                    recipe_list.Add(item.id);
                }
            }

            return recipe_list.ToArray();
        }
    }
}
