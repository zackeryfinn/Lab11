using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movies> movieList = new List<Movies>();
            Movies movie1 = new Movies() { title = "Full Metal Jacket", category = 4 };
            Movies movie2 = new Movies() { title = "36th Chamber of Shaolin", category = 2 };
            Movies movie3 = new Movies() { title = "Rushmore", category = 3 };
            Movies movie4 = new Movies() { title = "Eternal Sunshine of the Spotless Mind", category = 3 };
            Movies movie5 = new Movies() { title = "Life of Brian", category = 3 };
            Movies movie6 = new Movies() { title = "Jurassic Park", category = 2 };
            Movies movie7 = new Movies() { title = "Crimes and Misdemeanors", category = 4 };
            Movies movie8 = new Movies() { title = "Snow White", category = 1 };
            Movies movie9 = new Movies() { title = "Tampopo", category = 3 };
            Movies movie10 = new Movies() { title = "The Triplets of Belleville", category = 1 };
            movieList.Add(movie1);
            movieList.Add(movie2);
            movieList.Add(movie3);
            movieList.Add(movie4);
            movieList.Add(movie5);
            movieList.Add(movie6);
            movieList.Add(movie7);
            movieList.Add(movie8);
            movieList.Add(movie9);
            movieList.Add(movie10);
            bool repeatMain = true;
            while (repeatMain)
            {
                //general introductions, select category
                Welcome mainGreeting = new Welcome();
                mainGreeting.Hello();
                mainGreeting.CatInfo();
                //geting the list for categories
                var catSelect = mainGreeting.GetCategoryInput();
                Console.WriteLine();
                //printing it out
                Category writeOut = new Category();
                writeOut.WriteOut(catSelect, movieList);
                repeatMain = ExitProgram();
            }
            Console.WriteLine("Have a great day. Come again soon!");
            Console.ReadKey();
            
        }
        public static bool ExitProgram()
        {
            //start area to go again whole package
            bool repeatMain = true;
            Console.WriteLine("Would you like to look at other categories?");
            Console.Write("Please type \"y\" to go again or any other key to exit: ");
            string repeatInputB = Console.ReadLine();
            Console.WriteLine();
            if (!repeatInputB.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                repeatMain = false;
            }
            return repeatMain;
        }

    }
}