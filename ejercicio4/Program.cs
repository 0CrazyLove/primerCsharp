using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //conditional if + input
            Console.Write("te gusta miguel-kum? 7W7");
            string answer = Console.ReadLine();
            if(answer != "si" && answer != "no" || string.IsNullOrWhiteSpace(answer))//el "string.IsNullOrWhiteSpace" 
                //sirve para verificar si el valor es null (osea si esta vacio)
            {
                Console.WriteLine("solo dime si o no. Baka 7n7");

            } else if(answer == "si")
            {
                Console.WriteLine(" *se viene de la emocion* ");
            }else if(answer == "no")
            {
                Console.WriteLine("ER~ERES UN BAKA >:<");
            }


        }
    }
}
