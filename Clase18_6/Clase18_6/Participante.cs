﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18_6
{
    public class Participante
    {
       public string nombre { get; set; }
        public string apellido { get; set; }
        public string ObtenerNombreCompleto()
        { 
            string NombreCompleto = $"{nombre} {apellido}";
            return NombreCompleto;
        }
    }
}
