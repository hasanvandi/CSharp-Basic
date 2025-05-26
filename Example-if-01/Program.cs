using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_if_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //چهار عدد از ورودی میگیریم اگر تعداد زوجی از انها مضرب سه بود پیغامی میدهیم

            Console.Write("please enter your number1:");
            int num01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter your number2:");
            int num02 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your number3:");
            int num03 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your number4:");
            int num04 = Convert.ToInt32(Console.ReadLine());

            //کنترل زوج یا فرد بودن اعداد
            int counter = 0;

            if (num01 % 3 == 0)
            {
                counter++;
            }
            if (num02 % 3 == 0)
            {
                counter++;
            }
            if (num03 % 3 == 0)
            {
                counter++;
            }
            if (num04 % 3 == 0)
            {
                counter++;
            }

            if (counter % 2 == 0)
            {
                Console.WriteLine("yes");
            }


            Console.Read();
        }
    }
}
