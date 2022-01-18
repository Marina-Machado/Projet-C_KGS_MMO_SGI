using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prospopedia;

namespace Prospopedia
{
    public class Movie : AudioVisual
    {
        private int _movieLenght;

        public Movie(int movieLenght, string title, string type, string studio, string director, string realisator, DateTime releaseDate, string nationality, int ranking)
            : base(title, type, studio, director, realisator, releaseDate, nationality, ranking)
        //im not sure of this part either (heritage toussa), fix it if it seems wrong for ya
        {
            _movieLenght = movieLenght;
        }

        public int MovieLenght
        {
            get { return _movieLenght; }
        }

        public int RankMovie()
        {
            throw new NotImplementedException();
        }
    }
}
