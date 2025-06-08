using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Loop_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //سه عدد از کاربر گرفته و مجموع انها را چاپ میکنیم
         

            int sum = 0;

            int num;
            for(int i = 0;i <= 2; i++)
            {
                Console.Write($"Enter a number{i + 1}:");
                num = int.Parse(Console.ReadLine());

                sum += num;
            }

            Console.WriteLine(sum);

            Console.ReadLine();

        }
    }
}
