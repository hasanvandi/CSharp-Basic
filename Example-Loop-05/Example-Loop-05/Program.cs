using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Loop_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //تا وقتی عدد صفر وارد نشده از کاربر عدد گرفته شود و سپس معدل اعداد گرفته شده را چاپ کند
            //صفر جز معدل حساب نمیشود و فقط پایان دهنده اعداد هست


            double score;
            double sum = 0;
            int counter = 0;
            for (; ;)
            {
                Console.Write($"Enter Score{counter + 1}:");
                score = double.Parse(Console.ReadLine());
                if (score == 0)
                {
                    break;
                }
                sum = sum + score;
                counter++;
            }

            double avg = sum / counter;
            Console.WriteLine($"Avrage:{avg}");

            Console.ReadLine();
        }
    }
}
