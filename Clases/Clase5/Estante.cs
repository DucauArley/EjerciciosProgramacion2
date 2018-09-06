using System.Text;

namespace Clase5
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion): this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProducto()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder retorno = new StringBuilder();
            string retornoTexto;

            retorno.Append(" Ubicacion estante: ");
            retorno.Append(e.ubicacionEstante);
            retorno.AppendLine("");


            for (int i = 0; i < e.productos.Length; i++)
            {
                retorno.Append(" Producto ");
                retorno.Append(i+1);
                retorno.AppendLine(": ");
                retorno.AppendLine(Producto.MostrarProducto(e.productos[i]));
            }

            retornoTexto = retorno.ToString();

            return retornoTexto;
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;

            for (int i = 0; i < e.productos.Length; i++)
            {
                if(object.ReferenceEquals(e.productos[i], p))
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            bool retorno = !(e == p);

            return retorno;
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool retorno = false;

            if((e != p))
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (object.ReferenceEquals(e.productos[i], null))
                    {
                        e.productos[i] = p;
                        
                        retorno = true;
                        break;
                    }
                }
                
            }

            return retorno;
        }


        public static Estante operator -(Estante e, Producto p)
        {
            if((e == p))
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (object.ReferenceEquals(e.productos[i], p))
                    {
                        e.productos[i] = null;
                    }
                }
            }

            return e;
        }






    }
}
