using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_if_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //عددی از کاربر دریافت نموده و آنرا به حروف چاپ میکنیم یک دو سه و عهر عددی غیر از این سه تا پیغام مناسب
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());
            string num;
            switch (number)
            {
                case 1:
                    num = "One";
                    break;
                case 2:
                    num = "Two";
                    break;
                case 3:
                    num = "Three";
                    break;
                default:
                    num = "Invalid Number";
                    break;
            }

            Console.WriteLine(num);

            Console.ReadLine();
        }
    }
}
