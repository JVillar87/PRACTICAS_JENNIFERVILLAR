public class Simulacion : JuegoBase
{
    public string Ambito{ get; set; } //ciudades, parques temáticos, granja, etc.

    public Simulacion(string nombre, int publicationYear, string estudio, string ambito) 
        : base(nombre, publicationYear, estudio)
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
    public void ShowData()
    {
        Console.WriteLine($"Juego Simulación: {Nombre}, Año: {PublicationYear}, Estudio: {Estudio}, Ámbito: {Ambito}");
    }
}


