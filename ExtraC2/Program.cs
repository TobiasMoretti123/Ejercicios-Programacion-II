﻿using System;

namespace ExtraC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "hola mundo";

            Sello.color = ConsoleColor.Red;

            Sello.ImprimirEnColor();

            Console.WriteLine(Sello.Imprimir());

            Console.ResetColor();
        }
    }
}
