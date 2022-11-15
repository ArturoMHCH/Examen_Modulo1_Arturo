using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Modulo1_Arturo
{
    public partial class Form1 : Form
    {
        Stack<FiguraGeometrica> Pila = new Stack<FiguraGeometrica>();
        string mensaje = "";
        public Form1()
        {
            InitializeComponent();
        }
        //Metodos para verificar las cajas de texto
        private string verificanombre(string textbox){
            return (textbox == "") ? "Nombre vacio;" : "";
        }
        private string verificalado(string longitud, string lado)
        {
            string resultado = "";
            try
            {
                resultado = (Convert.ToDouble(longitud) <= 0) ? "Lado "+lado+" no es mayor a 0; " : "";
            }
            catch (Exception)
            {
                resultado= "Lado "+lado+" no es numero valido; ";
            }
            return resultado;
        }
        private string verificaangulo(string angulo)
        {
            string resultado = "";
            try
            {
                resultado = (Convert.ToInt32(angulo) <= 0 || Convert.ToInt32(angulo) >= 180) ? "Angulo no esta en el rango 1-180 grados" : "";
            }
            catch (Exception)
            {
                resultado = "Angulo no es numero valido;";
            }
            return resultado;
        }
        //Boton de crear triangulo
        private void creartri_Click(object sender, EventArgs e)
        {
            mensaje += verificanombre(nombretri.Text) + verificalado(ladoizqtri.Text,"izquierdo") + verificalado(ladobasetri.Text,"base") + verificaangulo(angulotri.Text);
            if (mensaje=="")
            {
                Triángulo t1 = new Triángulo();
                t1.nombre = nombretri.Text;
                t1.ladoizq = Convert.ToDouble(ladoizqtri.Text);
                t1.ladobase = Convert.ToDouble(ladobasetri.Text);
                t1.anguloizq = Convert.ToInt32(angulotri.Text);
                Pila.Push(t1);
            }
            else
            {
                MessageBox.Show(mensaje);
            }
            mensaje = "";

        }
    }
}
