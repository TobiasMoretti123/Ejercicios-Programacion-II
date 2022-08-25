using System;

namespace E1C1_Maximo__minimo_y_promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            float promedio;
            int suma = 0;
            int i = 0;

            for ( ; i<5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numeroIngresado = int.Parse(Console.ReadLine());

                if(numeroIngresado < minimo)
                {
                    minimo = numeroIngresado;
                }

                if(numeroIngresado > maximo)
                {
                    maximo = numeroIngresado;
                }

                suma += numeroIngresado;
            }

            promedio = (float)suma / i;

            Console.WriteLine($"Maximo: {maximo}\nMinimo: {minimo}\nPromedio: {promedio}");
        }
    }
}
