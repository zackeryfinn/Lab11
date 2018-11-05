using System;

namespace Lab11
{
    public class Welcome
    {
        public void Hello()
        {
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine();
            Console.WriteLine("There are 10 movies on this list.");
        }
        public void CatInfo()
        {
            Console.WriteLine("Please choose a film by category. We have" +
                "animation, action, comdey and drama.");
            Console.Write("Press (1) for animation; " +
                "Press (2) for action; " +
                "Press (3) for comedy " +
                "Press (4) for drama: ");
        }
        public int GetCategoryInput()
        {
            var userInput = Console.ReadLine();
            int categorySelection = 0;
            while (!int.TryParse(userInput, out categorySelection) || categorySelection < 1 || categorySelection > 4)
            {
                Console.WriteLine("Sorry, that is not a valid input.");
                Console.Write("Please enter a number between 1 and 4: ");
                userInput = Console.ReadLine();
                Console.WriteLine();
            }
            return categorySelection;
        }
    }
}