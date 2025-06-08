using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_if_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //نمره دریافت کن زیر ده بود ضربش کن در عدد مورد نظر اگر بین 9 و 10 بود تبدیل به 10 کن و نمایشش بده
            Console.WriteLine("enter your score:");
            double score = Convert.ToInt32(Console.ReadLine());



            if (score < 10)
            {
                score = score * 1.2;
                if (score > 9 && score < 10)
                {
                    score = 10;
                }
            }

            Console.WriteLine(score);

            Console.ReadLine();
        }
    }
}
