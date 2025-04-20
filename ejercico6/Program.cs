using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico6
{
    internal class Program
    {
        //function suma && resta

        static string suma(int a, int b)
        {
            return $"la suma de {a} y de {b} es: {a + b}";
        }
        static string resta(int a, int b)
        {
            return $"la resta de {a} y de {b} es: {a - b}";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("elige una opcion: ");
            Console.WriteLine("1. suma");
            Console.WriteLine("2. resta");
            int option = int.Parse(Console.ReadLine());

            if (option != 1 && option != 2)
            {
                Console.WriteLine("opcion no valida.");
                Main(args);

            }
            else if (option == 1)
            {
                Console.WriteLine("inserte el primer numero: ");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("inserte su segundo numero: ");
                int number2 = int.Parse(Console.ReadLine());
                Console.WriteLine(suma(number1, number2));


            } else if(option == 2)
            {
                Console.WriteLine("inserte el primer numero: ");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("inserte su segundo numero: ");
                int number2 = int.Parse(Console.ReadLine());
                Console.WriteLine(resta(number1, number2));

            }

        }
    }
}
    
