using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Operaciones
    {
        //AREAS
        public double resultado {  get; set; }

        //Area del cuadrado
        public double AreaDeCuadrado(double a) {
            resultado = a * a;//Formula: A = a * a
            return resultado;
            
        }

        //Area del Rectangulo
        public double AreaDeRectangulo(double b, double h) {
            return  resultado = b * h;//Formula: A = b * h
        }

        //Area del Paralelogramo
        public double AreaDeParalelogramo(double b, double h)
        {
            return  resultado = b * h;//Formula: A = b * h
        }

        //Area de un Trapecio 
        public double AreaDeTrapecio(double B, double b, double h)
        {
            return  resultado = (B + b ) / 2 * h;//Formula: A = b + b / 2 * h
        }

        //Area del Triangulo
        public double AreaDeTriangulo(double b, double h)
        {
            return resultado = b * h / 2;//Formula: A = b * h / 2
        }

        //Area del Cometa
        public double AreaDeCometa(double D, double d)
        {
            return resultado = D * d / 2;//Formula: A = D * d / 2
        }

        //Area del Rombo
        public double AreaDeRombo(double D, double d)
        {
            return resultado = D * d / 2;//Formula: A = D * d / 2
        }

        //Area de un Circulo
        public double AreaDeCirculo(double r)
        {
            return resultado = 3.1416 * r * r;//Formula: A = x * r * r
        }


        //Volumen
        //Volumen del Cubo
        public double VolumenDeCubo(double a)
        {
            return resultado = a * a * a;//Formula: V = a * a * a
        }
        //Volumen del Prisma
        public double VolumenDePrisma(double a, double b, double c)
        {
            return resultado = a * b * c;//Formula: a * b * c
        }
        //Volumen del Cilindro
        public double VolumenDeCilindro(double r, double h)
        {
            return resultado = 3.1416 * r * r * h;//Formula: 3.14 * r * r * r * h
        }
        //Volumen de la Esfera
        public double VolumenDeEsfera(double r)
        {
            return resultado = (4 * r * r * r / 3) * 3.1416;//Formula: 4 / 3 * 3.14 * r * r * r
        }

        //Longitud
        //Longitud de Circunferencia
        public double LongitudDeCircunferencia(double r)
        {
            return resultado = 2 * 3.1416 * r;//Formula: L = 2 * 3.1416 * r
        }
        }
}
