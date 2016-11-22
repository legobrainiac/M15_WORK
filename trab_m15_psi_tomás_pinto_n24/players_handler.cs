/********************************************************************
	created:	2016/11/17
	created:	17:11:2016   16:53
	filename: 	C:\Users\legobrainiac\documents\visual studio 2015\Projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24\players_handler.cs
	file path:	C:\Users\legobrainiac\documents\visual studio 2015\Projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24
	file base:	players_handler
	file ext:	cs
	author:		Tomás António Sanches Pinto
	
	purpose:	Handles CRUD for table "players"
*********************************************************************/

using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace trab_m15_psi_tomás_pinto_n24
{
    //Handles CRUD for table "players"
    class players_handler
    {
        //Publics
        public int id;
        public string name;
        public DataTable player_dt;

        public players_handler(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public players_handler() { }

        //CRUD
        public static void Create(string name)
        {
            string sql = @"insert into players(name)
                values (@name);";

            var command = new SqlCommand(sql, db_handler.instance.db_connection);
            command.Parameters.AddWithValue("@name", name);
            command.ExecuteNonQuery();
        }

        public static DataTable ReadAll()
        {
            string sql = "select * from players";
            return db_handler.instance.query(sql);
        }

        public static players_handler Read(int id)
        {
            string sql = $"select * from  players where id = {id}";

            var result = db_handler.instance.query(sql);
            var player = new players_handler();

            if (result.Rows.Count > 0)
            {
                player.name = result.Rows[0].Field<string>(0);
                player.player_dt = result;
            }

            return player;
        }

        public static void Update(int id, string name)
        {
            string sql = "update players set name = @name where id = @id";

            try
            {
                var command = new SqlCommand(sql, db_handler.instance.db_connection);
                    command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void Delete(int id)
        {
            string sql = $"delete from players where id = {id}";
            db_handler.instance.query(sql);
        }

        public static int NextId()
        {
            string sql = $"select (ident_current('players') + 1) as i";
            var tbl = db_handler.instance.query(sql);
            return int.Parse(tbl.Rows[0][0].ToString());
        }
    }
}
