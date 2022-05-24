using Herencia.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Figures
{
    public class Triangulo : Figura
    {

        public override float PosicionX { get; set; }
        public override float PosicionY { get; set; }
       
        public Triangulo(float PosicionX, float PosicionY)
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
            var Area = Base * Altura / 2;
            Console.WriteLine($"El area del triangulo es: {Area}");
        }

        public override void CalcularPerimetro()
        {
            var Base = PosicionX;
            var Altura = PosicionY;
            var Perimetro = (2 * Altura) + Base;
            Console.WriteLine($"El perimetro del triangulo es: {Perimetro}");
        }

        public override void DibujarFigura()
        {
            float altura = PosicionY;
            int x, y;
            Console.WriteLine(" ");

            for (x = 1; x <= altura; x++)
            {
                for (y = (int)(altura - x); y > 0; y--)
                {
                    Console.Write(" ");
                }
                for (y = 1; y < x; y++)
                {
                    Console.Write("**");
                }
                Console.WriteLine("*");
            }
        }
    }
}
