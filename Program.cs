using System;

namespace n_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, x;
            Console.WriteLine("Escriu el valor de a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriu el valor de b");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
                Console.WriteLine("Error divisió entre 0");
            else
            {
                x = -b / a;
                Console.WriteLine("El resultat es "+x);
                Console.WriteLine("El resultat es {0}", x);
                Console.WriteLine($"El resultat es {x}");
            }
        }
    }
}