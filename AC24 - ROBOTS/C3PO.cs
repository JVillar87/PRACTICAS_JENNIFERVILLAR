class C3PO : Robot
{
    private int idiomas;

    public C3PO(string nombre, int idiomas) : base(nombre, "C3PO")
    {
        this.idiomas = idiomas;
    }

    public void AddLanguage()
    {
        idiomas++;
        Console.WriteLine("Idioma añadido. Total idiomas: " + idiomas);
    }

    public int ObtenerIdiomas()
{
    return idiomas;
}


    public void Saludar()
    {
        Console.WriteLine("Hola, soy C3PO");
    }
}
