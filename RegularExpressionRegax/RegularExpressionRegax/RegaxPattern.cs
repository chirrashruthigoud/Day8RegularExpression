using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionRegax
{
    public class RegaxPattern
    {
        public void MatchingPattern()
        {
            string input = "ehhh"; // Change this string to test different inputs

            Regex regex = new Regex(@"ab{2,3}");

            if (regex.IsMatch(input))
            {
                Console.WriteLine("Match found!");
            }
            else
            {
                Console.WriteLine("No match found.");
            }
        }
    }
}
