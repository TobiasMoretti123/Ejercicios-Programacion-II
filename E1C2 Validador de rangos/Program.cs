using System;

namespace E1C2_Validador_de_rangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int min = int.MaxValue;
            int max = int.MinValue;
            int suma = 0;
            float promedio;
            int i = 0;

            for (; i<10; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                
                if (int.TryParse(Console.ReadLine(),out numeroIngresado) && Validador.Validar(numeroIngresado, -100, 100))
                {
                    if(numeroIngresado < min)
                    {
                        min = numeroIngresado;
                    }

                    if(numeroIngresado > max)
                    {
                        max = numeroIngresado;
                    }

                    suma += numeroIngresado;
                }
                else
                {
                    Console.WriteLine("Numero debe ser entre (-100 - 100)");
                }
            }

            promedio = (float)suma / i;

            Console.WriteLine($"Minimo: {min}\nMaximo: {max}\nPromedio: {promedio}");
        }
    }
}
