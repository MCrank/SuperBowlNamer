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
            // Build a dictionary for looking up input numbers????
            Dictionary<string, string> romanNumbers = new Dictionary<string, string>();
            romanNumbers.Add("1", "I");
            romanNumbers.Add("5", "V");
            romanNumbers.Add("10", "X");
            romanNumbers.Add("50", "L");
            romanNumbers.Add("100", "C");
            romanNumbers.Add("500", "D");
            romanNumbers.Add("1000", "M");


            if (input == "1")
            {
                return "I";
            }
            else if (input == "5")
            {
                return "V";
            }
            else
            {
                return "No";
            }
        }
    }
}
