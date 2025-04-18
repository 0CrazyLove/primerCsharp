using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bucle for && table multiplìcation

            Console.Write("inserte un numero para generar la tabla del 1 al 10: ");
            int number = int.Parse(Console.ReadLine()); //insertar el numero que quieres para la tabla
            for (int i = 1; i <=10; i++)
            {
                int result = (number * i);
                    
                Console.WriteLine($"{number} * {i} = {result}");
            }



        }
    }
}
