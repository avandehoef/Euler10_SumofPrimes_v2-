using System;
using System.Collections.Generic;

namespace Euler10
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 start = 5;           
            Int64 sum = 5;
            Console.WriteLine("Enter maximum");            
            int limit = Convert.ToInt32(Console.ReadLine());
            double startTime = Environment.TickCount;
            List<Int64> primes = new List<Int64>();            
            primes.Add(3);

            startPoint: for (start = start; start <= limit+ start; start = start + 2)
            {
                foreach (Int64 prime in primes )
                {                   
                    if (start % prime == 0)
                    {
                        start = start + 2;
                        goto startPoint;
                    }
                }
                
                sum = sum + start;
                if (start <= Math.Sqrt(limit))
                {
                    primes.Add(start);
                }

                if (start >= limit)
                {
                    double endTime = Environment.TickCount;
                    Console.WriteLine("total sum of all primes below " + limit + " is: " + (sum - start));
                    Console.WriteLine("time to compute in ms: " + (endTime - startTime));
                    Console.ReadKey();
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
