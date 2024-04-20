using MRental_Model;
using MRental_DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRental_BL
{
    public class MR_BL
    {

        private MovieData movieData;
        private CustomerData customerData;

        public MR_BL()
        {
            movieData = new MovieData();
            customerData = new CustomerData();
        }

        public string RentMovie(int movieCode, Customer currentCustomer)
        {
            List<Movie> movies = movieData.GetMovies();

            Movie movieToRent = movies.Find(movie => movie.Code == movieCode);

            if (movieToRent != null)
            {
                if (!movieToRent.IsRented)
                {
                    double rentalFee = movieToRent.Price;
                    movieToRent.IsRented = true;
                    return $"Movie '{movieToRent.Title}' has been rented by {currentCustomer.Name}. Enjoy your movie! Rental Fee: Php{rentalFee}";
                }
                else
                {
                    return $"Movie '{movieToRent.Title}' is already rented.";
                }
            }
            else
            {
                return $"Movie with code {movieCode} does not exist.";
            }
        }

        public void AddMovie(Movie newMovie)
        {
            List<Movie> movies = movieData.GetMovies();
            movies.Add(newMovie);
        }
        public List<Movie> GetMovies()
        {
            return movieData.GetMovies();
        }

        public Customer RegisterCustomer(string name)
        {
            return customerData.RegisterCustomer(name);
        }


    }
}