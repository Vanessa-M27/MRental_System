using MRental_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRental_DL
{
    public class MovieData
    {
        List<Movie> movies = new List<Movie>();

        public MovieData()
        {
            MovieInfo();
        }
        public void MovieInfo()
        {
            Movie movie1 = new Movie
            {
                Code = 101,
                Title = "Parasyte : The Grey",
                Genre = "Sci-fi Action Horror",
                Price = 480.00,
               
            };
            Movie movie2 = new Movie
            {
               Code = 102,
               Title = "Parasyte : The Maxim",
               Genre = "Sci-fi Action Horror",
               Price = 450.00,
               
            };
            Movie movie3 = new Movie
            {
                Code = 103,
                Title = "Bar Boys",
                Genre = "Drama",
                Price = 400.00,
                
            };
            Movie movie4 = new Movie 
            { 
                Code = 104,
                Title= "Barbie",
                Genre = "Fantasy",
                Price = 380.00,
              
            };
            Movie movie5 = new Movie 
            { 
                Code = 105,
                Title = "One Piece: The Movie",
                Genre = " Adventure",
                Price = 350.00,
                
            };
            movies.Add(movie1);
            movies.Add(movie2);
            movies.Add(movie3);
            movies.Add(movie4);
            movies.Add(movie5);
        }
        public List<Movie> GetMovies()
        {
            return movies;
        }


    }
}
