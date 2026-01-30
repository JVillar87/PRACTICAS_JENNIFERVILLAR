public class AventuraGrafica : JuegoBase
{
      public AventuraGrafica(string nombre, int publicationYear, string estudio) : base (nombre, publicationYear, estudio)
    {
        Nombre = nombre;
        PublicationYear = publicationYear;
        Estudio = estudio;
    }

     public override void ShowData()
        {
           Console.WriteLine($"Juego Aventura Gráfica: {Nombre}, Año: {PublicationYear}, Estudio: {Estudio}");
        }
}