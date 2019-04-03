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
            Dictionary<int, string> romanNumbers = new Dictionary<int, string>();
            romanNumbers.Add(1000, "M");
            romanNumbers.Add(900, "CM");
            romanNumbers.Add(500, "D");
            romanNumbers.Add(400, "CD");
            romanNumbers.Add(100, "C");
            romanNumbers.Add(90, "XC");
            romanNumbers.Add(50, "L");
            romanNumbers.Add(40, "XL");
            romanNumbers.Add(10, "X");
            romanNumbers.Add(9, "IX");
            romanNumbers.Add(5, "V");
            romanNumbers.Add(4, "IV");
            romanNumbers.Add(1, "I");

            // Parse the input to int and create a stringbuilder for output
            int numberToParse2 = int.Parse(input);
            var sb = new StringBuilder();

            foreach (var number in romanNumbers)
            {
                // If number is >= Key in Dictionary Add value to stringbuilder and subtract value
                while (numberToParse2 >= number.Key)
                {
                    sb.Append(number.Value);
                    numberToParse2 -= number.Key;
                }
            }
            return sb.ToString();
        }
    }
}
