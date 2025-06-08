using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Example_Loop_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //یک عدد بگیرید و مجموع اعداد فرد کوچک تر از ان را بنویسید
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());

 

            int sum = 0;

            for (int i = 1;i < number;i = i+2)
            {

                sum = sum + i;
            }
            Console.WriteLine($"Sum is:{sum}");
            Console.ReadLine();
        }
    }
}
