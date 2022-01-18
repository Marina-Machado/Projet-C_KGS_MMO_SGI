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


        public Character(string firstname, int ranking, string surname = "", DateTime birthday = new DateTime(), string birthplace = "", string biography = "", string creators = "") {
            _firstname = firstname;
            _surname = surname;
            _birthday = birthday;
            _birthplace = birthplace;
            _biography = biography;
            _creators = creators;
            _ranking = ranking;

            List<string> data;
            string getCharacterQuery = "SELECT firstname FROM characters";

            DbConnector dbConnector = new DbConnector();
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

        public DateTime Birthday
        {
            set
            {
                _birthday = value;
            }
            get
            {
                return _birthday;
            }
        }

        public int Ranking
        {

            get
            {
                return _ranking;
            }
        }

        public string Birthplace
        {
            set
            {
                _birthplace = value;
            }
            get
            {
                return _birthplace;
            }
        }

        public string Biograpgy
        {

            get
            {
                return _biography;
            }
        }

        public string Creators
        {

            get
            {
                return _creators;
            }
        }

        public int RankCharacter()
        {
            throw new NotImplementedException();
        }


    }
}
