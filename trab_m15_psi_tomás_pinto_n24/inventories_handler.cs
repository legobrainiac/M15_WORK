/********************************************************************
	created:	2016/11/17
	created:	17:11:2016   15:49
	filename: 	C:\Users\legobrainiac\documents\visual studio 2015\Projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24\inventories_handler.cs
	file path:	C:\Users\legobrainiac\documents\visual studio 2015\Projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24
	file base:	inventories_handler
	file ext:	cs
	author:		Tomás António Sanches Pinto
	
	purpose:	Handles CRUD for table "inventories"
*********************************************************************/

using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace trab_m15_psi_tomás_pinto_n24
{
    //Handles CRUD for table "inventories"
    class inventories_handler
    {
        //publics
        public int id;
        public int id_player;
        public int id_item;
        public int item_count;
        public DataTable inv_dt;

        //Constructors
        public inventories_handler(int id, int id_player, int id_item, int item_count)
        {
            this.id = id;
            this.id_player = id_player;
            this.id_item = id_item;
            this.item_count = item_count;
            this.inv_dt = null;
        }

        public inventories_handler() { }

        //CRUD
        public static void Create(int id_player, int id_item, int item_count)
        {
            string sql = @"insert into inventories(id_player, id_item, item_count)
                values (@id_player,@id_item,@item_count);";

            var command = new SqlCommand(sql, db_handler.instance.db_connection);
            command.Parameters.AddWithValue("@id_player", id_player);
            command.Parameters.AddWithValue("@id_item", id_item);
            command.Parameters.AddWithValue("@item_count", item_count);
            command.ExecuteNonQuery();
        }

        /*
         * id_player, id_item and item_count default to -1 if not to be edited
         */
        public static void Update(int id, int id_player = -1, int id_item = -1, int item_count = -1)
        {
            string sql = @"update inventories set ";

            if (id_player != -1)
                sql += "id_player = @id_player ";
            if (id_item != -1)
                sql += ",id_item = @id_item ";
            if (item_count != -1)
                sql += ",item_count = @item_count ";

            sql += "where id = @id";

            try
            {
                var command = new SqlCommand(sql, db_handler.instance.db_connection);
                if (id_player != -1)
                    command.Parameters.AddWithValue("@id_player", id_player);
                if (id_item != -1)
                    command.Parameters.AddWithValue("@id_item", id_item);
                if (item_count != -1)
                    command.Parameters.AddWithValue("@item_count", item_count);

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
            string sql = "select * from inventories";
            return db_handler.instance.query(sql);
        }

        public static inventories_handler Read(int id)
        {
            string sql = $"select id, id_player, id_item, item_count from inventories where id = {id}";

            var result = db_handler.instance.query(sql);
            var inv_item = new inventories_handler();

            if (result.Rows.Count > 0)
            {
                inv_item.id = result.Rows[0].Field<int>(0);
                inv_item.id_player = result.Rows[0].Field<int>(1);
                inv_item.id_item = result.Rows[0].Field<int>(2);
                inv_item.item_count = result.Rows[0].Field<int>(3);
                inv_item.inv_dt = result;
            }

            return inv_item;
        }

        public static void Delete(int id)
        {
            string sql = $"delete from inventories where id = {id}";
            db_handler.instance.query(sql);
        }

        /*
         *  Give the correct amount of an item of the specified id to a player of a specified id. 
         *  It also checks if the player already has that item as to not create redundant data in the database.
         */
        public static void Give(int id_player, int id_item, int item_count)
        {
            string sql =
                $@"
                    if exists(select * from inventories where id_player = {id_player} and id_item = {id_item})
                        update inventories set item_count = item_count + {item_count} where id_player = {id_player} and id_item = {id_item}
                    else
                        insert into inventories(id_player, id_item, item_count) values ({id_player},{id_item},{item_count});
                        
                ";

            db_handler.instance.query(sql);
        }

    }
}
