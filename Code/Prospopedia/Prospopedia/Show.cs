using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospopedia
{
    public class Show : AudioVisual
    {
        private int _numberOfSeason;
        private int _numberOfEpisode;
        private int _episodeLenght;

        private string _title;

        public Show(int numberOfSeason, int numberOfEpisode, int episodeLenght, string title, string type, string studio, string director, string realisator, DateTime releaseDate, string nationality, int ranking) 
            : base(title,type,studio,director,realisator,releaseDate,nationality,ranking)
            //im not sure of this part, fix it if it seems wrong for ya
        {
            _numberOfSeason = numberOfSeason;
            _numberOfEpisode = numberOfEpisode;
            _episodeLenght = episodeLenght;
        }

        public int NumberOfSeason
        {
            get { return _numberOfSeason; }
        }

        public int NumberOfEpisode
        {
            get { return _numberOfEpisode; }
        }

        public int EpisodeLenght
        {
            get { return _episodeLenght; }
        }

        public int RankShow()
        {
            throw new NotImplementedException();
        }

    }
}
