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
            Console.WriteLine("Please enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int tmp = 0;

            while (num > 0) 
            {
                tmp = tmp * 10 + num % 10;
                num /= 10;
            }
            Console.WriteLine($"{tmp}");
        }
    }
}
