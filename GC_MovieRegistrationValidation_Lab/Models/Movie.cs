
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace GC_MovieRegistrationValidation_Lab.Models
{
    public class Movie
    {
        [Key]
        [Required(ErrorMessage = "Movie ID cannot be empty. Please provide an ID.")]
        [Range(1, 100000, ErrorMessage = "Movie ID must be a positive number between 1 and 100000.")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Movie Title cannot be empty. Please provide a title.")]
        [StringLength(50, ErrorMessage = "The Movie Title entered is too long. Must be 50 characters or less.")]
        public string Title { get; set; }

        
        public string Genre { get; set; }

        public int thisYear = DateTime.Now.Year;
        [Required(ErrorMessage = "Movie must have a release year.")]
        [Range(1880,thisYear,ErrorMessage = "Movie release year must be between 1888 and 2020")]
        
        public int Year { get; set; }
        
        [Required(ErrorMessage = "Movie must have at least one actor listed.")]
        [StringLength(2000, ErrorMessage = "Too many actors listed. List must be under 2000 characters in length.")]
        public string Actors { get; set; }

        [Required(ErrorMessage = "Movie must have at least one director listed.")]
        [StringLength(1000, ErrorMessage = "Too many directors listed. List must be under 2000 characters in length.")]
        public string Directors { get; set; }

        

        //public Movie()
        //{

        //}

        //public Movie(int _iD, string _title, string _genre, int _year, string _actors, string _directors)
        //{
        //    ID = _iD;
        //    Title = _title;
        //    Genre = _genre;
        //    Year = _year;
        //    Actors = _actors;
        //    Directors = _directors;
        //}

        public List<Movie> AddToList(List<Movie> mList, Movie movie)
        {
            mList.Add(movie);
            return mList;
        }
    }
}
