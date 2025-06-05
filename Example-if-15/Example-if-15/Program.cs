using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_if_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //از کاربر یه عدد میگیریم و ماه اون عدد رو نمایش میدیم
            Console.Write("Enter Number in range(1,12):");
            int month = Convert.ToInt32(Console.ReadLine());
            string monthString;
            switch (month)
            {
                case 1:
                    monthString = "farvardin";
                    break;
                case 2:
                    monthString = "ordibhersth";
                    break;
                case 3:
                    monthString = "khordad";
                    break;
                case 4:
                    monthString = "tear";
                    break;
                case 5:
                    monthString = "mordad";
                    break;
                case 6:
                    monthString = "shahrivar";
                    break;
                case 7:
                    monthString = "mehr";
                    break;
                case 8:
                    monthString = "aban";
                    break;
                case 9:
                    monthString = "azar";
                    break;
                case 10:
                    monthString = "daay";
                    break;
                case 11:
                    monthString = "bahman";
                    break;
                case 12:
                    monthString = "esfand";
                    break;
                default:
                    monthString = "not find";
                    break;
            }

            Console.WriteLine(monthString);

            Console.ReadLine();

        }
    }
}
