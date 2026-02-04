public class Robot
{
     string nombre;
     string modelo;

    public Robot(string nombre, string modelo)
    {
        this.nombre = nombre;
        this.modelo = modelo;
    }


    public static string GetNombre()
    {
        Random randomName= new Random();
        char[] letras = {'A','B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 
                         'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R',
                         'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        string nombre = "";
        for (int i = 0; i < 3; i++)
        {
            if (i < 2)
                nombre += letras[randomName.Next(letras.Length)];
            else
                nombre += randomName.Next(100,999);
        }
        return nombre;
    }
    
    public static string GetModelo()
    {
        Random random = new Random();
        string[] modelos = { "C3PO", "R2D2", "BB8" };
        return modelos[random.Next(modelos.Length)];
    }
    public string ObtenerNombre()
    {
        return nombre;
    }
    public string ObtenerModelo()
    {
        return modelo;
    }

    public void ResetNombre()
    {
        nombre = GetNombre();
    }

}