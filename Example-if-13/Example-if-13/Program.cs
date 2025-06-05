using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_if_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //برنامه چهار عدد میگیرد کوچک ترین عدد زوج رو چاپ میکند در غیر این صورت پیغامی تحت عنوان عدد زوجی وجود ندارد چاپ میشود


            Console.Write("please enter your number1:");
            int num01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter your number2:");
            int num02 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your number3:");
            int num03 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your number4:");
            int num04 = Convert.ToInt32(Console.ReadLine());

            int min = 0;
            bool flagMin = false;
            if(num01 % 2 == 0)
            {
                if(flagMin == false)
                {
                    min = num01;
                    flagMin = true;
                }
                else if(num01 < min)
                {
                    min = num01;
                }
            }
            if (num02 % 2 == 0)
            {
                if (flagMin == false)
                {
                    min = num02;
                    flagMin = true;
                }
                else if (num02 < min)
                {
                    min = num02;
                }
            }
            if (num03 % 2 == 0)
            {
                if (flagMin == false)
                {
                    min = num03;
                    flagMin = true;
                }
                else if (num03 < min)
                {
                    min = num03;
                }
            }
            if (num04 % 2 == 0)
            {
                if (flagMin == false)
                {
                    min = num04;
                    flagMin = true;
                }
                else if (num04 < min)
                {
                    min = num04;
                }
            }
            if(flagMin == true)
            {
                Console.WriteLine($"Min:{min}");
            }
            else
            {
                Console.WriteLine("there is no even number.");
            }

            Console.ReadLine();
        }
    }
}
