public  class JuegoBase {

public string Nombre {get; set;}
public int PublicationYear {get; set;}
public string Estudio {get; set;}
public int Categoria { get; set;}

public JuegoBase (string nombre, int publicationYear, string estudio, int categoria)
{
    Nombre = nombre;
    PublicationYear = publicationYear;
    Estudio = estudio;
    Categoria = categoria;

}

public virtual int GetCategoria()
    {
        return Categoria;
    }

public virtual void ShowData()
        {
           Console.WriteLine($"Juego Shoot: {Nombre}, Año: {PublicationYear}, Estudio: {Estudio}");
        }
    

/*Cada juego debe generarse con valores iniciales para sus propiedades, no hace falta
poner valores por defecto, pero sí serán necesarios para su instanciación.*/
}