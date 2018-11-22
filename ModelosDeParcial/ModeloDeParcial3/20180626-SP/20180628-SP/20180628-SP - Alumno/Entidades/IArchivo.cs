﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface IArchivo<T>
    {
        T Leer(string rutaArchivo);
        bool Guardar(string rutaArchivo, T objeto);
    }
}
