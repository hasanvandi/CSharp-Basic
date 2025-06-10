using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Loop08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //تا وقتی تعداد اعداد وارد شده صفر کمتر از 5 است از کاربر ورودی گرفته و دو برابر ان را در خروجی چاپ کند

            int number;
            int counter = 0;
            for (;counter < 5;)
            {
                Console.Write("enter a number:");
                number = int.Parse(Console.ReadLine());
                if (number == 0)
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine(number * 2);
                }
            }

            Console.ReadKey();

        }
    }
}
