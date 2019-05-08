using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0742279
{
    class Program
    {
        static void Main(string[] args)
        {

            int a ,b ;

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
    }
}
