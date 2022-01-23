using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospopedia
{
    
    public class AudioVisual
    {
        private string _title;
        private string _type;
        private string _studio;
        private string _director;
        private string _realisator;
        private DateTime _releaseDate;
        private string _nationality;
        private int _ranking;

        public AudioVisual(string title, string type, string studio, string director, string realisator, DateTime releaseDate, string nationality, int ranking)
        {
            _title = title;
            _type = type;
            _studio = studio;
            _director = director;
            _realisator = realisator;
            _releaseDate = releaseDate;
            _nationality = nationality;
            _ranking = ranking;
        }

        public string Title
        {
            get { return _title; }
        }

        public string Type 
        { 
            get { return _type; } 
        }

        public string Studio
        {
            get { return _studio; }
        }

        public string Director
        {
            get { return _director; }
        }

        public string Realisator
        {
            get { return _realisator; }
        }

        public DateTime ReleaseDate
        {
            get { return _releaseDate; }
        }

        public string Nationality
        {
            get { return _nationality; }
        }

        public int Ranking
        {
            get { return _ranking; }
        }
    }
}
