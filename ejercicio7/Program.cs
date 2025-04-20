using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    internal class Program
      

    {

        static void Main(string[] args)
        {
            //arrays     
            string[] names = { "juan" , "miguel" , "andres" };
            Console.WriteLine(names[1]);
            //cambiando el valor del indice 0 del array
            names[0]= "samandy";

            Console.WriteLine(names[0]);

            //usando la propiedad Length 
            Console.WriteLine(names.Length);


            //declarando el array para luego asignarle valores
            string[] brawl;

            brawl = new string[3];
            brawl[0]= "pendejo";
            brawl[2]= "tonto";
            brawl[1]= "feo";
            Console.WriteLine(brawl[2]);









        }
    }
}
