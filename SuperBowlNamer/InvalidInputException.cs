using System;

namespace SuperBowlNamer
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException() : base("The input received was invalid.")
        {

        }
    }
}