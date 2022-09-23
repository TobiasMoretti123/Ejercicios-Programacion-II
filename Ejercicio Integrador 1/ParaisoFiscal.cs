using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Integrador_1
{
    public class ParaisoFiscal
    {
        private List<CuentaOffShore> _listadoCuentas;
        private eParaisosFiscales _lugar;
        static int cantidadCuentas;
        static DateTime fechaInicioActividades;

        public enum eParaisosFiscales
        {
            Anguila,
            Belice,
            Delaware,
            Gibraltar,
            Hong_Kong,
            Mauricio,
            Panama,
            Seychelles,
            Singapur,
            Suiza
        }

        static ParaisoFiscal()
        {
            ParaisoFiscal.cantidadCuentas = 0;
            ParaisoFiscal.fechaInicioActividades = DateTime.Now;
        }

        private ParaisoFiscal()
        {
            this._listadoCuentas = new List<CuentaOffShore>();
        }

        private ParaisoFiscal(eParaisosFiscales lugar) : this()
        {
            this._lugar = lugar;
        }

        public void MostrarParaiso()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Fecha de inicio de actividades: {ParaisoFiscal.fechaInicioActividades}");
            sb.AppendLine($"Lugar de radicacion: {this._lugar}");
            sb.AppendLine($"Cantidad cuentas offshore: {ParaisoFiscal.cantidadCuentas}");
            sb.AppendLine("Listado de cuentas offshores");
            foreach(CuentaOffShore cos in _listadoCuentas)
            {
                sb.AppendLine(cos.Duenio.RetornarDatos(cos.Duenio));
                sb.AppendLine($"Numero de cuenta: {((int)cos).ToString()}");
                sb.AppendLine($"Saldo: {cos.Saldo}");
            }
            Console.WriteLine(sb.ToString());
        }

        public static implicit operator ParaisoFiscal(eParaisosFiscales epf)
        {
            ParaisoFiscal pf = new ParaisoFiscal(epf);
            return pf;
        }

        public static bool operator == (ParaisoFiscal pf, CuentaOffShore cos)
        {
            foreach (CuentaOffShore c in pf._listadoCuentas)
            {
                if (c == cos)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(ParaisoFiscal pf, CuentaOffShore cos)
        {
            return !(pf == cos);
        }

        public static ParaisoFiscal operator + (ParaisoFiscal pf, CuentaOffShore cos)
        {
            if (pf!= cos)
            {
                pf._listadoCuentas.Add(cos);
                cantidadCuentas++;
                Console.WriteLine("Se agrego la cuenta al paraiso...\n");
            }
            return pf;
        }

        public static ParaisoFiscal operator -(ParaisoFiscal pf, CuentaOffShore cos)
        {
            if (pf == cos)
            {
                pf._listadoCuentas.Remove(cos);
                cantidadCuentas--;
                Console.WriteLine("Se elimino la cuenta del paraiso...\n");
            }
            return pf;
        }
    }
}
