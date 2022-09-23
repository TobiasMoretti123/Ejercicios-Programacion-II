using System;
using System.Text;

namespace Ejercicio_Integrador_1
{
    public class Cliente
    {
        private string _aliasParaIncognito;
        private string _nombre;
        private eTipoCliente _tipoDeCliente;

        public enum eTipoCliente
        {
            PoliticoCorrupto,
            EmpresarioCorrupto,
            JugadorDeFutbol,
            Financista,
            SinTipo
        }

        private Cliente()
        {
            this._aliasParaIncognito = "Sin alias";
            this._nombre = "NN";
            this._tipoDeCliente = eTipoCliente.SinTipo; 
        }

        public Cliente(eTipoCliente tipoCliente) :this()
        {
            this._tipoDeCliente=tipoCliente;
        }

        public Cliente(eTipoCliente tipoCliente, string nombre) :this(tipoCliente)
        {
            this._nombre=nombre;
        }

        private void CrearAlias()
        {
            Random rand = new Random();
            this._aliasParaIncognito = rand.Next(1000, 9999).ToString() + this._tipoDeCliente;
        }

        public string GetAlias()
        {
            string alias = this._aliasParaIncognito;
            if(alias == "Sin alias")
            {
                CrearAlias();
            }
            return this._aliasParaIncognito;
        }

        private string RetornarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre cliente: {this._nombre}");
            sb.AppendLine($"Alias: {this._aliasParaIncognito}");
            sb.AppendLine($"Tipo cliente: {this._tipoDeCliente}");

            return sb.ToString();
        }

        public string RetornarDatos(Cliente unCliente)
        {
            return unCliente.RetornarDatos();
        }
    }
}
