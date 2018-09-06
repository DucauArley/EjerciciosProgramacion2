using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        public string GetMarca()
        {
            string texto;

            texto = this.marca;

            return texto;
        }

        public float GetPrecio()
        {
            float numero;

            numero = this.precio;

            return numero;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder retorno = new StringBuilder();
            string retornoTexto;

            retorno.Append(" Codigo de barra: " + p.codigoDeBarra + " Marca: " + p.GetMarca());
            retorno.Append(" Precio: " + p.GetPrecio());

            retornoTexto = retorno.ToString();

            return retornoTexto;
        }

        public static explicit operator string (Producto p)
        {
            string retorno;

            retorno = p.codigoDeBarra;

            return retorno;
        }

        public static bool operator !=(Producto p, string marca)
        {
            bool retorno = !(p.marca == marca);

            return retorno;
        }

        public static bool operator !=(Producto p, Producto p2)
        {
            bool retorno = true;

            
            if (p.marca == p2.marca || p.codigoDeBarra == p2.codigoDeBarra)
            {
                retorno = false;
            }

            return retorno;
        }

        public static bool operator ==(Producto p, string marca)
        {
            bool retorno = false;

            if (p.marca == marca)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator ==(Producto p, Producto p2)
        {
            bool retorno = false;


            if ((object.Equals(p, null)) && (object.Equals(p2, null)))
            {
                if (p.marca == p2.marca && p.codigoDeBarra == p2.codigoDeBarra)
                {
                    retorno = true;
                }
            }

            return retorno;
        }


    }
}
