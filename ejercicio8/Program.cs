using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //utilizando un bucle para recorrer los elementos del array

            //inciando el array
            int[] age;

            age = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for(int i = 0; i < age.Length; i++)
            {
                Console.WriteLine(age[i]);
            }




        }
    }
}
