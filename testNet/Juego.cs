public  class Juego {

public string Nombre {get; set;}
public int PublicationYear {get; set;}
public string Categoria {get; set;}
public string Estudio {get; set;}
public bool TieneCombate { get; set; }
public bool TieneHistoria { get; set; }

public Juego (string nombre, string categoria, int publicationYear, string estudio)
{
    Nombre = nombre;
    Categoria = categoria;
    PublicationYear = publicationYear;
    Estudio = estudio;

}

public string categoriaJuego()
{
    if (TieneCombate && TieneHistoria)
        return "RPG";

    if (TieneCombate)
        return "Acción";

    return "Puzzle";
}

public string ElegirNivel()
{
    Console.WriteLine("Elige un nivel: Fácil(1), Medio(2), Difícil(3)");
    string nivel = Console.ReadLine();
    return nivel;
}

public void guardarJuego()
{
    Console.WriteLine($"¿Quieres guardar partida? (s/n)");
    var respuesta = Console.ReadLine();
    if (respuesta?.ToUpper() == "S" || respuesta?.ToUpper() == "SI")
    {
        Console.WriteLine("Partida guardada.");
    }
    else
    {
        Console.WriteLine("Partida no guardada.");
    }   
}

public void gameOver()
{
    Console.WriteLine("Juego terminado. ¿Quieres reiniciar? (s/n)");
    var respuesta = Console.ReadLine();
    if (respuesta?.ToUpper() == "S" || respuesta?.ToUpper() == "SI")
    {
        Console.WriteLine("Reiniciando juego...");
    }
    else
    {
        Console.WriteLine("Gracias por jugar.");
    }   
}

public string GetInfo()
{
    return $"{Nombre}, del tipo {Categoria}, publicado en {PublicationYear} por {Estudio}.";
}

}
