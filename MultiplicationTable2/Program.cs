using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var times = int.Parse(Console.ReadLine());

            if (times <= 10)
            {
                for (int i = times; i <= 10; i++)
                {
                    Console.WriteLine($"{n} X {i} = {n*i}");
                }
            }
            else
            {
                Console.WriteLine($"{n} X {times} = {n * times}");
            }
        }
    }
}
