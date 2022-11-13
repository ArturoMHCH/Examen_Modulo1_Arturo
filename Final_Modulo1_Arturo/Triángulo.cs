using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Modulo1_Arturo
{
    public class Triángulo : FiguraGeometrica, Poligono
    {
        public double ladoizq { get; set; }
        public double ladoder { get; set; }
        public double ladobase { get; set; }
        public double altura { get; set; }
        public double area(double valor1, double valor2)
        {
            return ((valor1*valor2) / 2);
        }
        public string ToString()
        {
            return (nombre + " "+area(ladobase, altura).ToString());
        }
}
}
