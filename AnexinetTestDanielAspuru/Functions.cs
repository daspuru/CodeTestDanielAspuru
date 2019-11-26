﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AnexinetTestDanielAspuru
{
    //This class includes all the functions requested in the test description, there is a client
    //caller to run all tests in the TestRunner class.
    public static class Functions
    {
        //1.- Write a function that receives a String parameter and returns how many vowels that string has.
        public static int CountVowels(string input)
        {
            //Initialize counter
            int totalVowels = 0;

            //Define an array with the vowels (with and without accents)
            char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'Á', 'É', 'Ó', 'Ú' };

            //Split the string with the char as separator and count the number of parts minus one
            foreach (char vowel in vowels)
            {
                totalVowels += input.ToUpper().Split(vowel).Length - 1;
            }

            //Return the counter
            return totalVowels;
        }

        //2.- Write a function that receives 2 Date parameters and returns the time difference in minutes.
        public static double TimeDifferenceInMinutes(DateTime startDate, DateTime endDate)
        {
            //Substract starting date from end date to get the time span
            TimeSpan timeSpan = endDate.Subtract(startDate);
            //Use the TotalMinutes property of the TimeSpan class to get the total minutes.
            return timeSpan.TotalMinutes;
        }

        //3.- Write a function that reverses a given (as a parameter) string
        public static string ReverseString(string input)
        {

            //Create a char array of the size of the input string
            char[] charArray = new char[input.Length];

            //Declare a counter that will being incremented during the loop
            int increasingPosition = 0;

            //Iterate for each character of the string with two pointers
            for (int decreasingPosition = input.Length - 1; decreasingPosition >= 0; decreasingPosition--)
            {
                //Cross the pointers to save the last character in the first position and so on in the loop
                charArray[increasingPosition++] = input[decreasingPosition];
            }

            //Convert array to string and return
            return new string(charArray);

        }

        //4.- Print numbers from 1 to 200 and every time a number is divisible by 3, print the word "fizz"
        //    instead of the number; every time the number is divisible by 5 print the number "buzz" and
        //    every time the number is divisible by both (3 & 5) print the word "fizzbuzz".
        public static void PrintNumbers()
        {
            //Iterate 200 times
            for (int number = 1; number < 201; number++)
            {
                //If number is divisible by 3 & 5, modulus will return zero
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                //If number is divisible by 3, modulus will return zero
                else if (number % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                //If number is divisible by 5, modulus will return zero
                else if (number % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(number.ToString());
                }
            }
        }
    }
}
