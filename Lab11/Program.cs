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
            Movies movie11 = new Movies() { title = "Lord of the Rings", category = 2 };
            Movies movie12 = new Movies() { title = "Pulp Fiction", category = 4 };
            Movies movie13 = new Movies() { title = "The Silence of the Lambs", category = 4 };
            Movies movie14 = new Movies() { title = "Back to the Future", category = 3 };
            Movies movie15 = new Movies() { title = "Rear Window", category = 4 };
            Movies movie16 = new Movies() { title = "Aladdin", category = 1 };
            Movies movie17 = new Movies() { title = "The Lion King", category = 1 };
            Movies movie18 = new Movies() { title = "Apocalypse Now", category = 4 };
            Movies movie19 = new Movies() { title = "Alien", category = 2 };
            Movies movie20 = new Movies() { title = "Platoon", category = 2 };
            Movies movie21 = new Movies() { title = "Cinema Paradiso", category = 4 };
            Movies movie22 = new Movies() { title = "Dr. Strangelove", category = 3 };
            Movies movie23 = new Movies() { title = "The Little Mermaid", category = 1 };
            Movies movie24 = new Movies() { title = "Amadeus", category = 4 };
            Movies movie25 = new Movies() { title = "M", category = 4 };
            Movies movie26 = new Movies() { title = "Up", category = 1 };
            Movies movie27 = new Movies() { title = "Jaws", category = 2 };
            Movies movie28 = new Movies() { title = "Die Hard", category = 2 };
            Movies movie29 = new Movies() { title = "Heat", category = 2 };
            Movies movie30 = new Movies() { title = "Chinatown", category = 4 };
            Movies movie31 = new Movies() { title = "The Big Lebowski", category = 3 };
            Movies movie32 = new Movies() { title = "Ghostbusters", category = 3 };
            Movies movie33 = new Movies() { title = "Caddyshack", category = 3 };
            Movies movie34 = new Movies() { title = "The Good, The Bad, and The Ugly", category = 4 };
            Movies movie35 = new Movies() { title = "Sleepy Hallow", category = 4 };
            Movies movie36 = new Movies() { title = "The Bicycle Thief", category = 4 };
            Movies movie37 = new Movies() { title = "The Empire Strikes Back", category = 2 };
            Movies movie38 = new Movies() { title = "The Matrix", category = 2 };
            Movies movie39 = new Movies() { title = "The Name of the Rose", category = 4 };
            Movies movie40 = new Movies() { title = "Rudy", category = 4 };
            Movies movie41 = new Movies() { title = "Forrest Gump", category = 3 };
            Movies movie42 = new Movies() { title = "Sorry to Bother You", category = 3 };
            Movies movie43 = new Movies() { title = "Se7en", category = 4 };
            Movies movie44 = new Movies() { title = "Spaceballs", category = 4 };
            Movies movie45 = new Movies() { title = "Bill & Ted's Excellent Adventure", category = 4 };
            Movies movie46 = new Movies() { title = "Inception", category = 2 };
            Movies movie47 = new Movies() { title = "The Graduate", category = 4 };
            Movies movie48 = new Movies() { title = "Goonies", category = 3 };
            Movies movie49 = new Movies() { title = "Toy Story", category = 1 };
            Movies movie50 = new Movies() { title = "The Godfather", category = 4 };
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
            movieList.Add(movie11);
            movieList.Add(movie12);
            movieList.Add(movie13);
            movieList.Add(movie14);
            movieList.Add(movie15);
            movieList.Add(movie16);
            movieList.Add(movie17);
            movieList.Add(movie18);
            movieList.Add(movie19);
            movieList.Add(movie20);
            movieList.Add(movie21);
            movieList.Add(movie22);
            movieList.Add(movie23);
            movieList.Add(movie24);
            movieList.Add(movie25);
            movieList.Add(movie26);
            movieList.Add(movie27);
            movieList.Add(movie28);
            movieList.Add(movie29);
            movieList.Add(movie30);
            movieList.Add(movie31);
            movieList.Add(movie32);
            movieList.Add(movie33);
            movieList.Add(movie34);
            movieList.Add(movie35);
            movieList.Add(movie36);
            movieList.Add(movie37);
            movieList.Add(movie38);
            movieList.Add(movie39);
            movieList.Add(movie40);
            movieList.Add(movie41);
            movieList.Add(movie42);
            movieList.Add(movie43);
            movieList.Add(movie44);
            movieList.Add(movie45);
            movieList.Add(movie46);
            movieList.Add(movie47);
            movieList.Add(movie48);
            movieList.Add(movie49);
            movieList.Add(movie50);
           
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
