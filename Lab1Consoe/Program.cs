using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Consoe
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!\n");
            string cont;
            do
            {
                Console.Write("Enter Length: ");
                int m = int.Parse(Console.ReadLine());
                Console.Write("Enter Width: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Area: " + m * n);
                Console.WriteLine("Perimeter: " + (2 * m + 2 * n));
                Console.WriteLine("Continue? (y/n)");
                cont = Console.ReadLine();
                Console.WriteLine();

            } while (cont == "y");
            Console.WriteLine("Goodye!");
            

        }
    }



}
