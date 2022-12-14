using System;
using Ejercicio_Integrador_1;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tobias Moretti";
            Cliente mauri = new Cliente(Cliente.eTipoCliente.PoliticoCorrupto,"Mauri");
            Cliente fariña = new Cliente(Cliente.eTipoCliente.Financista, "Fariña");
            Cliente mesias = new Cliente(Cliente.eTipoCliente.JugadorDeFutbol,"Lio");
            CuentaOffShore messiOff = new CuentaOffShore(mesias, 123, 15000);
            CuentaOffShore mauriOff = new CuentaOffShore(mauri, 678, 25000);
            CuentaOffShore lazaroOff = new CuentaOffShore("Lázaro",
            Cliente.eTipoCliente.EmpresarioCorrupto, 456, 56000);
            CuentaOffShore otraDeMauri = new CuentaOffShore(mauri, 678,
            50000);
            CuentaOffShore fariOff = new CuentaOffShore(fariña, 666, 3500);
            ParaisoFiscal panamaPappers = ParaisoFiscal.eParaisosFiscales.Panama;
            panamaPappers += messiOff;
            panamaPappers += mauriOff;
            panamaPappers += lazaroOff;
            panamaPappers.MostrarParaiso();
            panamaPappers += otraDeMauri;
            panamaPappers -= messiOff;
            panamaPappers -= fariOff;
            panamaPappers.MostrarParaiso();
            Console.ReadLine();
        }
    }
}
