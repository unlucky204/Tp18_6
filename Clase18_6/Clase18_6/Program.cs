using Clase18_6;

List<Evento> eventos = new List<Evento>();
while (true)
{
    Menu();
    Console.ReadKey();
    Console.Clear();
}   
 void Menu()
{
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1. Crear Evento");
    Console.WriteLine("2. Inscribir Participante");
    Console.WriteLine("3. Listar Eventos");
    Console.WriteLine("4. Buscar Evento");
    int op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
            CrearEvento();
            break;
        case 2:
            Console.WriteLine("Seleccione el evento al que desea inscribir un participante:");
            ListarEventos();
            int index = int.Parse(Console.ReadLine());
            index--;
            AgregarParticipante(eventos[index]);
            break;
        case 3:
            ListarEventos();
            break;
        case 4:
            BuscarEvento();
            break;
        default:
            break;
    }

}

void CrearEvento()
{
    Console.WriteLine("Ingrese el tipo de evento");
    Console.WriteLine("1. Taller");
    Console.WriteLine("2. Conferencia");
    int op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
            Taller taller = new Taller();
            Console.WriteLine("Ingrese el nombre del taller:");
            taller.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha del taller:");
            taller.fecha = Console.ReadLine();
            Console.WriteLine("Ingrese la ubicación del taller:");
            taller.ubicacion = Console.ReadLine();
            Console.WriteLine("Ingrese la capacidad máxima del taller:");
            taller.CapMax = int.Parse(Console.ReadLine());
            eventos.Add(taller);
            break;
        case 2:
            Conferencia conferencia = new Conferencia();
            Console.WriteLine("Ingrese el nombre de la conferencia:");
            conferencia.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de la conferencia:");
            conferencia.fecha = Console.ReadLine();
            Console.WriteLine("Ingrese la ubicación de la conferencia:");
            conferencia.ubicacion = Console.ReadLine();
            Console.WriteLine("Ingrese el tema de la conferencia:");
            conferencia.Tema = Console.ReadLine();
            eventos.Add(conferencia);
            break;
        default:
            break;
    }
}

 void AgregarParticipante(Evento evento)
{ 
    Console.WriteLine("Ingrese el nombre del participante:");
    string nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el apellido del participante:");
    string apellido = Console.ReadLine();
    Participante participante = new Participante { nombre = nombre, apellido = apellido };
    evento.InscribirParticipante(participante);
}

void ListarEventos()
{
    foreach (var item in eventos)
    {
        int c=1;
        Console.WriteLine("------------------");
        Console.WriteLine($"Evento {c}.");
        item.ObtenerDescripcion();
        c++;
    }
}

void BuscarEvento()
{
    Console.WriteLine("Ingrese el nombre del evento a buscar:");
    string nombre = Console.ReadLine();
    bool Existe;
    foreach (Evento item in eventos)
    {
        
        if (nombre == item.nombre)
        {
            item.ObtenerDescripcion();
            foreach (Participante part in item.participantes)
            {
                int c = 1;
                Console.WriteLine($"{c}.{part.ObtenerNombreCompleto()}");
                c++;
            }
            Existe = true;
        }
    }
    if (Existe=false)
    {
        Console.WriteLine("No se encontró el evento");
    }

}