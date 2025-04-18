using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class Program
    {
            //functions

        static string saludar(string name) //funcion que recibe un string y devuelve un string
        {
            return $"hola {name} eres un pendejo!";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(saludar("miguel"));
            


        }
    }
}
