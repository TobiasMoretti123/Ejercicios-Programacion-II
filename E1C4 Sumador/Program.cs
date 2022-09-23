using System;
using System.Text;
using Biblioteca;

namespace E1C4_Sumador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Sumador s1 = new Sumador();
            Sumador s2 = new Sumador();

            sb.AppendLine("Suma 1: " + s1.Sumar(2, 3).ToString());

            sb.AppendLine("Suma 2: " + s2.Sumar("hola ", "mundo"));
            //sb.AppendLine("Suma 2: " + s2.Sumar("chau ", "mundo"));

            if (s1 | s2)
            {
                sb.AppendLine($"La cantidad de sumas es igual Suma 1: {(int)s1} - Suma 2: {(int)s2}");
                sb.AppendLine($"Y la suma de sus sumas es: {s1 + s2}");
            }
            else
            {
                sb.AppendLine($"La cantidad de sumas es distinta Suma 1: {(int)s1} - Suma 2: {(int)s2}");
                sb.AppendLine($"Y la suma de sus sumas es: {s1 + s2}");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
