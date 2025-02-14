using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number for Fibonacci");
            int num1= Convert.ToInt32(Console.ReadLine());
            int fib1 = 0;
            int fib2 = 1;
            int sum = fib1+ fib2;
            Console.WriteLine($"{ fib1}\n{ fib2}");
            for (int i = 0; i < num1; i++) {
                Console.WriteLine($"{sum}");
                fib1 = fib2;
                fib2 = sum;
                sum = fib1+ fib2;
            }
        }
    }
}
