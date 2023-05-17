using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpressionRegax
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RegaxPattern pattern = new RegaxPattern();
            pattern.MatchingPattern();
            Console.ReadLine();
        }
    }
}
