﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraC2
{
    public static class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            return Sello.ArmarFormatoMensaje();
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = color;
        }

        private static string ArmarFormatoMensaje()
        {
            string mensaje = string.Empty;

            for(int i=0 ; i <= Sello.mensaje.Length; i++)
            {
                mensaje += "*"; 
            }

            mensaje += $"*\n*{Sello.mensaje}*\n*";

            for (int i = 0; i <= Sello.mensaje.Length; i++)
            {
                mensaje += "*";
            }

            return mensaje;
        }
    }
}
