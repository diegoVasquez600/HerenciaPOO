using Herencia.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Helpers
{
    public static class MainMenu
    {
       

        public static void GetMenuOptions()
        {
            try
            {
                string option;
                Console.WriteLine("\nTarea Herencia en Programacion Orientada a Objetos Herramientas II \n Profesora: Paola Andrea Quintero Aguilar.\n Estudiante: Diego Alejandro Rios Vasquez.\n");
                Console.WriteLine("Menu de Opciones Figuras Geometricas\n Seleciona una Figura del Menu:\n");
                Console.WriteLine("1) Circulo\n2) Triangulo\n3) Rectangulo\n");
                option = Console.ReadLine();
                float x, y;
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Circulo\n");
                        Console.WriteLine("Inserte el Radio del Circulo: \n");
                        x = float.Parse(Console.ReadLine());
                        Circulo circulo = new(x);
                        circulo.CalcularPerimetro();
                        circulo.CalcularArea();
                        GetMenuOptions();
                        break;
                    case "2":
                        Console.WriteLine("Triangulo\n");
                        Console.WriteLine("Inserte el valor de Base (X): \n");
                        x = float.Parse(Console.ReadLine());
                        Console.WriteLine("Inserte el valor de Altura (Y): \n");
                        y = float.Parse(Console.ReadLine());
                        Triangulo triangulo = new(x, y);
                        triangulo.CalcularArea();
                        triangulo.CalcularPerimetro();
                        GetMenuOptions();
                        break;
                    case "3":
                        Console.WriteLine("Rectangulo\n");
                        Console.WriteLine("Inserte el valor de Base (X): \n");
                        x = float.Parse(Console.ReadLine());
                        Console.WriteLine("Inserte el valor de Altura (Y): \n");
                        y = float.Parse(Console.ReadLine());
                        Rectangulo rectangulo = new(x, y);
                        rectangulo.CalcularArea();
                        rectangulo.CalcularPerimetro();
                        GetMenuOptions();
                        break;
                    default:
                        Console.WriteLine("\nOpcion Invalida Intentalo Nuevamente\n");
                        GetMenuOptions();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                GetMenuOptions();
            }
        }
    }
}
