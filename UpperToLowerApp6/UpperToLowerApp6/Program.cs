using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperToLowerApp6
{
    class UpperToLowerApp6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the upper number :");
            int upper = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Please enter the lower number :");
            int lower = Convert.ToInt32(Console.ReadLine());

            for (int i = upper; i >= lower; i--)
            {
                Console.WriteLine(i);
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
