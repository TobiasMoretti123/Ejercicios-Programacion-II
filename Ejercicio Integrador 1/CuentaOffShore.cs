using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Integrador_1
{
    public class CuentaOffShore
    {
        private Cliente _duenio;
        private int _numeroDeCuenta;
        private double _saldo;

        public Cliente Duenio
        {
            get { return _duenio; }
        }

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public CuentaOffShore(Cliente duenio, int numero, double saldoInicial)
        {
            this._duenio = duenio;
            this._numeroDeCuenta = numero;
            this._saldo = saldoInicial;
        }

        public CuentaOffShore(string nombre,Cliente.eTipoCliente tipoCliente, int numero, double saldoInicial)
            : this(new Cliente(tipoCliente,nombre),numero,saldoInicial)
        {
            
        }

        public static explicit operator int (CuentaOffShore cos)
        {
            return cos._numeroDeCuenta;
        }

        public static bool operator != (CuentaOffShore cos1, CuentaOffShore cos2)
        {
            return !(cos1 == cos2);
        }

        public static bool operator ==(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            return cos1._numeroDeCuenta == cos2._numeroDeCuenta && cos2.Duenio.GetAlias() == cos1.Duenio.GetAlias();
        }

    }
}
