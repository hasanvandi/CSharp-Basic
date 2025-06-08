using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_if_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //عددی از کاربر گرفته و چند رقمی بودن عدد رو تا حداکثر 5 رقمی کنترل میکنیم
            Console.Write("Enter number:");
            int number = int.Parse(Console.ReadLine());
            if(number > 0 && number < 10)
            {
                Console.WriteLine("1 Digit number");
            }
            else if(number >= 10 && number < 100)
            {
                Console.WriteLine("2 Digit number");
            }
            else if (number >= 100 && number < 1000)
            {
                Console.WriteLine("3 Digit number");
            }
            else if (number >= 1000 && number < 10000)
            {
                Console.WriteLine("4 Digit number");
            }
            else if (number >= 10000 && number < 100000)
            {
                Console.WriteLine("5 Digit number");
            }

            Console.ReadLine();

        }
    }
}
