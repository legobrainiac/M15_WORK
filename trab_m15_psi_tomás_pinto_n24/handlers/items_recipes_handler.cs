/********************************************************************
    Copyright (C) 2016-2017 Tomás António Sanches Pinto <tomas.antonio.sp@gmail.com>
     
    This file is part of M14_14_TomásPinto_24.
    
    M14_14_TomásPinto_24 can not be copied and/or distributed without the express
    permission of Tomás António Sanches Pinto

	created:	2016/11/17
	created:	17:11:2016   17:26
	filename: 	C:\Users\legobrainiac\documents\visual studio 2015\Projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24\items_recipes_handler.cs
	file path:	C:\Users\legobrainiac\documents\visual studio 2015\Projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24
	file base:	items_recipes_handler
	file ext:	cs
	author:		Tomás António Sanches Pinto
	
	purpose:	Handles CRUD for table "items_recipes"
*********************************************************************/

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace trab_m15_psi_tomás_pinto_n24
{
    //Handles CRUD for table "items_recipes"
    class items_recipes_handler
    {
        public int id;
        public int id_craftable;
        public int id_crafting_item;
        public DataTable item_recipe_dt;

        public items_recipes_handler(int id, int id_craftable, int id_crafting_item)
        {
            this.id = id;
            this.id_craftable = id_craftable;
            this.id_crafting_item = id_crafting_item;
            this.item_recipe_dt = null;
        }

        public items_recipes_handler() { }

        public static void Create(int id_craftable, int id_crafting_item)
        {
            string sql = @"insert into items_recipe(id_craftable, id_crafting_item)
                values (@id_craftable,@id_crafting_item);";

            var command = new SqlCommand(sql, db_handler.instance.db_connection);
            command.Parameters.AddWithValue("@id_craftable", id_craftable);
            command.Parameters.AddWithValue("@id_crafting_item", id_crafting_item);
            command.ExecuteNonQuery();
        }

        /*
         * id_craftable and id_crafting_item default to -1 if not to be edited
         */
        public static void Update(int id, int id_craftable = -1, int id_crafting_item = -1)
        {
            string sql = @"update items_recipe set ";

            if (id_craftable != -1)
                sql += "id_craftable = @id_craftable ";
            if (id_crafting_item != -1)
                sql += ",id_crafting_item = @id_crafting_item ";

            sql += "where id = @id";

            try
            {
                var command = new SqlCommand(sql, db_handler.instance.db_connection);
                if (id_craftable != -1)
                    command.Parameters.AddWithValue("@id_craftable", id_craftable);
                if (id_crafting_item != -1)
                    command.Parameters.AddWithValue("@id_crafting_item", id_crafting_item);

                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static DataTable ReadAll()
        {
            string sql = "select * from items_recipe";
            return db_handler.instance.query(sql);
        }

        public static items_recipes_handler Read(int id)
        {
            string sql = $"select id, id_craftable, id_crafting_item from items_recipe where id = {id}";

            var result = db_handler.instance.query(sql);
            var item_recipe = new items_recipes_handler();

            if (result.Rows.Count > 0)
            {
                item_recipe.id = result.Rows[0].Field<int>(0);
                item_recipe.id_craftable = result.Rows[0].Field<int>(1);
                item_recipe.id_crafting_item = result.Rows[0].Field<int>(2);
                item_recipe.item_recipe_dt = result;
            }

            return item_recipe;
        }

        //To add/change a recipe it will try to delete the old one and add the new one
        public static void AddRecipe(int craftable, int[] crafting_items)
        {
            DeleteRecipe(craftable);
            for (int i = 0; i < crafting_items.Length; ++i)
                Create(craftable, crafting_items[i]);
        }

        public static List<items_recipes_handler> ReadAllList()
        {
            string sql = "select * from items_recipe";
            var list = new List<items_recipes_handler>();
            var item = new items_recipes_handler();
            var result = db_handler.instance.query(sql);

            foreach (DataRow obj in result.Rows)
            {
                item = new items_recipes_handler();
                item.id = obj.Field<int>(0);
                item.id_craftable = obj.Field<int>(1);
                item.id_crafting_item = obj.Field<int>(2);
                list.Add(item);
            }

            return list;
        }

        public static void DeleteRecipe(int item_id)
        {
            string sql = $"delete from items_recipe where id_craftable = {item_id}";
            db_handler.instance.query(sql);
        }
    }
}
