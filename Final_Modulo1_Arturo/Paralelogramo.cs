using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Modulo1_Arturo
{
    public class Paralelogramo : FiguraGeometrica, Poligono
    {
        /*
        Paralelogramo :


           .----------
          .         .
         .         .ladoinclinado
        .angulo   .
        ----------
         ladobase
         */
        public double ladobase { get; set; }
        public double ladoinclinado { get; set; }
        public int angulo { get; set; }
        public double area(double valor1, double valor2)
        {
            return (valor1 * valor2);
        }
        public string toString()
        {
            return (nombre + "     " + area(ladobase, altura()).ToString());
        }
        public double altura()
        {
            return (Math.Sin(angulo)*ladoinclinado);
        }
        public string datos()
        {
            return ("Paralelogramo:" + nombre + "   lado base:" + ladobase + "   lado inclinado:" + ladoinclinado + "   angulo:" + angulo);
        }
    }
}
