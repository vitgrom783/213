using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, x, y;
            Console.WriteLine("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x = ");
            x = Convert.ToInt32(Console.ReadLine());


            y = ((2.4) * Math.Abs((x*x+b)/a) + (a - b) *((Math.Sin(a-b))* (Math.Sin(a - b)))+0.01*(x-b)) ;
           

            Console.WriteLine("y = " + y);
          
            Console.ReadKey();

        }
    }
}
