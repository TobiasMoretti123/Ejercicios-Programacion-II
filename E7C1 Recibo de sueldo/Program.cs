using System;

namespace E7C1_Recibo_de_sueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorHora;
            string nombre;
            int antiguedad;
            int cantidadDehoras;
            int importeTotalEnBruto;
            int importeTotalEnNeto;
            int acumuladorValorHora = 0;
            int acumuladorCantidadHoras = 0;
            int descuento = 13;
            string respuesta = "si";

            do
            {
                Console.WriteLine("Ingrese valor por hora: ");
                valorHora = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nombre de empleado: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese antiguedad en años: ");
                antiguedad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de horas trabajadas por mes: ");
                cantidadDehoras = int.Parse(Console.ReadLine());

                acumuladorCantidadHoras += cantidadDehoras;
                acumuladorValorHora += valorHora;

                importeTotalEnBruto = acumuladorValorHora * acumuladorCantidadHoras + (antiguedad * 150);
                importeTotalEnNeto = importeTotalEnBruto - (importeTotalEnBruto * descuento / 100);

                acumuladorCantidadHoras = 0;
                acumuladorValorHora = 0;

                Console.WriteLine("El recibo correspondiente de {0}, con una antiguedad de {1} años y un valor hora de {2}. " +
                    "\nEs de {3}$ en bruto y {4}$ en neto.", nombre, antiguedad, valorHora, importeTotalEnBruto, importeTotalEnNeto);

                Console.WriteLine("Desea agregar otro empleado? ");
                respuesta = Console.ReadLine();

            } while (respuesta == "si");
        }
    }
}
