using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosGeometricos
{
    public abstract class FiguraGeometrica
    {
        protected float area;
        protected float volumen;
        protected string error;

        public float Area
        {
            get { return area; }
        }

        public float Volumen
        {
            get { return volumen; }
        }

        public string Error
        {
            get { return error; }
        }

        public abstract bool HallarArea();
        public abstract bool HallarVolumen();

    }
}
