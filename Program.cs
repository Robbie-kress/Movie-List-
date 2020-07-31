using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace MovieInList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<MovieProgram> movieList = new List<MovieProgram>();
            {

                new MovieProgram("Children of the corn", "horror", 4, DateTime.Parse("03/09/1984"), true);
                new  MovieProgram ("The Notebook", "anime", 2, DateTime.Parse("12/25/1978"), true);
                new MovieProgram("Butterfly Candle", "drama", 3, DateTime.Parse("11/11/1111"), true);
                new MovieProgram("Strangers", "scifi", 5, DateTime.Parse("09/23/2082"), true);
                new MovieProgram("I'm tired", "drama", 4, DateTime.Parse("7/30/2020"), true);
                new MovieProgram("SuperDan", "horror", 2, DateTime.Parse("04/29/2012"), true);
                new MovieProgram("Clapping", "scifi", 1, DateTime.Parse("03/21/1993"), true);
            }

            Console.WriteLine("Welcome to SmellyTomato's movie list app!");
            Console.WriteLine("\n=======================================\n");
            Console.WriteLine("What movie catagory are you interested in?");
            string movie1 = Console.ReadLine();
            
            Console.WriteLine();
            Continue();

            movieList.Add(new MovieProgram());
            
            foreach (MovieProgram movie in movieList)
            {
                
                if (movie.MovieTitles == "horror")
                {
                    movie.PrintCatagory();
                }
                else
                {

                }
                if(movie.MovieTitles == "anime")
                {
                    movie.PrintCatagory();
                }
                else
                {

                }
                if(movie.MovieTitles == "scifi")
                {
                    movie.PrintCatagory();
                }
                else
                {

                }
                if(movie.MovieTitles == "drama")
                {
                    movie.PrintCatagory();
                }
                
                
                
            }

            


        }
        public static bool Continue()
        {
            int counter = 3;

            while (counter > 0)
            {
                Console.WriteLine("Would you like to continue [y/n].");
                string input = Console.ReadLine().ToLower().Trim();

                if (input.StartsWith('y'))
                {
                    return true;
                }
                else if (input == "n")
                {
                    return false;
                }
                else
                {
                    counter--;
                    Console.WriteLine($"You have {counter} tries left");

                }

                // System.Environment.Exit(0);
            }

            Console.WriteLine("Oh no you didn't do it right!");
            return false;
        }



    }
}