using System;

namespace E2C1_Error_al_cubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado = 0;
            int numeroCuadrado;
            int numeroCubo;

            Console.WriteLine("Ingresar un numero: ");

            if(int.TryParse(Console.ReadLine(),out numeroIngresado) && numeroIngresado > 0)
            {
                numeroCuadrado = (int)Math.Pow(numeroIngresado, 2);
                numeroCubo = (int)Math.Pow(numeroIngresado, 3);

                Console.WriteLine($"Numero: {numeroIngresado}\nNumero al cuadrado: {numeroCuadrado}\nNumero al cubo: {numeroCubo}");
            }
            else
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }
        }
    }
}
