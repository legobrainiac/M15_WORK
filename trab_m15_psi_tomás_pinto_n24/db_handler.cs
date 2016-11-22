/********************************************************************
	created:	2016/11/17
	created:	17:11:2016   16:32
	filename: 	c:\users\legobrainiac\documents\visual studio 2015\projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24\db_handler.cs
	file path:	c:\users\legobrainiac\documents\visual studio 2015\projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24
	file base:	db_handler
	file ext:	cs
	author:		Tomás António Sanches Pinto
	
	purpose:	Control connections to the database
*********************************************************************/

using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace trab_m15_psi_tomás_pinto_n24
{
    class db_handler
    {
        //Privates
        private string connection_string;

        //publics
        public SqlConnection db_connection;

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
            string name = Directory.GetCurrentDirectory() + "\\m15_trab.mdf";
            connection_string = $"Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = {name}; Integrated Security = True; Connect Timeout = 30";
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

        public void CloseConnection()
        {
            try
            {
                db_connection.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Could not close connection...");
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

            instance.query("create view list_items as (select * from items);");
            instance.query("create view list_items_recipe as (select * from items_recipe);");
            instance.query("create view list_players as (select * from players);");
            instance.query("create view list_inventories_items as (select * from inventories);");

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
