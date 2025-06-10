using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Loop_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //برنامه دو عدد میگیرد و میگوید بین دو عدد چند مضرب 7 وجود داردد
            Console.Write("Enter a number1:");
            int num01 = int.Parse(Console.ReadLine());
            Console.Write("Enter a number2:");
            int num02 = int.Parse(Console.ReadLine());

            int min = num01;
            int max = num02;


            //شمارنده تعداد مضرب 7
            int counter = 0;

            if(num01 > num02)
            {
                min = num02;
                max = num01;
            }    

            for (int i = min; i <= max; i++) 
            {
              if( i % 7 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine("numbers divisible by 7:",counter);

            Console.ReadLine();
        }
    }
}
