using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserResgistration
{
    public class RegexPattern
    {
        //UC-1 Program to enter valid first name format.
        
        public static void FirstName()
        {
            string[] arr = { "Praful", "praful", "pr12", "PRaful123", "12345" }; 
            string pattern = "^[A-Z][a-z]{3}";

            foreach (string input in arr)
            {
                //IsMatch(String, String, RegexOptions)

                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("{0} is valid", input);
                }
                else
                {
                    Console.WriteLine("{0} is Invalid", input);
                }
            }
        }
    }
}