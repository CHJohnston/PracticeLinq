using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinqConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice Linq Exercises");

            //System.Linq Extends the IEnumberable Interface so that it can be used with Collections Like Arrays and Lists

            //#1 - Create an Array with names of Cars and Use the Query Syntax create a sublist in descending order 
            
            //Create an Array of Cars
            string[] carArray = new string[]
            {"Ford",
             "BMW",
             "Bently",
             "Toyota",
             "GMC",
             "Buick",
             "Honda",
             "Lexus"
            };

            //Display the cars in the carArray
            Console.WriteLine("Here are the Cars in our carArray");
            foreach (var car in carArray)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();

            //Use the Query Syntax to Select All the Cars That begin with a "B"  
            var cars = from car in carArray
                       where car.Contains("B")
                       orderby car descending
                       select car;

            //Display the cars in the new array cars created from the Linq Query
            Console.WriteLine("Here are the Cars that Begin with the Letter B");
            Console.WriteLine("This new array was created using the Linq Query Syntax");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();

            //Ex2. Create a List of Video Games
            //Using a Linq Method Syntax Query, create a new list new in Order of the Length of the Game Name
            List<string> videoGames = new List<string>
            {"PacMan",
             "Pong",
             "Candy Crush",
             "Diamond Diaries",
             "Farm Heroes Super Saga",
             "Cookie Jam Blast",
             "Genies & Gems"
            };

            Console.WriteLine("Here are the Video Games in our List");
            foreach (var game in videoGames)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine();

            //Using the Method Syntax sort the list by lenght of the name
            var orderedGames = videoGames.OrderBy(x => x.Length);

            Console.WriteLine("Here is a List of the Video Games Sorted by Length of Name");
            Console.WriteLine("This was created using the Linq Method Syntax");
            foreach (var game in orderedGames)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine();
        }
    }
}
