using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;

namespace EntryManager.Models
{
    class MainEntryModel
    {
        private MySqlConnection connection;
        private string server;
        private string port;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public MainEntryModel(){
            Init();
        }

        private void Init()
        {
            server = "localhost"; //Local Host
            port = "3306";
            database = "wpftestschema";
            uid = "root";
            password = "!!@cCent97_14";

            string ConnectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(ConnectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                MessageBox.Show("Open Connection Successfull");
                return true;
            }
            catch(MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot Connect To Server");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid Username/Password");
                        break;
                    default:
                        MessageBox.Show("Unknow Error. Connection Not Established.");
                        break;
                }
                return false;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                MessageBox.Show("Close Connection Successfull");
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

    }
}
