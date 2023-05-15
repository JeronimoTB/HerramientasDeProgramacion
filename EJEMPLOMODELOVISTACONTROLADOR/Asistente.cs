abstract class Asistente
{
    public string Nombre { get; set; }
    public int Id { get; set; }
    public int Edad { get; set; }

    public Asistente(string nombre, string id, int edad)
    {
        this.Nombre = nombre;
        this.Id = id;
        this.Edad = edad;
    }
}