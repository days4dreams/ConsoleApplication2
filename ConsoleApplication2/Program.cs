using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Stationery Shop.");
            Console.WriteLine("I will help you find the perfect Smart Pen; the stationery tool of future that writes notes for you!");

            Console.WriteLine("Can I start by asking your name?");
            string userName = Console.ReadLine(); // Ask the user for their name

            Console.WriteLine("Thank you. Now to pick your perfect pen");

            Console.WriteLine("How many days old will the pen be?");
            string agePen = Console.ReadLine(); // Ask the user for the age of the pen
            // validate response? Number range
            int age;
            if (!int.TryParse(agePen, out age)) // process if input was an invalid number
            {
                while (age >= 1 && age <= 365) // age is set to 0 by default if no number is entered
                {
                    Console.WriteLine(agePen + " is an invalid number. Please choose between 1 and 365 days old"); // error message
                    int.TryParse(Console.ReadLine(), out age); // allows the user to input another value
                }

            } // this loop will repeat until age has set to 1 or above or 365 or below


            Console.WriteLine("OK, and how sensitive, on a scale of 1 to 5, do you need the pen to be?");
            Console.WriteLine("In our ratings, 1 is not senstive and 5 is very sensitive");
            string sensitivePen = Console.ReadLine(); // Ask the user for sensitivity rating
            // validate response? Give feedback with array?
            double[] sensitiveArray = { 1, 2, 3, 4, 5 };
            double sensitive;
            if (!double.TryParse(sensitivePen, out sensitive))

            {
                while (sensitive <= 5) // Rating is to be between 1 - 5
                {
                    Console.WriteLine(sensitivePen + " is an invalid. Please choose a rating between 1 and 5 "); // error message
                    double.TryParse(Console.ReadLine(), out sensitive); // allows the user to input another value
                }

            } // this loop will repeat until age has set to 1 or above or 5 or below


            if (sensitiveArray.Contains(sensitive))
            {
                Console.WriteLine("Good choice"); // accept message
                SmartPen.SenseRate();
            }

            Console.WriteLine("Moving on, do you require your Smart Pen to connect to Wifi?");
            Console.WriteLine("Just answer Yes or No.");
            string wifiPen = Console.ReadLine(); // Ask the user about wifi
            // validate response? Bool true or false
            bool wifi;
            if (bool.TryParse(wifiPen, out wifi))
            {
                if (string.Equals(wifiPen, "Yes"))
                {
                    wifi = true;
                    bool.TryParse(wifiPen, out wifi);
                }
                else if (string.Equals(wifiPen, "No"))
                {
                    wifi = false;
                }
                else
                {
                    return;
                }
            }


            Console.WriteLine("Finally, we will instruct the Smart Pen write for you!");
            Console.WriteLine("Please type your desired message below, and be aware that Smart Pens have a limit of 140 characters");
            string outputPen = Console.ReadLine(); // Ask the user output sentence

            Console.WriteLine("Thank you for the information " + userName);


            SmartPen mypen = new SmartPen();
            mypen.AgeInDays = age;
            mypen.ConnectedToWifi = wifi;
            mypen.SensitivityRating = sensitive;
            mypen.OutputSentence = outputPen;
            mypen.Speak();
            Console.ReadKey();

        }
    }
}
