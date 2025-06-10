using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Loop_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //برنامه دنباله اعداد زیر را تا زمانی که کوچک تر از1000 اند چاپ کند
            //1-2-4-7-11-16-22-29...


            int num = 1;
            for(int i = 1;num < 1000; i++)
            {
                Console.WriteLine(num);
                num = num + i;
            
            }

            Console.ReadLine();
        }
    }
}
