using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Modulo1_Arturo
{
    public partial class Form1 : Form
    {
        Stack<Poligono> Pila = new Stack<Poligono>();
        string mensaje = "";
        public Form1()
        {
            InitializeComponent();
        }
        //Metodos para verificar las cajas de texto y reutilizar codigo
        private string verificanombre(string textbox){
            string resp = "";
            if (textbox == "") 
                resp="Nombre vacio; ";
            else
            {
                //Con esto verifico que no haya nombres duplicados en la pila
                foreach (var dato in Pila)
                {
                    if (dato.nombre == textbox)
                    {
                        resp="Ya existe ese nombre; ";
                        break;

                    }
                }
            }
            return resp;
            
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
                MessageBox.Show("Triangulo creado con exito");
                nombretri.Text="";
                ladoizqtri.Text="";
                ladobasetri.Text="";
                angulotri.Text="";
            }
            else
            {
                MessageBox.Show(mensaje);
            }
            mensaje = "";

        }
        //Boton para crear rectangulo
        private void crearrec_Click(object sender, EventArgs e)
        {
            mensaje += verificanombre(nombrerec.Text) + verificalado(ladobaserec.Text, "base") + verificalado(ladoaltorec.Text, "alto");
            if (mensaje == "")
            {
                Rectangulo r1 = new Rectangulo();
                r1.nombre = nombrerec.Text;
                r1.ladobase = Convert.ToDouble(ladobaserec.Text);
                r1.ladoalto = Convert.ToDouble(ladoaltorec.Text);
                Pila.Push(r1);
                MessageBox.Show("El rectangulo se creo con exito");
                nombrerec.Text="";
                ladobaserec.Text="";
                ladoaltorec.Text="";
            }
            else
            {
                MessageBox.Show(mensaje);
            }
            mensaje = "";
        }
        //Boton para crear paralelogramo
        private void crearpar_Click(object sender, EventArgs e)
        {
            mensaje += verificanombre(nombrepar.Text) + verificalado(ladobasepar.Text, "base") + verificalado(ladoinclinadopar.Text, "inclinado") + verificaangulo(angulopar.Text);
            if (mensaje == "")
            {
                Paralelogramo p1 = new Paralelogramo();
                p1.nombre = nombrepar.Text;
                p1.ladobase = Convert.ToDouble(ladobasepar.Text);
                p1.ladoinclinado = Convert.ToDouble(ladoinclinadopar.Text);
                p1.angulo = Convert.ToInt32(angulopar.Text);
                Pila.Push(p1);
                MessageBox.Show("Paralelogramo creado con exito");
                nombrepar.Text="";
                ladobasepar.Text="";
                ladoinclinadopar.Text="";
                angulopar.Text="";
            }
            else
            {
                MessageBox.Show(mensaje);
            }
            mensaje = "";
        }

        private void mostrarpila_Click(object sender, EventArgs e)
        {
            string contenido = "";
            if (Pila.Count > 0)
            {
                //De esta forma muestro sin eliminar de la pila
                foreach(var dato in Pila)
                {
                    contenido += dato.toString()+"\n";
                }
                
                
            }
            else
            {
                MessageBox.Show("Pila de poligonos vacia");
            }

            Contenido.Text = contenido;
            
            


        }

        private void mostrardatos_Click(object sender, EventArgs e)
        {
            
            if (datos.Text != "")
            {
                if (Pila.Count > 0)
                {
                    bool existe = false;

                    //De esta forma muestro sin eliminar de la pila
                    string t = "";
                    foreach (var dato in Pila)
                    {
                        if ( dato.nombre== datos.Text)
                        {
                            t=dato.datos();
                            existe = true;
                            break;
                        }
                    }

                    if(!existe)
                        t="No existe en la pila";
                    MessageBox.Show(t);
                    

                    

                }
                else
                {
                    MessageBox.Show("Pila de poligonos vacia");
                }
            }
            else
            {
                MessageBox.Show("Nombre vacio");
            }
        }


    }
}
