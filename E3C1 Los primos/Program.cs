using System;
using System.Collections.Generic;

namespace E3C1_Los_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            string cadena;
            List<int> primos = new List<int>();

            do
            {
                Console.WriteLine("Ingrese un numero: ");

                if(int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    for (int i = 2; i <= numeroIngresado ; i++)
                    {
                        if (EsPrimo(i))
                        {
                            primos.Add(i);
                            
                        } 
                    }
                    primos.Add(numeroIngresado);
                    foreach (int n in primos)
                    {
                        Console.WriteLine(n);
                    }
                }

                Console.WriteLine("Desea iterar nuevamente? ");
                cadena = Console.ReadLine();

            }while(cadena != "salir");
            
        }
        static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    // No es primo 🙁
                    return false;
                }
            }
            // Es primo 🙂
            return true;
        }
    }
}
