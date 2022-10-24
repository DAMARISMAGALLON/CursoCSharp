using System;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            // for (int i = 0; i <= 9; i++)
            // {
            //     if (i % 2 == 0)
            //         Console.WriteLine(i);
            // }

            Console.WriteLine("Teclea un número");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            for(int i = 1; i <= n; i++)
            {
                suma = suma + i;
                //suma += i;
            }
            Console.WriteLine("La suma de todos los números del 1 al " + n +" es "+ suma);
        }
    }
}
