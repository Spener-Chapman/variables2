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
            Console.WriteLine(" ");

            // variables:

            // -----INTERGERS-----

            int score; //created variable named "score"
            score = 0; //assign 0 to score

            Console.WriteLine(score); // accessing variable
            // "=" means "set to the value of" in code
            score = score + 100; // set score to the value of score + 100

            Console.WriteLine(score); // stomped an enemy for 100 points

            score = score + 100;

            Console.WriteLine(score); // stomped an enemy for another 100 points

            // -----STRINGS-----
            Console.WriteLine(" ");
            Console.WriteLine("strings");
            Console.WriteLine(" ");

            string name; // declares string variabele named "name"
            name = "Spencer"; // setting string variable to whatever

            Console.WriteLine(name);

            name = "Chapman"; // changes the name variable to ___
            Console.WriteLine(name);

            string firstname;
            string lastname;
            string fullname;

            firstname = "spencer";
            lastname = "chapman";
            fullname = firstname + " " + lastname; // the " " is used ofr a space
            Console.WriteLine(firstname);
            Console.WriteLine(lastname);
            Console.WriteLine(fullname);

            // -----FLOATS-----

            Console.WriteLine("");
            Console.WriteLine("Floats");
            Console.WriteLine("");
            // "floating point" stores real numbers as oppose to interge numbers
            // 1000000.000
            // 100000.0000 <--- examples of floating point
            // 10000.00000

            // floats are good for moving

            float speed; // in kph
            float distanceTravelled; // in km

            speed = 100.0f; // in kmh
            distanceTravelled = 2345.35f; // in km

            Console.WriteLine("Speedometer: " + speed);
            Console.WriteLine("odometer: " + distanceTravelled);

            // ints vs floats

            int intTest;
            float floatTest;
            float floatTest2;

            intTest = 10 / 3;
            floatTest = 10 / 3; // should be 3.3333 but computer sees it as interger, stores as float
            floatTest2 = 10.0f / 3.0f; // the .0f is what makes it know its a float
            Console.WriteLine(intTest);
            Console.WriteLine(floatTest);
            Console.WriteLine(floatTest2);

            Console.ReadKey(true);
        }
    }
}
