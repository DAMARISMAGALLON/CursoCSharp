using System;

namespace basic_logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el número 1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el segundo número");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el número 1");
            int n3 = int.Parse(Console.ReadLine());

            int tmp = 0;

            if (n1 > n2)
            {
                tmp = n1;
            }
            else
                tmp = n2;

            if (tmp < n3)
                tmp = n3;

                Console.WriteLine("El número " + tmp + " es mayor.");

        }
    }
}
