using System;
namespace AnexinetTestDanielAspuru
{
    //Using the method RunTest() will run all test. This method is already called in the App.xaml.cs file.
    //You can just run the app too see test results.
    public static class TestRunner
    {
        public static void RunTest()
        {
            //Start Test with output

            //1.- Write a function that receives a String parameter and returns how many vowels that string has.
            string stringToCountVowels = "¿Cuántas vocales tengo?"; //This string should count the 8 contained vowels

            int numberOfVowles = Functions.CountVowels(stringToCountVowels);

            Console.WriteLine("String: \"" + stringToCountVowels + "\" has " +  numberOfVowles.ToString() + " vowels");


            //2.- Write a function that receives 2 Date parameters and returns the time difference in minutes.
            DateTime startDate = new DateTime(2019, 10, 26);
            DateTime endDate = new DateTime(2019, 10, 27);

            double differenceInMinutes = Functions.TimeDifferenceInMinutes(startDate, endDate);

            Console.WriteLine("Difference in minutes from date: " + startDate.ToString() + " and " + endDate.ToString() +
                               " is " + differenceInMinutes.ToString());


            //3.- Write a function that reverses a given (as a parameter) string
            string stringToReverse = "This is the string to reverse...";
            string reversedString = Functions.ReverseString(stringToReverse);
            Console.WriteLine("Original string: \"" + stringToReverse + "\", reversed version: \"" + reversedString + "\"");

            //4.- Print numbers from 1 to 200 and every time a number is divisible by 3, print the word "fizz"
            //    instead of the number; every time the number is divisible by 5 print the number "buzz" and
            //    every time the number is divisible by both (3 & 5) print the word "fizzbuzz".
            Console.WriteLine("Printing the requested numbers");
            Functions.PrintNumbers();

            //5.- Given 2 strings of unknown characters(but it can't be repeated)
            //    create a function that returns an array of the characters that are repeated in both strings
            //    in the most efficient way.

            //We use a try catch block in case this code breaks the rule:
            //"Given 2 strings of unknown characters (but it can't be repeated)"
            try
            {
                //Strings to test
                string string1 = "abrcdhjkl";
                string string2 = "artecdkl";

                //Call function
                char[] repeatedChars = Functions.ReturnRepeatedCharactersInStrings(string1, string2);

                //Dump results
                Console.Write("Repeated characters in strings \"" + string1 + "\" and \"" + string2 + "\" are: ");

                foreach (char character in repeatedChars)
                {
                    Console.Write(character + " ");
                }

                Console.WriteLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("Client code is breaking the rules of the test, both strings are equal.");
                Console.WriteLine(e.Message + e.StackTrace);
            }

            //6.- Write a program that computes (EQUATION)
            //This function uses Pow
            double result = Functions.ComputeEquation();
            Console.WriteLine("Computed equation using Math.Pow");
            Console.WriteLine(result.ToString());

            //6.- Write a program that computes (EQUATION)
            //This other version of the function calculates the equation witout the use of Pow
            double resultRaw = Functions.ComputeEquationRaw();
            Console.WriteLine("Computed equation without Math.Pow");
            Console.WriteLine(resultRaw.ToString());

        }
    }
}
