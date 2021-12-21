using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prospopedia;

namespace Prospopedia
{
    public class User
    {
        private string _username;
        private string _email;

        public User(string username, string email)
        {
            _username = username;
            _email = email;
        }


        public void Login(string email, string password)
        {

            List<string>[] data;
            string loginQuery = "SELECT Password FROM prospopediadb WHERE email = " + email + ";";
            if(email != null || password != null)
            {

                DbConnector dbConnector = new DbConnector();

                data = dbConnector.Select(loginQuery);
                if(data[0][0] == password)
                {

                    throw new NotImplementedException();

                }
                
            }
            else
            {
                throw new NoDataException();
            }

        }


    }
    class NoDataException : Exception { }
}
