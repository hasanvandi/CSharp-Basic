using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_if_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //گرفتن دو عدد از ورودی به دست اوردن تقسیم و باقی مانده عدد بزرگتر
            Console.Write("please enter your number1:");
            int num01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter your number2:");
            int num02 = Convert.ToInt32(Console.ReadLine());

            int max = num01;

            if (num02 > num01)
            {
                max = num02;
            }

            Console.WriteLine($"Div = {max / 10}");
            Console.WriteLine($"rem = {max % 10}");

            Console.ReadLine();
        }
    }
}
