using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] fifty = new int[50];
                //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
                Populater(fifty);
            //TODO: Print the first number of the array
            Console.WriteLine($"{fifty[0]}");

            //TODO: Print the last number of the array            
            Console.WriteLine($"{fifty[fifty.Length - 1]}");

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(fifty);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            
            
            /*  1) First way, using a custom method => Hint: Array._____(); 
            2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");
                ReverseArray(fifty);
            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(fifty);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted number");

            Array.Sort(fifty);
            NumberPrinter(fifty);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

           


            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var numb = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"Capacity: {numb.Capacity}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numb);

            //TODO: Print the new capacity
            Console.WriteLine($"New Capacity: {numb.Capacity}");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            int input;
            bool number;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                number = int.TryParse(Console.ReadLine(), out input);
            } 
            while (number == false);

            NumberChecker(numb, input);
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numb);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            OddKiller(numb);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numb.Sort();
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var anArray = numb.ToArray();

            //TODO: Clear the list
            numb.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] fifty)
        {
            for (int i = 0; i < fifty.Length; i++)
            {
                if (fifty[i] % 3 == 0)
                {
                    fifty[i] = 0;
                }
            }
            NumberPrinter(fifty);
        }

        private static void OddKiller(List<int> numb)
        {
            for (int i = numb.Count - 1; i >= 0; i--)
            {
                if (numb[i] % 2 != 0)
                {
                    numb.Remove(numb[i]);
                }
            }
            NumberPrinter(numb);
        }

        private static void NumberChecker(List<int> numb, int newNumb)
        {
            if (numb.Contains(newNumb))
            {
                Console.WriteLine($"I've got your number here!");
            }
            else
            {
                Console.WriteLine("Nope sorry, don't have that here");
            }
        }

        private static void Populater(List<int> numb)
        {
            while (numb.Count < 50)
            {
                Random rng = new Random();
                var number = rng.Next(0, 50);
                numb.Add(number);
            }
            NumberPrinter(numb);
        }

        private static void Populater(int[] fifty)
        {
            for (int i = 0; i < fifty.Length; i++)
            {
                Random rng = new Random();
                fifty[i] = rng.Next(0, 50);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
            NumberPrinter(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
