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
    }
}
