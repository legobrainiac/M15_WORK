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
    public partial class recipe_tree_view : Form
    {
        public recipe_tree_view()
        {
            InitializeComponent();
        }

        private void recipe_tree_view_Load(object sender, EventArgs e)
        {
            DataTable tbl = db_handler.instance.query("select tbl1.name, tbl2.name from items_recipe inner join items tbl1 on tbl1.id=items_recipe.id_craftable inner join items tbl2 on tbl2.id = items_recipe.id_crafting_item");

            foreach (DataRow item in tbl.Rows)
            {
                List<TreeNode> tn = new List<TreeNode>();

                if (!CheckNode(ref tree_view, item.Field<string>(0)))
                {
                    foreach (DataRow item_c in tbl.Rows)
                    {
                        if (item.Field<string>(0) == item_c.Field<string>(0))
                        {
                            tn.Add(new TreeNode(item_c.Field<string>(1)));
                        }
                    }
                    TreeNode node = new TreeNode(item.Field<string>(0),tn.ToArray());
                    tree_view.Nodes.Add(node);
                }
            }

            tree_view.ExpandAll();
        }

        //Check if tree view contain node with name x
        private bool CheckNode(ref TreeView view, string key)
        {
            foreach (TreeNode item in view.Nodes)
                if (item.Text == key)
                    return true;

            return false;
        }
    }
}
