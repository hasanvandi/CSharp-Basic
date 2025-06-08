using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Example_Loop_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //دو عدد گرفته و اعداد بین ان دو را چاپ کنید
            Console.Write("Enter number1:");
            int num01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number2:");
            int num02 = Convert.ToInt32(Console.ReadLine());

            int max = num01;
            int min = num02;



            if (num01 > num02) 
            {
                max = num01;
                min = num02;
            }
            else
            {
                max = num02;
                min = num01;
            }
            

            for(int i = min; i <= max ; i++)
            {
                Console.WriteLine(i);
            }

       
            Console.ReadLine();
        }
    }
}
