using System.Security.Cryptography.X509Certificates;

public class JuegoShoot : JuegoBase 
{
      public int Pegi {get; set;}

    public JuegoShoot(string nombre, int publicationYear, string estudio, int pegi) : base (nombre, publicationYear, estudio)
    {
        Nombre = nombre;
        PublicationYear = publicationYear;
        Estudio = estudio;
        Pegi = pegi;
    }

    public int horasParaCompletar() 
        {
            return new Random().Next(0, 99);
        }

    public void ShowData()
        {
           Console.WriteLine($"Juego Shoot: {Nombre}, Año: {PublicationYear}, Estudio: {Estudio}, PEGI: {Pegi}, Horas estimadas: {horasParaCompletar()}");
        }
    


}