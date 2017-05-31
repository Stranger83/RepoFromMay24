using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theater
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var price = 0;
            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                if (day == "Weekday")
                {
                    if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                    {
                        price += 12;
                    }
                    else
                    {
                        price += 18;
                    }
                }
                else if (day == "Weekend")
                {
                    if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                    {
                        price += 15;
                    }
                    else
                    {
                        price += 20;
                    }
                }
                else
                {
                    if (age >= 0 && age <= 18)
                    {
                        price += 5;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price += 10;
                    }
                    else
                    {
                        price += 12;
                    }
                }
                Console.WriteLine($"{price}$");
            }           
        }
    }
}
