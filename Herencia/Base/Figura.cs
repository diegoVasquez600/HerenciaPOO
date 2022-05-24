using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Base
{
    public abstract class Figura
    {

        public abstract float PosicionX { get; set; }
        public abstract float PosicionY { get; set; }

        public abstract void DibujarFigura();
        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();
    }
}
