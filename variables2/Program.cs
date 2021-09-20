using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("variables");


            // variables:

            int score; //created variable named "score"
            score = 0; //assign 0 to score

            Console.WriteLine(score); // accessing variable
            // "=" means "set to the value of" in code
            score = score + 100; // set score to the value of score + 100

            Console.WriteLine(score); // stomped an enemy for 100 points

            score = score + 100;

            Console.WriteLine(score); // stomped an enemy for another 100 points

            Console.ReadKey(true);
        }
    }
}
