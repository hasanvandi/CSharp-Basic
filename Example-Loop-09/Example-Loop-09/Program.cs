using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Loop_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ده عدد از کاربرگرفته از 4 عدد زوج ابتدایی چند تاشون مضرب 3 هستند

            int count = 0;
            int count1 = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"enter number{i + 1}:");
                int number = int.Parse(Console.ReadLine());


                if (number % 2 == 0)
                {
                    if (number % 3 == 0)
                    {
                        count++;
                    }
                    count1++;
                    if (count1 == 4)
                    {
                        break;
                    }
                }

            }

            Console.WriteLine(count);

            Console.ReadLine();
        }
    }
}
