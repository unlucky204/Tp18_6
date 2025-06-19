using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18_6
{
    public class Conferencia:Evento
    {
        public string Tema { get; set; }
        public override void ObtenerDescripcion()
        {
            Console.WriteLine($"Conferencia: {nombre}, Fecha: {fecha}, Ubicación: {ubicacion}, Tema: {Tema}");
        }
    }
}
