class BB8 : Robot
{
    private int blindaje;

    public BB8(string nombre, int blindaje) : base(nombre, "BB8")
    {
        this.blindaje = blindaje;
    }

    public int ObtenerBlindaje()
    {
        return blindaje;
    }

    public void ActivarArmas()
    {
        blindaje -= 5;
        Console.WriteLine("Armas activadas. Blindaje actual: " + blindaje);
    }

    public void Disparar()
    {
        blindaje -= 10;
        Console.WriteLine("Disparando... Blindaje actual: " + blindaje);
    }

}
