using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18_6
{
    public class Taller:Evento
    {
        public int CapMax { get; set; }
        public override void ObtenerDescripcion()
        {
             Console.WriteLine($"Conferencia: {nombre}");
            Console.WriteLine($"Fecha: {fecha}");
            Console.WriteLine($"Ubicación: {ubicacion}");
            Console.WriteLine($"Capacidad maxima: {CapMax}");}
        public override void InscribirParticipante(Participante participante)
        {
            if (participantes.Count < CapMax)
            {
                participantes.Add(participante);
                Console.WriteLine($"Participante inscripto");
            }
            else
            {
                Console.WriteLine($"El taller esta lleno");
            }
        }
    }
}
