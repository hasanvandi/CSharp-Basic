using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_if_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //برنامه سه تا عدد میگیرد عددی که بزرگترین دهگان دارد یکانش از دهگان بزرگ تر است؟
            Console.Write("Please enter number1:");
            int num01 = int.Parse(Console.ReadLine());
            Console.Write("Please enter number2:");
            int num02 = int.Parse(Console.ReadLine());
            Console.Write("Please enter number3:");
            int num03 = int.Parse(Console.ReadLine());

            int d1 = num01 % 10;
            int d2 = num01 / 10;

            int d3 = num02 % 10;
            int d4 = num02 / 10;

            int d5 = num03 % 10;
            int d6 = num03 / 10;

            int maxD = d2;
            if(d4 > maxD)
            {
                maxD = d4;
                if(maxD < d3)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            if (d6 > maxD)
            {
                maxD = d6;
                if (maxD < d1)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                   Console.WriteLine("no");
                }
            }
            if(d2 < d1)
            {
                Console.WriteLine("yes");
            }
            else
            {
               Console.WriteLine("no");
            }
            Console.ReadLine();

        }
    }
}
