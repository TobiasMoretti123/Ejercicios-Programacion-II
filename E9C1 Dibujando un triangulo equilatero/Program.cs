using System;

namespace E9C1_Dibujando_un_triangulo_equilatero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura;

            Console.WriteLine("Ingrese altura del triangulo: ");
            while (int.TryParse(Console.ReadLine(), out altura) && altura > 0)
            {
                for (int i = 1; i <= altura; i++)
                {
                    for (int j = altura - i; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j < i; j++)
                    {
                        Console.Write("**");
                    }
                    Console.WriteLine("*");

                }
            }
            Console.WriteLine("no es un numero");

            Console.ReadKey();
        }
    }
}
