using System;
using Biblioteca;

namespace E2C3_Vos_cuantas_primaveras_tenes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Tobias", new DateTime(1999, 2, 3), "41668744");
            Persona persona2 = new Persona("Ivan", new DateTime(1993, 1, 18), "37280697");
            Persona persona3 = new Persona("Juan", new DateTime(2010, 4, 20), "45900230");

            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona3.Mostrar());
        }
    }
}
