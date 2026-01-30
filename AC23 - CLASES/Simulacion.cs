public class Simulacion : JuegoBase
{
    public string Ambito{ get; set; } //ciudades, parques temáticos, granja, etc.

    public Simulacion(string nombre, int publicationYear, string estudio, int categoria, string ambito) 
        : base(nombre, publicationYear, estudio, categoria)
    {
        Nombre = nombre;
        PublicationYear = publicationYear;
        Estudio = estudio;
        Ambito = ambito;
    }

    public void turnosNecesarios()
    {
        Console.WriteLine("Número de turnos necesarios para completar la simulación: " + new Random().Next(1, 50));
    }

    public override int GetCategoria()
    {
        return Categoria;
    }
    public override void ShowData()
    {
        Console.WriteLine($"Ámbito: {Ambito}");
    }
}


