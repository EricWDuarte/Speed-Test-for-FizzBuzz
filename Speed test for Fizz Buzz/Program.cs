using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed_test_for_Fizz_Buzz
{
    class Program
    {

        static void Main()
        {
            var p = new Program();
            int n = int.Parse(Console.ReadLine());
            
            var s = new Stopwatch();
            s.Start();

            p.fizzbuzzWithFors(n);
            
            Console.WriteLine("Tempo em Milisegundos: " + s.ElapsedMilliseconds);

        }

        public void fizzbuzzWithIfs(int n)
        {
            //List<Object> numbers = new List<Object>();

            for (int i = 0; i < n; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                } else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                } else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                } else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void fizzbuzzWithFors(int n)
        {
            List<Object> numbers = new List<Object>();

            for (int i = 0; i < n; i++)
            {
                numbers.Add(i);
            }

            for (int i = 0; i < n; i += 3)
            {
                numbers[i] = "Fizz";
            }

            for (int i = 0; i < n; i += 5)
            {
                numbers[i] = "Buzz";
            }

            for (int i = 0; i < n; i += 15)
            {
                numbers[i] = "Fizz Buzz";
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
