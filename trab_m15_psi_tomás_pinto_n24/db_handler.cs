using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace trab_m15_psi_tomás_pinto_n24
{
    class db_handler
    {
        //Privates
        private string connection_string;

        //publics
        SqlConnection db_connection;

        //Singleton
        private static db_handler db;

        public static db_handler instance
        {
            get
            {
                if (db == null)
                    db = new db_handler();

                return db;
            }
        }

        //Constructor
        public db_handler()
        {
            connection_string = ConfigurationManager.ConnectionStrings["sql"].ToString();
            db_connection = new SqlConnection(connection_string);
            db_connection.Open();

        }

        //Destructor
        ~db_handler()
        {
            try
            {
                db_connection.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //DB Creater
        public static void create_db(string name)
        {
            string db_name = System.IO.Path.GetFileNameWithoutExtension(name);
            var server_connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30");
            server_connection.Open();

            string str_sql = $"CREATE DATABASE {db_name} ON PRIMARY (NAME={db_name}, FILENAME='{name}' )";
            var command = new SqlCommand(str_sql, server_connection);
            command.ExecuteNonQuery();

            //Create tables
            server_connection = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={name};Integrated Security=True;Connect Timeout=30");
            server_connection.Open();

            str_sql = @"
                        create table items
                        (
	                        id int identity primary key,
	                        name varchar(50) unique not null,
	                        description varchar(140) default '...',
	                        item_image image,

                        )

                        create table items_recipe
                        (
	                        id int identity primary key,
	                        id_craftable int references items(id),
	                        id_crafting_item int references items(id),
                        )

                        create table players
                        (
	                        id int identity primary key,
	                        name varchar(50) unique not null,
                        )

                        create table inventories
                        (
	                        id int identity primary key,
	                        id_player int not null references players(id),
	                        id_item int not null references items(id),
	                        item_count int not null default 0 check(item_count >= 0),
                        )

                        create index idx_items_name on items(name);
                        create index idx_players_name on players(name);
                        ";
            command = new SqlCommand(str_sql, server_connection);
            command.ExecuteNonQuery();
        }

        //Simple query to the data base
        public DataTable query(string sql)
        {
            var command = new SqlCommand(sql, db_connection);
            DataTable table = new DataTable();

            SqlDataReader reader = command.ExecuteReader();
            table.Load(reader);

            return table;
        }

    }
}
