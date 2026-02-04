class R2D2 : Robot
{
    private int energia;

    public R2D2(string nombre, int energia) : base(nombre, "R2D2")
    {
        this.energia = energia;
    }

    public void ActivarRadar()
    {
        Console.WriteLine("Radar activado");
    }

    public void Rodar()
    {
        Console.WriteLine("Rodando...");
    }
}
