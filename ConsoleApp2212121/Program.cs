using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2212121
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int a, b, c;
                Console.Write("Enter a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter b: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter c: ");
                c = Convert.ToInt32(Console.ReadLine());




                var min = new[] { a, b, c }.Min();


                Console.WriteLine("min " + min);


                Console.ReadKey();

            }
        }
    }
}