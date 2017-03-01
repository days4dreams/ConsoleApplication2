using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
   public class SmartPen
    {
        public SmartPen()
        { }
        public string OutputSentence { get; set; }
        public int AgeInDays { get; set; }
        public bool ConnectedToWifi { get; set; }
        public double SensitivityRating { get; set; }

        public void SenseRate()
        { 
            int sensitive;
       
            if (sensitive == 1)
            {
                Console.WriteLine("1 is a very lightweight");
            }

            else if (sensitive == 2)
            {
                Console.WriteLine("2 is a lightweight");
            }

            else if (sensitive == 3)
            {
                Console.WriteLine("3 is a medium weight");
            }

            else if (sensitive == 4)
            {
                Console.WriteLine("4 is a heavy weight");
            }

            else if (sensitive == 5)
            {
                Console.WriteLine("5 is a very heavy weight");
            }
        }


        public void Speak()
        {
            Console.WriteLine("Here is a summary of your Smart Pen order:");
            Console.WriteLine("Your Smart Pen will be " + AgeInDays + " days old" );
            Console.WriteLine("It will have a sensitivity rating of " + SensitivityRating);
            Console.WriteLine("It will wifi " + ConnectedToWifi); // must write if statement
            Console.WriteLine("Your message will be: " + OutputSentence);

        }

        public void Listen()
        {
        }

        public void TellJoke()
        {
        }

        internal static void SenseRate()
        {

            throw new NotImplementedException();
        }
    }
}
