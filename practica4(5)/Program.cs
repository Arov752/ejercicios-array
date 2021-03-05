using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[100];


            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("ingrese los nombres de las personas " + (i + 1));
                nombres[1] = Console.ReadLine();




                if (nombres[1] == "")
                {
                    break;
                }

            }
            Console.WriteLine("los nombres ingresados son: ");

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[1]);
            }

            Console.ReadKey();

        }
    }
}
