using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_if_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //برنامه دو عدد میگیرد اگر هر دو بر 3 یا 7 بخش پذیر بود پیغام 1 در غیر این صورت پیغام 2 چام میشود
            Console.Write("please enter your number1:");
            int num01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter your number2:");
            int num02 = Convert.ToInt32(Console.ReadLine());

            if (num01 % 3 == 0 && num02 % 3 == 0 || num01 % 7 == 0 && num02 % 7 == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("2");
            }
        }
    }
}
