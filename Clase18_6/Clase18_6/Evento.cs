using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18_6
{
    public abstract class Evento
    {
        public string nombre { get; set; }
        public string fecha { get; set; }
        public string ubicacion { get; set; }
        public List<Participante> participantes = new List<Participante>();
        public abstract void ObtenerDescripcion();

        public virtual void InscribirParticipante(Participante participante)
        {
            participantes.Add(participante);
            Console.WriteLine($"Participante inscripto");
        }
        
    }
}
