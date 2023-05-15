// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

AccesoData data = new AccesoData();
List<Evento> eventos = data.obtenerListaEventos();

OrquestadorConsola.solicitarDatosPersonas();
OrquestadorConsola.imprimirEventos(eventos);
