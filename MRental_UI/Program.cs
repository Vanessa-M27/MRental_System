using MRental_BL;
using MRental_Model;
namespace MRental_UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MR_BL mrental = new MR_BL();
            MovieRentalUI rentalUI = new MovieRentalUI(mrental);
            rentalUI.Run();
        }

        public class MovieRentalUI
        {
            private MR_BL mrental;

            public MovieRentalUI(MR_BL service)
            {
                mrental = service;
            }

            public void Run()
            {
                Customer currentCustomer = null;

                Console.WriteLine("Welcome to Movie Rental System!");
                Console.WriteLine("----------------------------------");

                while (true)
                {
                    if (currentCustomer == null)
                    {
                        Console.WriteLine("\n1. Register");
                        Console.WriteLine("2. Exit");
                        Console.Write("Enter your choice: ");
                        string choice = Console.ReadLine();
                        Console.WriteLine("----------------------------------");
                        switch (choice)
                        {
                            case "1":
                                Console.Write("Enter your name: ");
                                string name = Console.ReadLine();
                                currentCustomer = mrental.RegisterCustomer(name);
                                Console.WriteLine("----------------------------------");
                                Console.WriteLine("Registration successful!");
                                break;
                            case "2":
                                Console.WriteLine("----------------------------------");
                                Console.WriteLine("Thank you for using Movie Rental System!");
                                return;
                            default:
                                Console.WriteLine("----------------------------------");
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nHello, " + currentCustomer.Name + "!");

                        Console.WriteLine("\nAvailable Movies:");
                        DisplayMovies(mrental.GetMovies());
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                        Console.Write("Enter the Code of the movie you want to rent (0 to exit): ");
                        int movieCode = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                        if (movieCode == 0)
                        {
                            currentCustomer = null;
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("You have been logged out.");
                        }
                        else
                        {
                            string message = mrental.RentMovie(movieCode, currentCustomer);
                            Console.WriteLine(message);
                        }
                    }
                }
            }

            public void DisplayMovies(List<Movie> movies)
            {
                foreach (var movie in movies)
                {
                    Console.WriteLine($"Code: {movie.Code}, Title: {movie.Title}, Genre: {movie.Genre}, Price: Php{movie.Price}");
                }
            }

        }


    }
}




