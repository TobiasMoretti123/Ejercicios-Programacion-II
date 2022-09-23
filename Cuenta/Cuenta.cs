using System;
using System.Text;

namespace Biblioteca
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public decimal GetCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Cuenta pertenece a: {this.GetTitular()} ");
            sb.AppendLine($"Posee ${this.GetCantidad()} en la cuenta");

            return sb.ToString();
        }

        public void Ingresar(decimal ingreso)
        {
            if (ingreso > 0)
            {
                this.cantidad+=ingreso;
            }
        }

        public void Retirar(decimal debito)
        {
            if(debito > 0)
            {
                this.cantidad -= debito;
            }       
        }
    }
}
