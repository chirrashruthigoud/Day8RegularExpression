using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionRegax
{
    public class RegaxPattern
    {
        public void MatchingPattern()
        {
            string input = "abbb"; // Change this string to test different inputs

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
        public void ValidImageFileType()
        {
            string[] fileNames = { "image.jpg", "picture.png", "document.pdf", "logo.gif", "photo.jpeg" };

            Regex regex = new Regex(@"^.*\.(jpg|jpeg|png|gif)$");

            foreach (string fileName in fileNames)
            {
                if (regex.IsMatch(fileName))
                {
                    Console.WriteLine($"Valid image file name: {fileName}");
                }
            }
        }

        public void WebsiteMatch()
        {
            string[] websiteAddresses = { "https://www.example.com", "http://google.com", "www.github.io", "invalid-website.com" };

            Regex regex = new Regex(@"^(https?://)?[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)*\.[a-zA-Z]{2,6}(/[a-zA-Z0-9-]+)*(/)?$");

            foreach (string websiteAddress in websiteAddresses)
            {
                if (regex.IsMatch(websiteAddress))
                {
                    Console.WriteLine($"Valid website address: {websiteAddress}");
                }
            }
        }
        public void LowerCaseUnderScore()
        {
            string input = "hello_world foo_bar abc_def_ghi";

            Regex regex = new Regex(@"[a-z]+(_[a-z]+)+");

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine($"Match found: {match.Value}");
            }

        }
        public void HtmlRegex()
        {
            string input = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>";

            // Regular expression pattern to match HTML tags
            string pattern = @"<[^>]+>";

            // Extract HTML tags using the pattern
            MatchCollection matches = Regex.Matches(input, pattern);

            // Print the matched HTML tags
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
