using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_if_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //دو عدد دو رقمی میگیرد برنامه میگوید هیچ رقم مشابه ای وجود دارد بین دو عدد
            Console.WriteLine("Enter number1:");
            int num01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2:");
            int num02 = Convert.ToInt32(Console.ReadLine());

            int d1 = num01 % 10;
            int d2 = num01 / 10;
            int d3 = num02 % 10;
            int d4 = num02 / 10;

            if(d1 == d3 || d1==d4 || d2 == d3 || d2 ==d4)
            {
                    Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("No");

            }


            Console.Read();
        }
    }
}
