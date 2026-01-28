internal class Program
{
    private static void Main(string[] args)
    {
        JuegoBase juego = new JuegoBase("Juego1", 2022, "Estudio1");
        Console.WriteLine($"Juego: {juego.Nombre}, Año: {juego.PublicationYear}, Estudio: {juego.Estudio}");
        AlmacenarJuego();
        ShowCategoria();
    }   

          
    public static void AlmacenarJuego()
    {
        List<JuegoBase> juegos = new List<JuegoBase>();

        juegos.Add(new JuegoShoot("HALO INFINITE", 2021, "Halo Studios", 18));
        juegos.Add(new Simulacion("SimCity", 2020, "Maxis", "Ciudades"));
        juegos.Add(new AventuraGrafica("Beautiful Desolation", 2019, "The Brotherhood Games"));

        Console.WriteLine("Juegos almacenados.");
    }

    public static void ShowCategoria()
    {
        List<JuegoBase> juegos = new List<JuegoBase>();

        juegos.Add(new JuegoShoot("HALO INFINITE", 2021, "Halo Studios", 18));
        juegos.Add(new Simulacion("SimCity", 2020, "Maxis", "Ciudades"));
        juegos.Add(new AventuraGrafica("Beautiful Desolation", 2019, "The Brotherhood Games"));

        Console.WriteLine("Mostrando juegos por categoría:");

        foreach (var juego in juegos)
        {
            switch (juego)
            {
                case JuegoShoot shoot:
                    shoot.ShowData();
                    break;
                case Simulacion sim:
                    sim.ShowData();
                    sim.turnosNecesarios();
                    break;
                case AventuraGrafica aventura:
                    aventura.ShowData();
                    break;
            }
        }
    }

}


