using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Modulo1_Arturo
{
    public class Rectangulo : FiguraGeometrica, Poligono
    {
        public double ladobase { get; set; }
        public double ladoalto { get;set; }

        public double area(double valor1, double valor2)
        {
            return (valor1 * valor2);
        }
        public string toString()
        {
            return (nombre + "     " + area(ladobase, ladoalto).ToString());
        }
        public string datos()
        {
            return ("Rectangulo:" + nombre + "   lado base:" + ladobase + "   lado alto:" + ladoalto);
        }
    }
}
