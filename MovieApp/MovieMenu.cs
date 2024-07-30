using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    public class MovieMenu
    {
        MovieMenu menu = new MovieMenu();
        public static void StartMenu()
        {
            bool continueProgram = true;

            while (continueProgram)
            {
                Console.Clear();
                Console.WriteLine("Movie Management Menu:");
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. Delete Movie");
                Console.WriteLine("3. Display Movies");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();
                MovieManager movieManager=new MovieManager();
                switch (choice)
                {
                    case "1":
                        MovieManager.AddMovie();
                        break;
                    case "2":
                        MovieManager.DeleteMovie();
                        break;
                    case "3":
                        MovieManager.DisplayMovies();
                        break;
                    case "4":
                        continueProgram = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                if (continueProgram)
                {
                    Console.Write("Do you want to continue? (y/n): ");
                    string continueChoice = Console.ReadLine();
                    continueProgram = continueChoice.Equals("y", StringComparison.OrdinalIgnoreCase);
                }
            }
        }
    }
}


