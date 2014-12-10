using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallAndBigNumberFind_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number : ");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number : ");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            if(Num1 < Num2)
            {
                Console.WriteLine("Small Number is : " + Num1);
                Console.WriteLine("Large Number is : " + Num2);
            }
            else if(Num1 > Num2)
            {
                Console.WriteLine("Small Number is : " + Num2);
                Console.WriteLine("Large Number is : " + Num1);
            }
            else
            {
                Console.WriteLine("The Number is Equal");
            }

            Console.ReadKey();
        }
    }
}
