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
            for (var i = 1; i <= 100; i = i + 1)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("fizzbuzz");

                }
                else if (i % 5 == 0)

                {
                    Console.WriteLine("buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();


        }
    }
}
