using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriceAlocataDinamic
{
    public class Vector
    {
        protected int[] v;
        protected int dim;

        public int get_dim()
        {
            return dim;
        }

        //operatori
        public int this[int i]
        {
            get
            {
                return v[i];
            }
            set
            {
                v[i] = value;
            }
        }

        public bool Egal(Vector other)
        {
            if (this.dim != other.dim)
                return false;
            int i;

            for (i = 0; i < this.dim; i++)
                if (this[i] != other[i])
                    return false;
            return true;
        }

        public bool Diferit(Vector other)
        {
            return !(this.Egal(other));
        }

        public void set_size(int sizze)
        {
            if (dim > 0)
                v = null;
            dim = sizze;
            v = new int[dim];
        }

        public void free()
        {
            if (dim > 0)
                v = null;
        }

        ///constructori
        public Vector()
        {
            dim = 0;
        }

        public Vector(int n)
        {
            this.dim = n;
            this.v = new int[this.dim];
        }

        public Vector(Vector other)
        {
            if (dim > 0)
                v = null;
            dim = other.dim;
            v = new int[dim];
            int i;
            for (i = 0; i < dim; ++i)
                v[i] = other[i];
        }

        ~Vector()
        {
            free();
        }

    }
           
}
