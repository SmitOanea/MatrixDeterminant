using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriceAlocataDinamic
{
    public class MatricePatratica : MatriceAlocataDinamic.MatriceOarecare
    {
        public int Determinant()
        {
            int det;
            if (NrLin == 1)
                return mat[0][0];
            int i, j;
            det = 0;
            i = 0;
            for (j = 0; j < NrCol; ++j)
            {
                ///construiesc matricea care ramane
                MatricePatratica aux;
                aux = new MatricePatratica();

                aux.set_size(NrLin - 1, NrLin - 1);

                for (int i1 = 1; i1 < NrLin; ++i1)
                    for (int j1 = 0; j1 < NrLin; ++j1)
                    {
                        if (j1 < j)
                            aux[i1 - 1][j1] = mat[i1][j1];
                        if (j1 > j)
                            aux[i1 - 1][j1 - 1] = mat[i1][j1];
                    }
                int pow;
                if ((i + j) % 2 == 0)
                    pow = 1;
                else
                    pow = -1;
                det += pow * mat[i][j] * aux.Determinant();
            }
            return det;
        }


        public MatricePatratica()
        {
            NrLin = NrCol = 0;
        }

        public MatricePatratica(int nrl)
        {
            NrLin = NrCol = nrl;
            mat = new Vector[nrl];
            int i;
            for (i = 0; i < NrLin; ++i)
                mat[i] = new Vector();
            for (i = 0; i < NrLin; ++i)
                mat[i].set_size(NrCol);
        }
        public MatricePatratica(MatricePatratica A)
        {
            int i;
            set_size(A.NrLin, A.NrCol);
            for (i = 0; i < A.NrLin; ++i)
                mat[i] = A.mat[i];
        }
    }
}
