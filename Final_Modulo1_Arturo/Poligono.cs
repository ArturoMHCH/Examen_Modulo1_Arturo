﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Modulo1_Arturo
{
    public interface Poligono
    {
       
        public double area(double valor1, double valor2);
        public string nombre { get; }
        public string toString();
        public string datos();
    }
}
