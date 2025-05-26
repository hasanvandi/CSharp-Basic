using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_if_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //گرفتن سه تا ورودی از کاربر و و شرط اینکه تعداد مضرب دو یا سه یا مساوی بودن رو نمایش بده
            Console.Write("please enter your number1:");
            int num01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter your number2:");
            int num02 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your number3:");
            int num03 = Convert.ToInt32(Console.ReadLine());

            //تعداد مضرب دو
            int counter2 = 0;
            //تعداد مضرب سه
            int counter3 = 0;

            if (num01 % 2 == 0)
            {
                counter2 += 1;
            }
            if (num01 % 3 == 0)
            {
                counter3 += 1;
            }

            if (num02 % 2 == 0)
            {
                counter2 += 1;
            }
            if (num02 % 3 == 0)
            {
                counter3 += 1;
            }

            if (num03 % 2 == 0)
            {
                counter2 += 1;
            }
            if (num03 % 3 == 0)
            {
                counter3 += 1;
            }

            if (counter2 > counter3)
            {
                Console.WriteLine($"2 :{counter2}");
            }

            if (counter3 > counter2)
            {
                Console.WriteLine($"3 :{counter3}");
            }

            if (counter3 == counter2)
            {
                Console.WriteLine($"2:{counter2} and 3:{counter3}. 2 = 3");
            }

            Console.ReadLine();
        }
    }
}
