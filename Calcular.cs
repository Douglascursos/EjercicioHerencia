using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Calcular : Operaciones
    {
        public int opcion1 {  get; set; }
        public int opcion2 { get; set; }

        //Area del cuadrado
        //Formula: A = a elevado a la 2.
        public double a { get; set; }//Lado

        //Area del Rectangulo
        //Formula: b * a.
        public double b { get; set; }//Base

        //Area del Paralelogramo
        //Formula: b * h.
        public double h { get; set; }

        //Area de un Trapecio 
        //Formula: bM + bm / 2 * h
        public double bM { get; set; }
        public double bm { get; set; }

        //Area del Triangulo
        //Formula: b * h / 2

        //Area del Cometa
        //Formula: D * d / 2
        public double D { get; set; }
        public double d { get; set; }

        //Area del Rombo
        //Formula: D * d / 2


        //Area de un Circulo
        //Formula x * r elevado a la 2
        public double x { get; set; }
        public double r { get; set; }
       
        public void Imprimir()
        {

                Console.WriteLine(resultado);
         
        }
    }
}
