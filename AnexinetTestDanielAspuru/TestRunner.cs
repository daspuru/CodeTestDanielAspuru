﻿using System;
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

        }
    }
}
