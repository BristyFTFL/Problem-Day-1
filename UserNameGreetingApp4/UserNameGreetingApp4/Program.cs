using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNameGreetingApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi "+ name +" Good "+"Day");
            Console.ReadKey();
        }
    }
}
