using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_if_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //برنامه سه عدد گرفته و اعداد فرد رو جمع میکند
            Console.Write("please enter number1:");
            int num1 =int.Parse(Console.ReadLine());
            Console.Write("please enter number2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("please enter number3:");
            int num3 = int.Parse(Console.ReadLine());

            int count = 0;
            if(num1 % 2 == 1)
            {
                count += num1;
            }
            if(num2 % 2 == 1)
            {
                count += num2;
            }
            if (num3 % 2 == 1)
            {
                count += num3;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
