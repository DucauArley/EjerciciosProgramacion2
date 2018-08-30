using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        public static double Calcular(double numeroUno, double numeroDos, char operacion)
        {
            double resultado = 0;

            switch (operacion)
            {
                case '+':
                    resultado = numeroDos + numeroUno;
                    break;
                case '-':
                    resultado = numeroUno - numeroDos;
                    break;
                case '/':
                    if (Validar(numeroDos) == true)
                    {
                        resultado = numeroUno / numeroDos;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por 0");
                    }
                    break;
                case '*':
                    resultado = numeroDos * numeroUno;
                    break;
            }


            return resultado;
        }


        private static bool Validar(double numero)
        {
            bool resultado = true;

            if (numero == 0)
            {
                resultado = false;
            }

            return resultado;
        }

        public static void Mostrar(double resultado)
        {
            Console.WriteLine("El resultado es: " + resultado);
        }

    }
}
