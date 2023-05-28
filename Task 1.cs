using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int gcd(int x, int y, int z)
        {
            while (x != y)
            {
                if (x > y)
                {
                    x = x - y;
                }
                else
                {
                    y = y -x;
                }
            }
            while (z != x)
            {
                if (z > x)
                {
                    z = z - x;
                }
                else
                {
                    x = x - z;
                }
            }
            return x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The greatest common divisor of {x}, {y} and {z} is {gcd(x, y, z)}");
            Console.ReadKey(false);
        }
    }
}
