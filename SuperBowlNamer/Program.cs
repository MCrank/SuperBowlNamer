using System;

namespace SuperBowlNamer
{
    class Program
    {
        static void Main(string[] args)
        {
            RunStartup();
        }

        static void RunStartup()
        {
            IntToRomanConverter myConverter = new IntToRomanConverter();
            Console.WriteLine("\n-----  Please enter a number to convert to Roman Numerals! -----");
            var userInput = Console.ReadLine();

            try
            {
                var output = myConverter.ConvertToRomanNumerals(userInput);
                Console.WriteLine($"\nYour Roman Numeral is {output}\n");
            }
            catch (Exception)
            {
                Console.WriteLine("\t ***** You have enter an invalid input. Please try again *****\n");
                RunStartup();
            }

            Console.WriteLine("Would you like to convert another number? (Y/N)\n");
            var userAnswer = Console.ReadLine().ToLower();
            if (userAnswer != "y")
            {
                System.Environment.Exit(-1);
            }
            else
            {
                Console.Clear();
                RunStartup();
            }
        }
    }
}