

public partial class Program
{
private static void Main(string[] args)
    {
       Juego juego1 = new Juego("Aventuras Épicas", "Aventura", 2022, "EstudioX")
        {
            TieneCombate = true,
            TieneHistoria = true
        };

        Console.WriteLine(juego1.GetInfo());
        Console.WriteLine($"Categoría del juego: {juego1.categoriaJuego()}");

        string nivelElegido = juego1.ElegirNivel();
        Console.WriteLine($"Nivel elegido: {nivelElegido}");

        juego1.guardarJuego();
        juego1.gameOver(); */

    }

}