using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_if_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //گرفتن سه عدد توسط کاربر و تشکیل مثلث و چک کردن شرط متساوی الساقین یا متساوی الاضلاع یا معمولی بودن مثلث
            Console.WriteLine("Enter sie 1");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter sie 2");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter sie 3");
            double num3 = Convert.ToDouble(Console.ReadLine());
            //شرط تشکیل یه مثلث
            if (num1 + num2 > num3 && num1 + num3 > num2 && num2 + num3 > num1)
            {
                if (num1 == num2 && num2 == num3)
                {

                    Console.WriteLine("mosalas motesaviol azla ast.");

                }
                else if (num1 == num2 || num1 == num3 || num2 == num3)
                {
                    if (num1 != num3 || num2 != num3 || num1 != num3)
                    {
                        Console.WriteLine("mosalas motesaviol saghayen ast.");
                    }
                }
                else
                {
                    Console.WriteLine("mosalas mamouli ast.");
                }
            }
    }
}
