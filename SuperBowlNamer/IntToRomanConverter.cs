using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBowlNamer
{
    /* List of the Main Roman numbers
     * 1 = I
     * 5 = V
     * 10 = X
     * 50 = L
     * 100 = C
     * 500 = D
     * 1000 = M
   */

    public class IntToRomanConverter
    {
        public string ConvertToRomanNumerals(string input)
        {
            return input == "1" ? "I" : "No";
        }
    }
}
