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

    public override void ShowData()
        {
           Console.WriteLine($"PEGI: {Pegi}, Horas estimadas: {horasParaCompletar()}");
        }
    


}