﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio55
{
    interface IGuardar<T>
    {
        string RutaDeArchivo
        {
            get;
            set;
        }

        bool Guardar();
        T Leer();
    }
}
