using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("¿Cuál es tu nombre?");
            string name = Console.ReadLine();
            Console.WriteLine("Escribe el número 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el número 2");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("Hola " + name + ",la suma de " + num1 + " y " + num2 + " es: " + sum +".");
            Console.WriteLine("Escribe el número 3");
            int num3 = int.Parse(Console.ReadLine());
            if(sum > num3){
                Console.WriteLine("La suma de " + num1 + " y " + num2 + " es mayor que " + num3 + ".");
            }
            else{
                Console.WriteLine(num3 +" es mayor que la suma de "+ num1 + " y "+ num2 +".");
            }
        }
    }
}
