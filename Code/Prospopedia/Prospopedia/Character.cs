using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospopedia
{
    public class Character
    {
        private string _firstname;
        private string _surname;
        private DateTime _birthday;
        private string _birthplace;
        private string _biography;
        private string _creators;
        private int _ranking;


        public Character(string firstname, string surname, DateTime birthday, string birthplace, string biography, string creators, int ranking) {
            _firstname = firstname;
            _surname = surname;
            _birthday = birthday;
            _birthplace = birthplace;
            _biography = biography;
            _creators = creators;
            _ranking = ranking;
        }

        public string Firstname
        {
            set
            {
                _firstname = value;
            }
            get
            {
                return _firstname;
            }
        }
        public string Surname
        {
            set
            {

                _surname = value;
            }
            get
            {
                return _surname;
            }
        }
    }
}
