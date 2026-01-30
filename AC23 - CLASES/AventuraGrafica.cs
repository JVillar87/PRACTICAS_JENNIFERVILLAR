public class AventuraGrafica : JuegoBase
{
      public AventuraGrafica(string nombre, int publicationYear, string estudio, int categoria) : base (nombre, publicationYear, estudio, categoria)
    {
        Nombre = nombre;
        PublicationYear = publicationYear;
        Estudio = estudio;
    }

      public override int GetCategoria()
         {
            return Categoria;
         }
     public override void ShowData()
        {
           Console.WriteLine($"Juego Aventura Gráfica: {Nombre}, Año: {PublicationYear}, Estudio: {Estudio}, Categoría: {Categoria}");
        }
}