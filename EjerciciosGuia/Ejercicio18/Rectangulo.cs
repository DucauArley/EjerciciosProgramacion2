using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
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
            int baseRectangulo = 0;
            int alturaRectangulo = 0;

            baseRectangulo = this.vertice4.GetX() - this.vertice1.GetX();
            alturaRectangulo = this.vertice1.GetY() - this.vertice2.GetY();


            return 0;
        }



    }
}
