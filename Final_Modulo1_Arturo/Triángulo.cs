using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Modulo1_Arturo
{
    public class Triángulo : FiguraGeometrica, Poligono
    {
        /*   
          Triangulo :  
                         .
                        . . 
                       .   .
                      .     .
                     .       . 
                    .         .
         ladoizq   .  angulo   . ladoder
                  .   arriba    .
                 .               .
                .                 .
               .                   .
              .                     .
             .                       .
            .                         .
           .                           .
          .                             .
         .                               .
        .anguloizq              anguloder .                         
        ------------------------------------
                      ladobase

         */
        public double ladoizq { get; set; }
        public double ladoder { get; set; }
        public double ladobase { get; set; }
        public int anguloizq { get; set; }
        public int anguloder { get; set; }
        public double area(double valor1, double valor2)
        {
            return ((valor1*valor2) / 2);
        }
        public string ToString()
        {
            return (nombre + " "+area(ladobase, altura()).ToString());
        }
        public double altura()
        {
            if (anguloizq==90)
            {
                return ladoizq;
            }
            else if (anguloder==90)
            {
                return ladoder;
            }
            else
            {
                return (ladoizq*Math.Sin(anguloizq));
            }
        }
        public int anguloarriba()
        {
            return (180-anguloizq-anguloder);
        }
}
}
