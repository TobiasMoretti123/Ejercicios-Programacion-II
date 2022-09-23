using System;
using Biblioteca;

namespace E1C3_Creo_que_necesito_un_prestamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta;

            cuenta = new Cuenta("Tobias", 1000m);

            //Muestro por default
            Console.WriteLine(cuenta.Mostrar());
            Console.ReadKey();

            //Ingreso y muestro nuevo
            cuenta.Ingresar(2000m);
            Console.WriteLine(cuenta.Mostrar());
            Console.ReadKey();

            //Debito y muestro nuevo
            cuenta.Retirar(4000m);
            Console.WriteLine(cuenta.Mostrar());
            Console.ReadKey();
        }
    }
}
