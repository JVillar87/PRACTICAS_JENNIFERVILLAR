internal partial class Program

{
    static List<string> mensajesLocales = new List<string>();
    static string rutaArchivo = "mensajes.txt";
static void Main()
    {
    /* EJERCICIO 1: Simulemos la BBS, los mensajes deben contener usuario, asunto y mensaje separado por ;
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
       
        AddLocalMessage(mensajesLocales);
        AddLocalMessage(mensajesLocales);
        
        Console.WriteLine("Usuarios:");
        ListUsers();

        Console.WriteLine("MENSAJES DE C3P0:");
        ReadLocalMessage("C3PO");

        Console.WriteLine("ALL LOCAL MESSAGES:");
        ReadeAllLocalMessages();

        Console.WriteLine("SAVING...");
        PassLocalMessagesToFile();

        Console.WriteLine("READ ALL MESSAGES FROM FILE:");
        ReadAllMessagesFromFile();

    /* EJERCICIO 2: Modifica el programa librería visto en clase:
    - Genera un menú para las funciones: añadir, mostrar libros, salir.
    - El usuario pueda agregar varios libros a la vez. Utiliza una lista para almacenar los libros
    que el usuario registe y luego guardarlos en el archivo de texto.
    - Ordenar por autor: modifica la función leerLibro para que muestre los libros almacenados
    en el archivo ordenados por autor. Para ello, deberás usar una estructura dinámica para
    almacenar los libros del archivo y ordenarlos con sort.*/


        string archivo = "libros.txt";
        int opcion;

        do
        {
            Console.WriteLine("¿Qué quieres hacer?");
            Console.WriteLine("1. Añadir libros");
            Console.WriteLine("2. Mostrar libros (Ordenados por autor)");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            
            if (!int.TryParse(Console.ReadLine(), out opcion)) continue;

            switch (opcion)
            {
                case 1:
                    NuevoLibro(archivo);
                    break;
                case 2:
                    LeerLibrosOrdenados(archivo);
                    break;
                case 3:
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
        }
    } while (opcion != 3);
}

    private static void NuevoLibro(string archivo)
    {
        List<string> librosNuevos = new List<string>();
        string continuar;

        do
        {
            Console.WriteLine("\nIntroduce los datos del libro:");
            Console.Write("Título: ");
            string? titulo = Console.ReadLine();
            Console.Write("Autor: ");
            string? autor = Console.ReadLine();
            Console.Write("ISBN: ");
            string? isbn = Console.ReadLine();

            if (titulo != null && autor != null && isbn != null)
            {
                librosNuevos.Add($"{titulo};{autor};{isbn}");
            }

            Console.Write("¿Desea agregar otro libro? (Y/N): ");
            continuar = Console.ReadLine();

        } while (continuar == "Y" || continuar == "y");

        
        try
        {
            using (StreamWriter LIBRARY = new StreamWriter(archivo, true))
            {
                foreach (string linea in librosNuevos)
                {
                    LIBRARY.WriteLine(linea);
                }
            }
            Console.WriteLine("¡Libros guardados correctamente!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al guardar: " + ex.Message);
        }
    }

    private static void LeerLibrosOrdenados(string archivo)
    {
        if (!File.Exists(archivo))
        {
            Console.WriteLine("El archivo aún no existea.");
            return;
        }

        List<Libro> listaLibros = new List<Libro>();      
        using (StreamReader Listado = new StreamReader(archivo))
        {
            string linea;
            while ((linea = Listado.ReadLine()) != null)
            {
                string[] datos = linea.Split(';');
                if (datos.Length == 3)
                {
                    listaLibros.Add(new Libro 
                    { 
                        Titulo = datos[0], 
                        Autor = datos[1], 
                        Isbn = datos[2] 
                    });
                }
            }
        }        
        listaLibros.Sort((x, y) => x.Autor.CompareTo(y.Autor));

        Console.WriteLine("LIBROS ORDENADOS POR AUTOR:");
        
        foreach (var libro in listaLibros)
        {
            Console.WriteLine($"Autor: {libro.Autor} | Título: {libro.Titulo} | ISBN: {libro.Isbn}");
        }
    }

    class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Isbn { get; set; }
    }

    //Funciones para el ejercicio 1
    static void AddLocalMessage(List<string> mensajesLocales)
    {
        Console.WriteLine("Escribe un mensaje (usuario;asunto;mensaje):");
            string? entrada = Console.ReadLine();
            if (entrada != null)
        {
            mensajesLocales.Add(entrada);
        }
        else
        {
            Console.WriteLine($"Mensaje vacío");
        }
    }

    static void ListUsers()
    {
        List<string> usuariosUnicos = new List<string>();
        foreach (string mensaje in mensajesLocales)
        {
            usuariosUnicos.Add(mensaje.Split(';')[0]);
        }
        
        foreach (var user in usuariosUnicos) Console.WriteLine($"- {user}");
    }

    static void ReadLocalMessage(string usuario)
    {
        foreach (string mensaje in mensajesLocales)
        {
            string[] partes = mensaje.Split(';');
            if (partes[0].ToLower() == usuario.ToLower())
            {
                Console.WriteLine($"[{partes[0]}] Asunto: {partes[1]} | Contenido: {partes[2]}");
            }
        }
    }

    static void ReadeAllLocalMessages()
    {
        foreach (string mensaje in mensajesLocales)
        {
            string[] partes = mensaje.Split(';');
            if(partes.Length == 3)
                Console.WriteLine($"Usuario: {partes[0]}, Asunto: {partes[1]}, Mensaje: {partes[2]}");
        }
    }

    static void PassLocalMessagesToFile()
    {
        StreamWriter Ruta = new StreamWriter(rutaArchivo, true);
        foreach (string mensaje in mensajesLocales)
        {
            Ruta.WriteLine(mensaje);
        }
        Ruta.Close();
    }

    static void ReadAllMessagesFromFile()
    {
        if (!File.Exists(rutaArchivo)) return;

        using (StreamReader files = new StreamReader(rutaArchivo))
        {
            string linea;
            while ((linea = files.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                string[] partes = linea.Split(';');
                if(partes.Length >= 3)
                    Console.WriteLine($"FILE > [{partes[0]}] {partes[1]}: {partes[2]}");
            }
        }
    }

}
