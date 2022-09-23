using System;

namespace E6C1_Anios_bisiestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anioInicio;
            int anioFin;

            Console.WriteLine("Ingrese año de inicio y año de fin para calcular los bisiestos");
            while (int.TryParse(Console.ReadLine(), out anioInicio) && int.TryParse(Console.ReadLine(), out anioFin))
            {
                if (anioInicio < anioFin)
                {
                    Console.WriteLine("Años bisiesto desde {0} hasta {1}", anioInicio, anioFin);
                    for (int i = anioInicio; i < anioFin; i++)
                    {
                        if (i % 4 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine("año no valido");
        }
    }
}
