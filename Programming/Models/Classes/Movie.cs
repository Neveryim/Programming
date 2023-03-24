using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models.Enums
{
    internal class Movie
    {
        private string Title { get; set; }
        private int Duration { get; set; }

        private int Year_of_release { get; set; }

        private string Genre { get; set; }
        private double Rating { get; set; }
        public Movie(string title, int duration, int year, string genre, double rating)
        {
            Check(title, duration, year, genre, rating);

        }
        public Movie() { }
        //проверяем условия 
        private void Check(string title, int deration, int year, string genre, double rating)
        {


            Title = title;
            Duration = deration;
            Year_of_release = year;
            Genre = genre;
            if (rating > 0.0 & rating <= 10.0)
            {
                Rating = rating;
            }
            else
            {
                throw new ArgumentException(String.Format("{0} не является подходящим числом", rating),
                                    "rating");

            }

        }
        public string[] answRec()
        {
            string[] answ = { Title, Duration.ToString(), Year_of_release.ToString(), Genre, Rating.ToString() };
            return answ;
        }
        public int getReit()
        {

            return (int)Rating;
        }
    }
}
