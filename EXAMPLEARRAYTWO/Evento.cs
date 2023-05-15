class Evento
{
    public static int numeroDeEventos = 0;
    public string NombreEvento { get; set; }
    public TipoEvento Tipo { get; set; }
    public bool SoloAdultos { get; set; }

    public Evento(string nombreEvento, TipoEvento tipo, bool soloAdultos)
    {
        this.NombreEvento = nombreEvento;
        this.Tipo = tipo;
        this.SoloAdultos = soloAdultos;
        numeroDeEventos++;
    }
}