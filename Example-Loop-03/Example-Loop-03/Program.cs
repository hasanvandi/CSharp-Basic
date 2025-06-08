using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Loop_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //برنامه اعداد را تا 100 ده تا ده تا چاپ میکند 10 20 30 40 ...
            for(int i = 10;i <= 100;i = i + 10)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
