using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab11
{
    public class Category
    {
      
        public void WriteOut(int catSelect, List<Movies> movieList)
        {
            string cat;
            if (catSelect == 1) cat = "animation";
            else if (catSelect == 2) cat = "action";
            else if (catSelect == 3) cat = "comedy";
            else cat = "drama";
            Console.WriteLine($"We have the following {cat} movies: ");
            List<Movies> subList = movieList.Where(x => x.category == catSelect).ToList();
            foreach (var item in subList)
            {
                System.Console.WriteLine(item.title);
            }
            Console.WriteLine();
        }
    }
}