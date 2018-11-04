using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriceAlocataDinamic
{

    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            Console.Write("Numarul de linii (si coloane) al matriei patratice: ");
            n = int.Parse(Console.ReadLine());
            MatricePatratica A = new MatricePatratica(n);

            for (i = 0; i < n; ++i)
                for (j = 0; j < n; ++j)
                    A[i][j] = int.Parse(Console.ReadLine());

            Console.WriteLine("Determinantul este: " + A.Determinant());
            Console.ReadLine();
        }
    }
}
