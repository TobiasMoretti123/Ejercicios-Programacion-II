using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1C2_Validador_de_rangos
{
    public static class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool validado = false;

            if (valor > min && valor <= max)
            {
                validado = true;
            }

            return validado;
        }
    }
}
