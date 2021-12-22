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

        public User(string username = null, string email = null)
        {
            _username = username;
            _email = email;
        }




        public bool Login(string email, string password)
        {

            List<string>[] data;
            string loginQuery = "SELECT password, username FROM prospopediadb WHERE email = " + email + ";";
            if(email != null || password != null)
            {

                DbConnector dbConnector = new DbConnector();

                data = dbConnector.Select(loginQuery);
                if(data[0][0] == password)
                {
                    _username = data[0][1];
                    _email = email;
                    return true;
                    throw new NotImplementedException();

                }
                return false;
                
            }
            else
            {
                return false;
                throw new NoDataException();
            }

        }


    }
    class NoDataException : Exception { }
}
