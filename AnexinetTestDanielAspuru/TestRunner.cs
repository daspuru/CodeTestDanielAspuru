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

        }
    }
}
