﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio39
{
    class SobreSobreescrito :Sobreescrito
    {
        public SobreSobreescrito():base()
        {
        }

        public override string MiPropiedad
        {
            get
            {
                return this.miAtributo;
            }
        }
       
        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}
