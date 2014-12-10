using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Sub_Mul_Div_problem2App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number : " );
            int Num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Second Number : " );
             int Num2 = Convert.ToInt32(Console.ReadLine());
          
            

            int Add = Num1 + Num2;
            int Sub = Num1 - Num2;
            int Mul = Num1 * Num2;
            int Div = Num1 / Num2;

            Console.WriteLine("Addition Result: " + Add);
            Console.WriteLine("Subtraction Result: " + Sub);
            Console.WriteLine("Multiplication Result: " + Mul);
            Console.WriteLine("Division Result: " + Div);
            Console.ReadKey();
        }
    }
}
