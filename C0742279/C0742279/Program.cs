using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0742279
{
    class Program
    {
        //static int counter = 0;
        static void Main(string[] args)
        {

            int a, b;

            Console.Write("Display the multiplication table:\n");

            Console.Write("Input the number to be calculated : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (a = 1; a <= 10; a++)
            {
                Console.Write("{0} X {1} = {2} \n", a, b, a * b);
            }
            Console.ReadLine();
        }

            // A assignment for adding numnbers step down by 6 
            //int sum = 0;
            //int start = 314;
            //int end = 102;
            //int StepDownValue = 6;

          /* for ( Console.WriteLine("point a") ; IsLogicalValue() ; Console.WriteLine("point b"))
            {
                Console.WriteLine("Help I am stuck in an infinite loop!!");


            }

        }


        public static bool IsLogicalValue()
        {
            counter++;

            if (counter > 5) return false;


            return true;
        }*/
    }
}
