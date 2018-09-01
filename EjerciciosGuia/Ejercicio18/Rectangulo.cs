using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            
            this.vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.vertice4 = new Punto(vertice3.GetX(), vertice1.GetY());
        }

        public float GetArea()
        {
            float retorno;

            retorno = this.area;

            return retorno;
        }

        public float GetPerimetro()
        {
            float retorno;

            retorno = this.perimetro;

            return retorno;
        }

        public float Area()
        {
            float baseRectangulo = 0;
            float alturaRectangulo = 0;

            baseRectangulo = this.vertice4.GetX() - this.vertice1.GetX();
            alturaRectangulo = this.vertice1.GetY() - this.vertice2.GetY();

            this.area = baseRectangulo * alturaRectangulo;

            return this.area;
        }

        public float Perimertro()
        {
            float baseRectangulo = 0;
            float alturaRectangulo = 0;

            baseRectangulo = this.vertice4.GetX() - this.vertice1.GetX();
            alturaRectangulo = this.vertice1.GetY() - this.vertice2.GetY();

            this.perimetro = (baseRectangulo + alturaRectangulo) * 2;

            return this.perimetro;
        }

        public void Mostrar()
        {
            Console.WriteLine("Vertice 1: (" + this.vertice1.GetX() + "," + this.vertice1.GetY() + ")");
            Console.WriteLine("Vertice 1: (" + this.vertice2.GetX() + "," + this.vertice2.GetY() + ")");
            Console.WriteLine("Vertice 1: (" + this.vertice3.GetX() + "," + this.vertice3.GetY() + ")");
            Console.WriteLine("Vertice 1: (" + this.vertice4.GetX() + "," + this.vertice4.GetY() + ")");
            Console.WriteLine("Area: " + GetArea());
            Console.WriteLine("Perimetro: " + GetPerimetro());
        }



    }
}
