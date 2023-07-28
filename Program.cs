using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    class Program
    {
        static void Main()
        {
            string s1 = "Каждый ";
            string s2 = "охотник ";
            string s3 = "желает ";
            string s4 = "знать, ";
            string s5 = "где ";
            string s6 = "сидит ";
            string s7 = "фазан.";

            Console.Write(s1);
            Console.Write(s2);
            Console.Write(s3);
            Console.Write(s4);
            Console.Write(s5);
            Console.Write(s6);
            Console.WriteLine(s7);

            string concatString = s1 + s2 + s3 + s4 + s5 + s6 + s7;

            Console.WriteLine(concatString);

            string interpolatedString = $"{concatString}";

            Console.WriteLine(interpolatedString);
        }
    }
}
