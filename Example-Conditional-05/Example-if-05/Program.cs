using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_if_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // برنامه بنویسید که 4 عدد بگیرد و اولین عدد زوج میان انها را چاپ کند
   
            Console.Write("Please enter number1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter number2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter number3:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter number4:");
            int num4 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine(num1);
            }
            else if (num2 % 2 == 0)
            {
                Console.WriteLine(num2);
            }
            else if (num3 % 2 == 0)
            {
                Console.WriteLine(num3);
            }
            else if (num4 % 2 == 0)
            {
                Console.WriteLine(num4);
            }
            else
            {
                Console.WriteLine("all of the numbers are odd");
            }

            Console.ReadLine();

        }
    }
}
