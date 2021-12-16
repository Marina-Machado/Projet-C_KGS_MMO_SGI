using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public class User
    {
        #region private attributes
        private string _email;
        private string _nickname;
        #endregion private attributes



        #region public methodesho
        public User()
        { 

            new NotImplementedException();
        }

        public void Login(string email, string password)
        {
            throw new NotImplementedException();

        }

        public void Register(string nickname, string email, string password, string passwordRepeat)
        {
            if(password == passwordRepeat)
            {


            }
            new NotImplementedException();
        }

        public void Disconnect()
        {
            _email = null;
            _nickname = null;

        }

        public void Modify(string nickname, string email, string password, string passwordRepeat)
        {
            

        }
        #endregion public methodes

        #region private methodes

        #endregion private methodes


    }
}
