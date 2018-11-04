using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriceAlocataDinamic
{
    public partial class MatriceOarecare
    {
        protected int NrLin, NrCol;
        protected Vector[] mat;

        public int get_NrLin()
        {
            return NrLin;
        }
        public int get_NrCol()
        {
            return NrCol;
        }

        public Vector this[int i]
        {
            get
            {
                return mat[i];
            }
            set
            {
                mat[i] = value;
            }
        }

        public bool Egal(MatriceOarecare A)
        {
            if (NrLin != A.NrLin || NrCol != A.NrCol)
                return false;
            int i;
            for (i = 0; i < NrLin; ++i)
                if (mat[i] != A[i])
                    return false;
            return true;
        }

        public bool Diferit (MatriceOarecare A)
        {
            return !(Egal(A));
        }


        public void set_size(int nrl, int nrc)
        {
            int i;

            if (NrLin > 0)
            {
                for (i = 0; i < NrLin; i++)
                    mat[i] = null;
                mat = null;
            }

            NrLin = nrl;
            NrCol = nrc;
            mat = new Vector[NrLin];
            for (i = 0; i < NrLin; ++i)
                mat[i] = new Vector();

            for (i = 0; i < NrLin; ++i)
                mat[i].set_size(nrc);
        }

        public void free()
        {
            if (NrLin > 0)
            {
                for (int i = 0; i < NrLin; ++i)
                    mat[i] = null;
                mat = null;
            }
            NrLin = NrCol = 0;
        }

        //constructori si destructor
        public MatriceOarecare()
        {
            NrLin = 0;
            NrCol = 0;
        }
        public MatriceOarecare(int nrlin, int nrcol)
        {
            int i;
            NrLin = nrlin;
            NrCol = nrcol;

            mat = new Vector[NrLin];
            for (i = 0; i < NrLin; ++i)
                mat[i] = new Vector();
            for (i = 0; i < NrLin; ++i)
            {
                mat[i].set_size(NrCol);
            }
        }
        public MatriceOarecare(MatriceOarecare A)
        {
            int i;
            set_size(A.NrLin, A.NrCol);
            for (i = 0; i < A.NrLin; ++i)
                mat[i] = A.mat[i];
        }

        ~MatriceOarecare()
        {
            free();
        }

    }
}
