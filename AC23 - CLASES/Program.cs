internal class Program
{
    private static void Main(string[] args)
    {
        JuegoBase juego = new JuegoBase("Juego1", 2022, "Estudio1", 1);
        Console.WriteLine($"Juego: {juego.Nombre}, Año: {juego.PublicationYear}, Estudio: {juego.Estudio}");
        AlmacenarJuego();
        ShowCategoria();
    }   

          
    public static void AlmacenarJuego()
    {
        List<JuegoBase> juegos = new List<JuegoBase>();

        juegos.Add(new JuegoShoot("HALO INFINITE", 2021, "Halo Studios", 0, 18));
        juegos.Add(new Simulacion("SimCity", 2020, "Maxis", 1,"Ciudades"));
        juegos.Add(new AventuraGrafica("Beautiful Desolation", 2019, "The Brotherhood Games", 3));

        foreach (var item in juegos)
        {
            item.ShowData();
        }
        Console.WriteLine("Juegos almacenados.");
    }

    public static void ShowCategoria()
    {
        List<JuegoBase> juegos = new List<JuegoBase>();

        juegos.Add(new JuegoShoot("HALO INFINITE", 2021, "Halo Studios", 0, 18));
        juegos.Add(new Simulacion("SimCity", 2020, "Maxis", 1,"Ciudades"));
        juegos.Add(new AventuraGrafica("Beautiful Desolation", 2019, "The Brotherhood Games", 3));

        Console.WriteLine("Mostrando juegos por categoría:");

        foreach (var juego in juegos)
        {
            if (juego.GetCategoria() == 0)
            {
                Console.WriteLine($"Juego SHOOTER");
                juego.ShowData();
            }
            else if (juego.GetCategoria() == 1)
            {
                Console.WriteLine($"Juego de SIMULACIÓN");
                juego.ShowData();
            }
            else
            {
                Console.WriteLine($"Juego AVENTURA GRÁFICA");
                juego.ShowData();
            }
        }
    }

}


