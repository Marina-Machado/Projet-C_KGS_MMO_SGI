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

        public string Username
        {
            get
            {
                return _username;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
        }



        /*
         * Made by Shanshe Gundishvili
         * Date : 23.01.2022
         * desc : this method is here to check if the login used by user is correct using "SELECT COUNT"
         */
        public bool Login(string email, string password)
        {
            if (email != null || password != null || email != "" || password != "")
            {
                List<DataHandler> data;
                string loginQuery = "SELECT COUNT(nickname) FROM users WHERE password ='"+ password + "'AND email = '" + email + "';";


                DbConnector dbConnector = new DbConnector();

                data = dbConnector.Select(loginQuery, 1);
                if (data[0].I1 == "1")
                {
                    return true;

                }
                _username = data[0].I1;
                _email = email;
                return false;
                throw new NotImplementedException();

            }
            else
            {
                return false;
                throw new NoDataException();
            }

        }

        //bonus Register
        public void Register()
        {
            throw new NotImplementedException();
        }

        public void AddFavoriteCharacter()
        {
            throw new NotImplementedException();
        }

        public void AddFavoriteAudioVisual()
        {
            throw new NotImplementedException();
        }


    }
    class NoDataException : Exception { }
}
