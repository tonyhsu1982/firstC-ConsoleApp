using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hi There!");
            int var1 = 5;
            Console.WriteLine("The value of var1 is {0}", var1);
            int price1 = 500;
            Console.WriteLine("Please pay {0:C} to me.", price1);
            Console.WriteLine("|{0,10}|", price1);
            Console.WriteLine("|{0,-10}|", price1);
            int v1=2, v2 = 17;
            float f1 = 26.843F, f2=23463.14F;
            Console.WriteLine("The value of v1 is {0} and v2 is {1}", v1, v2);
            Console.WriteLine("The value of f1 is {0} and f2 is {1}", f1, f2);
        }
    }
}
