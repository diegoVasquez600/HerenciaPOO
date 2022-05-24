using Herencia.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Figures
{
    public class Circulo : Figura
    {
        public override float PosicionX { get; set; }
        public override float PosicionY { get; set; }

        public Circulo(float PosicionY)
        {
            this.PosicionX = (float)Math.PI;
            this.PosicionY = PosicionY;
            DibujarFigura();
        }

        public override void CalcularArea()
        {
            var Radio = PosicionY;
            var Area = PosicionX * Math.Pow(Radio, 2);
            Console.WriteLine($"El area del circulo es: {Area}");
        }

        public override void CalcularPerimetro()
        {
            var Radio = PosicionY;
            var Perimetro = 2 * (PosicionX * Radio);
            Console.WriteLine($"El perimetro del circulo es: {Perimetro}");
        }

        public override void DibujarFigura()
        {
            float radio;
            int x, y;
            radio = PosicionY;
            for (x = 0; x <= radio * 2; x++) //Altura
            {
                for (y = 0; y <= radio * 2; y++) //Rellenar
                {
                    //Ecuacion circunferencia
                    //((X-h)^2) + ((y-k)^2) = radio^2 
                    if (Math.Pow(y - radio, 2) + Math.Pow(x - radio, 2) <= (int)Math.Pow(radio, 2))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(" ");
            }
        }
    }
}
