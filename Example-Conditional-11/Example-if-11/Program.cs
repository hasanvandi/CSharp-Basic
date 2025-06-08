using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_if_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //دو عدد میگیریم حاصل ده برابر عدد بزرگتر منهای توان دوم عدد کوچک تر را نمایش میدهیم
            Console.WriteLine("please enter number1:");
            int num01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter number2:");
            int num02 = Convert.ToInt32(Console.ReadLine());

            int max = num01;
            int min = num01;
            if (num02 > max)
            {
                max = num02;
            }
            else if (num02 < min)
            {
                min = num02;
            }
            int result = (10 * max) - (min * min);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
