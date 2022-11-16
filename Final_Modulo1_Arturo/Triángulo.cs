using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
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
         ladoizq   .           . 
                  .             .
                 .               .
                .                 .
               .                   .
              .                     .
             .                       .
            .                         .
           .                           .
          .                             .
         .                               .
        .anguloizq                        .                         
        ------------------------------------
                      ladobase

         */
        public double ladoizq { get; set; }
        public double ladobase { get; set; }
        public int anguloizq { get; set; }
        public double area(double valor1, double valor2)
        {
            return ((valor1*valor2) / 2);
        }
        public string toString()
        {
            return (nombre + " "+area(ladobase, altura()).ToString());
        }
        public double altura()
        {
            if (anguloizq == 90)
            {
                return ladoizq;
            }
            else
            {
                if (anguloizq<90)
                    return (ladoizq * (Math.Sin((anguloizq * (Math.PI)) / 180)));
                else
                    return (ladoizq * (Math.Sin(((180-anguloizq) * (Math.PI)) / 180)));
            }

        }
        public string datos()
        {
            return ("Triangulo:"+nombre+"   lado izquierdo:"+ladoizq+"   lado base:"+ladobase+"   angulo izquierdo:"+anguloizq);
        }
    }
}
