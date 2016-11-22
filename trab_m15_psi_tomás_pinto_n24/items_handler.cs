/********************************************************************
	created:	2016/11/17
	created:	17:11:2016   15:50
	filename: 	c:\users\legobrainiac\documents\visual studio 2015\projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24\items_handler.cs
	file path:	c:\users\legobrainiac\documents\visual studio 2015\projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24
	file base:	items_handler
	file ext:	cs
	author:		Tomás António Sanches Pinto
	
	purpose:	Handles CRUD for table "items"
*********************************************************************/

using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace trab_m15_psi_tomás_pinto_n24
{
    //Handles CRUD for table "items"
    class items_handler
    {
        //Publics
        public int id;
        public string name;
        public string description;
        public byte[] image;
        public DataTable item_dt;

        //Constructor
        public items_handler(int id, string name, string description, byte[] image)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.image = image;
            this.item_dt = null;
        }

        public items_handler() { }

        public override string ToString()
        {
            return $"{name} - {id}";
        }

        //CRUD
        public static void Create(string name, string description, byte[] image)
        {
            string sql = @"insert into items(name,description,item_image)
                values (@name,@description,@image);";

            var command = new SqlCommand(sql, db_handler.instance.db_connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@image", image);
            command.ExecuteNonQuery();
        }

        public static void Update(int id, string name = null, string description = null, byte[] image = null)
        {
            string sql = @"update items set ";

            if (name != null)
                sql += "name = @name ";
            if (description != null)
                sql += ",description = @description ";
            if (image != null)
                sql += ",item_image = @image";

            sql += "where id = @id";

            try
            {
                var command = new SqlCommand(sql, db_handler.instance.db_connection);
                if (name != null)
                    command.Parameters.AddWithValue("@name", name);
                if (description != null)
                    command.Parameters.AddWithValue("@description", description);
                if (image != null)
                    command.Parameters.AddWithValue("@image", image);

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
            string sql = "select * from items";
            return db_handler.instance.query(sql);
        }

        //Returns all items in a list of objects as to be used in comboboxes
        public static List<items_handler> ReadAllList()
        {
            string sql = "select * from items";
            var list = new List<items_handler>();
            var item = new items_handler();
            var result = db_handler.instance.query(sql);

            foreach (DataRow obj in result.Rows)
            {
                
                item.id = obj.Field<int>(0);
                item.name = obj.Field<string>(1);
                item.description = obj.Field<string>(2);
                item.image = obj.Field<byte[]>(3);
                item.item_dt = result;
                list.Add(item);
            }

            return list;
        }

        public static items_handler Read(int id)
        {
            string sql = $"select id, name, description, item_image from items where id = {id}";

            var result = db_handler.instance.query(sql);
            var item = new items_handler();

            if (result.Rows.Count > 0)
            {
                item.id = result.Rows[0].Field<int>(0);
                item.name = result.Rows[0].Field<string>(1);
                item.description = result.Rows[0].Field<string>(2);
                item.image = result.Rows[0].Field<byte[]>(3);
                item.item_dt = result;
            }

            return item;
        }

        public static void Delete(int id)
        {
            string sql = $"delete from items where id = {id}";
            db_handler.instance.query(sql);
        }

    }
}
