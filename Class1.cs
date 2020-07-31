using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MovieInList
{
    class MovieProgram
    {
        #region fields                  
        private string movieTitles;
        private string catagories;
        private int starRating;
        private DateTime releaseDate;
        private bool tomatoApproved;

        #endregion

        #region Properties 
        //non static. accessible outside of this class
        public string MovieTitles
        {
            get { return movieTitles; } //retrieve value of our property through field
            set { movieTitles = value; }//set the value of the property through field
        }
        public string Catagories
        {
            get { return catagories; }
            set { catagories = value; }
        }
        public int StarRating
        {
            get { return starRating; }
            set { starRating = value; }
        }
        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }
        public bool ToSee
        {
            get { return tomatoApproved; }
            set { tomatoApproved = value; }
        } 
        // end of all properties stated
        #endregion

        #region contructors
        public MovieProgram() { } // default constructor


                                //overloaded constructor
        public MovieProgram(string _movieTitles, string _catagories, int _starRating, DateTime _releaseDate, bool _toSee) //private string = use underscore
        {
            movieTitles = _movieTitles;
            catagories = _catagories;
            starRating = _starRating;
            releaseDate = _releaseDate;
            tomatoApproved = _toSee;

        }
        #endregion

        #region Methods
        public void PrintCatagory() //print out information to console
        {



            if (tomatoApproved)
            {
                Console.WriteLine($"{movieTitles} is a great choice! That movie is a {catagories}. That movie recieved a {starRating} on SmellyTomato's.com, you can trust us we know movies. This movie released in {releaseDate} is available now for streaming or purchase at WhobuysMovies.com");
               
                
            }
            else
            {
                Console.WriteLine($"{movieTitles} is a great choice! That movie is a {catagories}. That movie recieved a {starRating} on SmellyTomato's.com, you can trust us we know movies. This movie released in {releaseDate} is available now for streaming or purchase at WhobuysMovies.com");

            }
        } 
        #endregion
    }
}