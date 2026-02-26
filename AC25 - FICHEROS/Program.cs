// LIBRERIA

internal class Program
{
    static void Main()
    {
        /*Simulemos la BBS, los mensajes deben contener usuario, asunto y mensaje separado por ;
    c3po;para r2d2;A veces simplemente no entiendo el comportamiento humano
    genera un archivo mensajes.txt con al menos 5 registros (estos serán los de fuera del nodo).
    Codifica un programa que incluya las siguientes funciones:
    - Añadir mensaje local (escribe en una lista dinámica)
    - Lista todos los usuarios
    - Leer un mensaje local (por usuario)
    - Leer todos los mensajes locales
    - Pasar mensajes locales a archivo (mensajes.txt)
    - Leer todos los mensajes de archivo
    *recuerda el método .Split de los strings.*/

        StreamWriter mensaje = new StreamWriter("mensajes.txt", true);
        mensaje.WriteLine("c3po;para r2d2;A veces simplemente no entiendo el comportamiento humano");
        mensaje.Close();

        string usuario = "";
        string asunto = "";


        StreamWriter ficheros = new StreamWriter(archivos,true);
        while (producto != "fin")
        {
            Console.WriteLine("Escribe el nombre del producto (escribe 'fin' para terminar):");
            producto = Console.ReadLine();
            if (producto != "fin")
            {
                Console.WriteLine("Escribe el precio del producto:");
                string precio = Console.ReadLine();
                ficheros.WriteLine($"{producto}:{precio}");
            }
        }
        ficheros.Close();





        string archivo = "libros.txt";

        nuevoLibro(archivo);
        leerLibro(archivo);
    }



    private static void nuevoLibro(string archivo)
    {
        Console.WriteLine("título? ");
        string titulo = Console.ReadLine();
        Console.WriteLine("autor? ");
        string autor = Console.ReadLine();
        Console.WriteLine("isbn? ");
        string isbn = Console.ReadLine();

        StreamWriter libreria = new StreamWriter(archivo, true);

        libreria.WriteLine("{0};{1};{2}", titulo, autor, isbn);

        libreria.Close();
    }

    private static void leerLibro(string archivo)
    {
        StreamReader libreria = new StreamReader(archivo);

        string linea;

        while ((linea = libreria.ReadLine()) != null)
        {
            string[] datosLibro = linea.Split(';');

            Console.WriteLine("Título: {0} ", datosLibro[0]);
            Console.WriteLine("Autor: {0}", datosLibro[1]);
            Console.WriteLine("isbn: {0}", datosLibro[2]);
        }
        libreria.Close();

    }
}