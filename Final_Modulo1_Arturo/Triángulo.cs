using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Modulo1_Arturo
{
    public class Triángulo : FiguraGeometrica, Poligono
    {
        public double area(double valor1, double valor2)
        {
            return ((valor1*valor2) / 2);
        }
    }
}
