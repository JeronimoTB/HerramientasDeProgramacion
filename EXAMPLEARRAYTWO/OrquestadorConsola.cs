static class OrquestadorConsola
{
    private static List<Persona> personas = new List<Persona>();

    public static void solicitarDatosPersonas()
    {
        int opcion = -1;
        do
        {
            Console.WriteLine("Aca puede ");
            Console.WriteLine("Si desea inscribir digite cualquier numero diferente al 0. Si desea salir digite el 0.");
            opcion = Int32.Parse(Console.ReadLine());
            if (opcion != 0)
            {
                Console.WriteLine("Por favor digite el nombre completo de la persona");
                string nombre = Console.ReadLine();
                Console.WriteLine("Por favor digite la edad de la persona");
                int edad = Int32.Parse(Console.ReadLine());
                Persona persona;
                if (edad < 18)
                {
                    persona = new Ninno(nombre, edad);
                }
                else
                {
                    persona = new Adulto(nombre, edad);
                }
                personas.Add(persona);
            }


        } while (opcion != 0);
        imprimirPersonas();

    }

    public static void imprimirPersonas()
    {
        Console.WriteLine("La cantidad de personas registradas es: " + personas.Count);
        int numeroNinnos = 0;
        int numeroAdultos = 0;
        
        foreach (Persona persona in personas)
        {
            if (persona is Ninno)
            {
                numeroNinnos++;
            }
            else
            {
                numeroAdultos++;
            }
        }

        Console.WriteLine("La cantidad de niños registrados es: " + numeroNinnos);
        Console.WriteLine("La cantidad de adultos registrados es: " + numeroAdultos);
    }

    public static void imprimirEventos(List<Evento> eventos)
    {
        foreach (Evento evento in eventos)
        {
            string variante = evento.SoloAdultos ? "no" : "si";
            Console.WriteLine("En el evento: " + evento.NombreEvento + " " + variante + " pueden asistir niños");
            if (evento.SoloAdultos)
            {
                Console.WriteLine("Es decir las siguientes personas no podran asistir: ");
                foreach (Persona persona in personas)
                {
                    if (persona is Ninno)
                    {
                        Console.WriteLine(persona.Nombre);
                    }
                }
            }


        }
    }
}