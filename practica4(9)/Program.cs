using System;

namespace Problema_9
{
    class Multiplicar
    {
        public static void Main(string[] args)
        {
            int number = 0;

            Console.WriteLine("Introduce un número:");
            number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine(number + "x" + i + "=" + (i * number));
            }


            Console.Write("Press -1 o enter para continue .");
            Console.ReadKey(true);
        }
    }
}
