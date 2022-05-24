using Herencia.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Figures
{
    public class Rectangulo : Figura
    {
        public override float PosicionX { get; set; }
        public override float PosicionY { get; set; }

        public Rectangulo(float PosicionX, float PosicionY)
        {
            //TODO: Complete Figure print on Console
            this.PosicionX = PosicionX;
            this.PosicionY = PosicionY;
            DibujarFigura();
        }

        public override void CalcularArea()
        {
            var Base = PosicionX;
            var Altura = PosicionY;
            var Area = Base * Altura;
            Console.WriteLine($"El area del rectangulo es: {Area}");
        }

        public override void CalcularPerimetro()
        {
            var Base = PosicionX;
            var Altura = PosicionY;
            var perimetro = 2 * (Base + Altura);
            Console.WriteLine($"El perimetro del rectangulo es: {perimetro}");
        }

        public override void DibujarFigura()
        {
            float Base, altura;
            int x, y;
            Base = PosicionX;
            altura = PosicionY;
            
            for (x = 1; x <= altura; x++)
            {
                for (y = 1; y <= Base; y++)
                {
                    Console.Write("* ", y);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
