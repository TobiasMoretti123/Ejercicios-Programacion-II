using System;

namespace E5C1_Tirame_un_centro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centro;
            int numeroIngresado;

            Console.WriteLine("Ingrese numero a averiguar el centro: ");

            while (int.TryParse(Console.ReadLine(), out numeroIngresado))
            {
                for (centro = 1; centro < numeroIngresado; centro++)
                {
                    int sumaAntes = 0;
                    for (int i = 0; i < centro; i++)
                    {
                        sumaAntes += i;
                    }

                    int sumaDesp = 0;
                    for (int j = centro + 1; j <= sumaAntes; j++)
                    {
                        if ((sumaAntes == sumaDesp) || (sumaDesp > sumaAntes))
                            break;

                        sumaDesp += j;
                    }

                    if (sumaAntes == sumaDesp)
                    {
                        Console.WriteLine("Es un centro numero: {0}", centro);
                    }
                }
            }
            Console.WriteLine("No es un numero");
            Console.ReadKey();
        }
    }
}
