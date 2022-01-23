using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Prospopedia
{
    public class DbConnector
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DbConnector()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            string connectionString;
            server = "127.0.0.1";
            database = "Prospopediadb";
            uid = "Prospopedia";
            password = "Pa$$w0rd";
            connectionString = "SERVER=" + server + ";" + "Port = 3306;" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "pwd=" + password + "; SslMode = Required";
            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        new NoConnectionException();
                        break;

                    case 1045:
                        new WrongLoginException();
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                new NoConnectionException();
                return false;
            }
        }

        //Insert statement
        public void Insert(string query)
        {
            //string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update(string query)
        {
            //string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete(string query)
        {
            //string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();

            }
        }


        //Select statement
        public List<DataHandler> Select(string query, int nOfColumns)
        {
            //query = "SELECT * FROM images";

            //Create a list to store the result


            DataTable dt = new();
            List<DataHandler> list = new();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                dt.Load(cmd.ExecuteReader());

                //Read the data and store them in the list

                foreach (DataRow row in dt.Rows)
                {
                    DataHandler dth = new();
                    if(nOfColumns >= 1)dth.I1 = row[0].ToString() + "";
                    if (nOfColumns >= 2) dth.I2 = row[1].ToString() + "";
                    if (nOfColumns >= 3) dth.I3 = row[2].ToString() + "";
                    if (nOfColumns >= 4) dth.I4 = row[3].ToString() + "";
                    if (nOfColumns >= 5) dth.I5 = row[4].ToString() + "";
                    if (nOfColumns >= 6) dth.I6 = row[5].ToString() + "";
                    if (nOfColumns >= 7) dth.I7 = row[6].ToString() + "";
                    if (nOfColumns >= 8) dth.I8 = row[7].ToString() + "";
                    if (nOfColumns >= 9) dth.I9 = row[8].ToString() + "";
                    if (nOfColumns >= 10) dth.I10 = row[9].ToString() + "";
                    if (nOfColumns >= 11) dth.I11 = row[10].ToString() + "";
                    if (nOfColumns >= 12) dth.I12 = row[11].ToString() + "";
                    if (nOfColumns >= 13) dth.I13 = row[12].ToString() + "";

                    list.Add(dth);
                }





                //close Data Reader

                //close Connection
                this.CloseConnection();
                return list;
                //return list to be displayed
            }
            else
            {
                return list;
            }
        }

        //Count statement
        public int Count(string query)
        {
            //string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

    }

    public class DbException : Exception { }
    public class NoConnectionException : DbException { }
    public class WrongLoginException : DbException { }
}
