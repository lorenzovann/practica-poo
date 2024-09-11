using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.poo.pract
{
    public class Program
    {
        public static void Main()
        {
            // Crear un array de formas
            Shape[] shapes = new Shape[]
            {
            new Rectangle(10, 5),
            new Triangle(10, 5),
            new Circle(7)
            };

           
            double[] areas = new double[shapes.Length];

            // Calcular las áreas y almacenarlas en la matriz
            for (int i = 0; i < shapes.Length; i++)
            {
                areas[i] = shapes[i].CalculateSurface();
            }

            
            for (int i = 0; i < areas.Length; i++)
            {
                Console.WriteLine($"Área de la forma {i + 1}: {areas[i]}");
            }
        }
    }
}

