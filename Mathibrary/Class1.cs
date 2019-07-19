using System;

namespace Mathibrary
{
    public class Class1
    {
       
        static public void Pause(double a, double b, double x)
        {
            double y;
            y = ((2.4) * Math.Abs((x * x + b) / a) + (a - b) * ((Math.Sin(a - b)) * (Math.Sin(a - b))) + 0.01 * (x - b));
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
