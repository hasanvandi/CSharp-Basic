using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_if_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //چهار عدد بگیرد جایگاه عدد بزرگتر و کوچک تر در جفت اول و دوم مشابه هست؟
            Console.Write("please enter your number1:");
            int num01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter your number2:");
            int num02 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your number3:");
            int num03 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your number4:");
            int num04 = Convert.ToInt32(Console.ReadLine());

            if (num01 > num02 && num03 > num04 || num01 < num02 && num03 < num04)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.Read();
        }
    }
}
