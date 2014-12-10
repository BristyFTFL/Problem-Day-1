using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToHundredPrintApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1 ;i<=100;i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
