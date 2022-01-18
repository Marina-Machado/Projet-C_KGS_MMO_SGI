using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospopedia
{
    public class Actor
    {
        private string _firstname;
        private string _lastname;
        private DateTime _birthday;
        private string _birthplace;
        private string _nationality;
        private string _biography;
        private int _ranking;

        public Actor(string firstname, string lastname, DateTime birthday, string birthplace, string nationality, int ranking, string biohraphy = "")
        {
            _firstname = firstname;
            _lastname = lastname;
            _birthday = birthday;
            _birthplace = birthplace;
            _nationality = nationality;
            _biography = biohraphy;
            _ranking = ranking;
        }

        public string Firstname
        {
            get { return _firstname; }
        }

        public string Lastname
        {
            get { return _lastname; }
        }

        public DateTime Birthday
        {
            get { return _birthday; }
        }

        public string Birthplace
        {
            get { return _birthplace; }
        }

        public string Nationality
        {
            get { return _nationality; }

            set { _nationality = value; }
        }

        public string Biography
        {
            get { return _biography; }
        }
        public int Ranking
        {
            get { return _ranking; }
        }
    }
}
