using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4C1_Un_numero_perfecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] p = new int[11];
            int b = 0, a, k, i, x;
            String cad = "";
            for (k = 2; k < 702; k++)
            {
                a = 0;
                for (i = 1; i < (k + 2); i++)
                {
                    if (k % i == 0)
                    {
                        a = a + i;
                        if ((a - k) == k)
                        {
                            p[b] = k;
                            b++;
                        }
                    }
                }
            }
            for (x = 0; x < b; x++)
            {
                cad = cad + " " + p[x] + " Es un numero perfecto\n";
            }
            Console.WriteLine(cad);
            Console.ReadLine();
        }
    }
}
