using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_if_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             نمره دانشاموزی دریافت نمونه در  صورتی که نمره بین 17 تا 20 و 14 تا 17 و 10 تا 14 و زیر ده بود
            پیغام مناسب نمایش داده شود حل با سوییچ
             */

            Console.Write("Enter number:");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 17:
                case 18:
                case 19:
                case 20:
                    Console.WriteLine("Excellent");
                    break;
                case 14:
                case 15:
                case 16:
                    Console.WriteLine("Good");
                    break;
                case 10:                  
                case 11:
                case 12:
                case 13:
                    Console.WriteLine("Middle");
                    break;
                case 9:
                case 8:
                case 7:
                case 6:
                case 5:
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    Console.WriteLine("Fial");
                    break;
                default:
                    Console.WriteLine("Coose between 0 and 20!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
