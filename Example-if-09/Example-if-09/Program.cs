using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_if_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //برنامه عددی میگیرد اگر زوج بود عددی دیگر میگیرد و جمع انهارا نمایش میدهد
            Console.Write("Please enter your number:");
            int num01 = Convert.ToInt32(Console.ReadLine());

            int sum = num01;

            if (num01 % 2 == 0)
            {
                Console.Write("Please enter your number next:");
                int num02 = Convert.ToInt32(Console.ReadLine());
                sum += num02;
            }
           
                Console.WriteLine(sum);
            
            Console.ReadLine();
        }
    }
}
