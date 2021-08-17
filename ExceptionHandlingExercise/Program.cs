using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // Create a list called numbers that will hold integers
            // Create an string variable with an empty string initializer - name it str

            var arr = new char[9] {'1','7','8','9','0','3','d','f','j'};
            var numberList = new List<int> { };
            var string1 = string.Empty;
            int newelement;

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------


            //TODO START HERE:

            // Make a foreach loop to iterate through your character array
            foreach (var element in arr)
            {
                //Console.Write($"character is { element}");

                // Now create a try catch

                try
                {
                    newelement = int.Parse(element.ToString());

                    // Inside your try block
                    // set your string variable to each array element in your char[] to .ToString()
                    // Now, using int.Parse, parse your string variable and store in an int variable
                    // Then add each int to your list

                    string1 = element.ToString();
                    numberList.Add(int.Parse(string1));

                }
                catch (Exception e)
                {
                    // catch your Exception:

                    // in the scope of your catch you can use the following, 

                    //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection
                    Console.WriteLine($"Not able to parse the character {element} into integer");
                }
            }

            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            foreach (var num in numberList)
            {
                Console.WriteLine(num);
            }


        }
    }
}
