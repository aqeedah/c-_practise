using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__practise
{
    internal class Movie
    {
        public String title;
        public String director;
        private string rating;

        public Movie(String aTitle, String aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        public String Rating
        {
            get { return rating; }
            set { if(value == "G" || value == "PG-13" || value == "PG" || value == "R" || value == "NR")
                    {
                        rating = value;
                    }
                    else
                    {
                        rating = "NR";
                    }
                }
        }
    }
}
