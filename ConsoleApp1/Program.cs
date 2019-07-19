using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, x, y=0;
            Console.WriteLine("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Mathibrary.Class1.Pause(a,b,x);
        }
    }
}
