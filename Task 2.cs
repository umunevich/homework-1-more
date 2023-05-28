using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static int NearestPrimeNum(int x)
        {
            bool[] primes = new bool[x*x];
            Array.Fill(primes, true);
            primes[0] = false;
            primes[1] = false;
            int SmallerPrime = 0;
            int BiggerPrime = 0;
            bool BiggerNotFound = true;
            for (int i = 2; i < primes.Length & BiggerNotFound == true; i++)
            {
                if (primes[i])
                {
                    for (int j = i; i * j < primes.Length; j++)
                    {
                        primes[i*j] = false;
                    }
                    if (x < i & primes[i] == true)
                    {
                        BiggerPrime = i;
                        BiggerNotFound = false;
                    }
                    if (x > i & primes[i]==true)
                    {
                        SmallerPrime = i;
                    }
                }
            }
            if (x - SmallerPrime >= BiggerPrime - x)
            {
                return BiggerPrime;
            }
            else
            {
                return SmallerPrime;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(NearestPrimeNum(x));
            Console.ReadKey(false);
        }
    }
}