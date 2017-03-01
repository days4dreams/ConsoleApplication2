using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
 public class pen
    {
       public pen ()
        {  }

        public int length { get; set; }
        public string colour { get; set; }
        public bool hasLogo { get; set; }

        public void WriteMethod ()
        {
            Console.WriteLine("This pen is writing");
        }

    }
}
