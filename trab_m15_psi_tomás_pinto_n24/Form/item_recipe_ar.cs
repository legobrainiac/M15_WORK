using System;
using System.Collections.Generic;
using System.Windows.Forms;

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

        //Get Selected ids from the checked list box
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

        //Tick the items with the id's in the array 
        private void CheckRecipeIds(int[] ids)
        {
            ClearSelection();
            for (int i = 0; i < ids.Length; i++)
            {
                for (int x = 0; x < clb_recipe_items.Items.Count; x++)
                {
                    items_handler item = (items_handler)clb_recipe_items.Items[x];
                    if (item.id == ids[i])
                        clb_recipe_items.SetItemChecked(x, true);
                }
            }
        }

        private void ClearSelection()
        {
            for (int x = 0; x < clb_recipe_items.Items.Count; x++)
            {
                clb_recipe_items.SetItemChecked(x, false);
            }
        }

        private void lb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            items_handler item = (items_handler)lb_items.Items[lb_items.SelectedIndex];
            int[] existing_items_recipe = items_handler.RecipeIds(item.id);
            CheckRecipeIds(existing_items_recipe);
        }
    }
}
