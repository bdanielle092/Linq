using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            Enumerable<string> LFruits = from fruit in fruits.Where(StartsWith == "L");
            Console.WriteLine(LFruits); 

        }
     
    }
}
