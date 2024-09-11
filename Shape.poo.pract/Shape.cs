using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.poo.pract
{
    public abstract class Shape
    {
        protected double Width;
        protected double Height;

        protected Shape(double width, double height) 
        { 
            Width = width;
            Height = height;
              
        }


        public abstract double CalculateSurface();
    }
}
