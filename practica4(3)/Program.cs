using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Mes = new int[13];

            Mes[1] = 31;
            Mes[2] = 28;
            Mes[3] = 31;
            Mes[4] = 30;
            Mes[5] = 31;
            Mes[6] = 30;
            Mes[7] = 31;
            Mes[8] = 31;
            Mes[9] = 30;
            Mes[10] = 31;
            Mes[11] = 30;
            Mes[12] = 31;



            Console.WriteLine("ingrese el numero del mes: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Mes[n] + " Dias ");

            Console.ReadKey();

        }
    }
}