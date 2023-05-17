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
            Console.WriteLine("Select following one.");
            Console.WriteLine("1.MatchingPattern \n2.ValidImageFileType. \n3.WebsiteMatch." +
                "\n4.LowerCaseUnderScore.");
            int obj = Convert.ToInt32(Console.ReadLine());
            switch (obj)
            {
                case 1:

                    pattern.MatchingPattern();
                    break;
                case 2:
                    pattern.ValidImageFileType();
                    break;

                case 3:
                    pattern.WebsiteMatch();
                    break;
                case 4:
                    pattern.LowerCaseUnderScore();
                    break;
                default:
                    Console.WriteLine("number not found");
                    break;

            }
            Console.ReadLine();
        }
    }
}
