/* Guardar las temperaturas máximas y mínimas, de Madrid y Barcelona, durante una semana */

using System.Linq.Expressions;

Temperatura[,] ciudades = new Temperatura[2, 2];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        System.Console.WriteLine("Temperatura máxima?");
        ciudades[i, j].MaxTemperatura = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Temperatura mínima?");
        ciudades[i, j].MinTemperatura = Convert.ToInt32(Console.ReadLine());
    }
}

// Console.WriteLine("La temperatura máxima en BCN es" + ciudades[0, 0] + "y la mínima" + ciudades[0, 1]);
// Console.WriteLine("La temperatura máxima en Madrid es" + ciudades[1, 0] + "y la mínima" + ciudades[1, 1]);

// /* Define un struct "Producto" con: nombre, precio y stock.
// Crea un array de 5 productos y muestra cuál tiene un precio superio a 10€ */

Producto[] productos = new Producto[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("nombre");
    productos[i].Nombre = Console.ReadLine();

    Console.WriteLine("precio");
    productos[i].Precio = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("stock");
    productos[i].Stock = Convert.ToInt32(Console.ReadLine());
}

foreach (var item in productos)
{
    if (item.Precio > 10)
    {
        Console.WriteLine($"El producto {item.Nombre} tiene un precio mayor de: {item.Precio}");
    }
}



/* Codifica un struct "Videojuego" con título y horas jugadas.
Permite introducir 5 juegos y  muestra el que tiene +20h jugadas*/

Videojuego[] juegos = new Videojuego[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("título");
    juegos[i].Nombre = Console.ReadLine();

    Console.WriteLine("Horas jugadas");
    juegos[i].HorasJugadas = Convert.ToInt32(Console.ReadLine());
}

foreach (var título in juegos)
{
    if (título.HorasJugadas > 20)
    {
        Console.WriteLine(título.Nombre);
    }
}


/* Define un struct DiaTemperatura con mínima y máxima.
Crea un array para 7 días y muestra el día con temperaturaMáxima > 20 y mínima < 10. */

DiaTemperatura[] temperatura = new DiaTemperatura[7];

for (int i = 0; i < 7; i++)
{

    Console.WriteLine("Temperatura máxima?");
    temperatura[i].TemperaturaMAX = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Temperatura mínima?");
    temperatura[i].TemperaturaMIN = Convert.ToInt32(Console.ReadLine());

}

foreach (var grados in temperatura)
{
    if (grados.TemperaturaMAX > 20 && grados.TemperaturaMIN < 10)
    {
        Console.WriteLine($"La temperatura máxima es {grados.TemperaturaMAX} y la mínima {grados.TemperaturaMIN}");
    }
}


/* Crea un struct Contacto con nombre y teléfono.
Permite almacenar 10 contactos y mostrar solo los que se apellidan lópez */

Contacto[] contactos = new Contacto[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Dame el nombre del contacto");
    contactos[i].Nombre = Console.ReadLine();

    Console.WriteLine("Dame el apellido del contacto");
    contactos[i].Surname = Console.ReadLine();

    Console.WriteLine("Dame el teléfono del contacto:");
    contactos[i].Teléfono = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();
}

Console.WriteLine("Contactos con apellido López:\n");

foreach (var c in contactos)
{
    if (c.Surname == "López")
    {
        Console.WriteLine($"{c.Nombre} {c.Surname} - Tel: {c.Teléfono}");
    }
}



/* Define un struct Alumno con nombre y nota.
Introduce 5 alumnos y calcula la nota media. */

Alumno[] alumnos = new Alumno[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Introduce el nombre del alumno");
    string nombre = Console.ReadLine() ?? "";

    Console.Write($"Introduce el apellido de {nombre}: ");
    string surname = Console.ReadLine() ?? "";

    Console.Write($"Introduce la nota de {nombre} {surname}: ");
    int nota = Convert.ToInt32(Console.ReadLine());
}

int suma = 0;
foreach (var alumno in alumnos)
{
    suma += alumno.Nota;
}

double media = (double)suma / alumnos.Length;

Console.WriteLine("Resultados:");
foreach (var alumno in alumnos)
{
    Console.WriteLine($"{alumno.Nombre} {alumno.Surname}: {alumno.Nota}");
}

Console.WriteLine($"Nota media: {media:F2}");



/* Define un struct Pelicula con título, año y duración.
Guarda 8 películas y muestra todas las que duren más de 120 minutos.*/

Película[] peliculas = new Película[8];

for (int i = 0; i < 8; i++)
{
    Console.WriteLine($"Ingrese los datos de la película {i + 1}:");

    Console.Write("Nombre: ");
    peliculas[i].Nombre = Console.ReadLine();

    Console.Write("Duración (minutos): ");
    peliculas[i].Duración = int.Parse(Console.ReadLine());

    Console.Write("Año: ");
    peliculas[i].Año = int.Parse(Console.ReadLine());

    Console.WriteLine();
}


Console.WriteLine("Películas con duración mayor a 120 minutos:");
foreach (var pelicula in peliculas)
{
    if (pelicula.Duración > 120)
    {
        Console.WriteLine($"Nombre: {pelicula.Nombre}, Duración: {pelicula.Duración} min, Año: {pelicula.Año}");
    }
}

/* Codifica un struct que almacene datos de una habitación de hotel. 
La estructura tendrá: nombre, apellido, num de cama, num de hab.
El programa tiene que pedir los datos al usuario y mostrarlas por mensaje
de reserva confirmada. 
Tenéis que permitir las opciones: Añadir usuario, añadir todos los usuarios, 
ver todos los usuarios.*/

Reserva[,] reservas = new Reserva[3, 3];
Reserva cliente = new Reserva();
int opcion = 1;

for (int i = 0; i < 3; i++)
{

    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("¿Nombre?");
        cliente.Nombre = Console.ReadLine() ?? "";
        Console.WriteLine("¿Apellido");
        cliente.Apellido = Console.ReadLine() ?? "";
        Console.Write("¿Habitación?");
        cliente.NumeroHabitacion = Convert.ToInt32(Console.ReadLine());

        reservas[i, j] = cliente;

    }

}

Console.WriteLine("¡Habitación reservada!");

do
{
    Console.WriteLine("Añadir usuario (1), Añadir todos los usuarios (2), ver todos los usuarios (3), Salir (0)");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1: /*AÑADIR USUARIO*/
            Console.WriteLine("Nombre");
            cliente.Nombre = Console.ReadLine();

            Console.WriteLine("Apellido");
            cliente.Apellido = Console.ReadLine();

            Console.WriteLine("Numero de Habitación");
            cliente.NumeroHabitacion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Número de planta");
            int planta = Convert.ToInt32(Console.ReadLine());

            reservas[planta, cliente.NumeroHabitacion] = cliente;
            break;


        case 2: /*AÑADIR TODOS*/
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Nombre");
                    cliente.Nombre = Console.ReadLine() ?? "";
                    Console.WriteLine("Apellido");
                    cliente.Apellido = Console.ReadLine() ?? "";
                    Console.WriteLine("Habitación");
                    cliente.NumeroHabitacion = Convert.ToInt32(Console.ReadLine());
                    reservas[i, j] = cliente;

                }
            }
            break;
        case 3: /*VER TODOS*/
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Habitación {reservas[i, j].NumeroHabitacion}: {reservas[i, j].Nombre}, {reservas[i, j].Apellido}");
                }
            }
            break;
        case 0: /*SALIR*/
            System.Console.WriteLine("saliendo del programa");
            break;

        default: /*ERROR*/
            Console.WriteLine("Opción No Válida");
            break;
    }

} while (opcion != 0);


/*Codifica un programa en c# amb un struct que permet guardar dades d'imatges
De cada imatge s'ha de guardar: nom (text), ample en píxels (int), alt en píxels
(int), tamany en Kb (float).
El programa ha de ser capaç d'emmagatzemar fins a 10 imatges
Heu de permetre les opcions: afegir totes les fitxes, veure totes les fitxes, cercar la
fitxa per nom*/

Imatge[] imatges = new Imatge[10];
Imatge imatge = new Imatge();
int save = -1;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Nombre de la imágen");
    imatges[i].Name = Console.ReadLine() ?? "";
    Console.WriteLine("Ancho de imagen");
    imatges[i].amplePixels = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Altura de imagen");
    imatges[i].altPixels = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Tamaño de la imagen");
    imatges[i].Kb = Convert.ToSingle(Console.ReadLine());
}

do
{
    Console.WriteLine("Añadir todas las fichas (1), Ver todas las fichas (2), Buscar por nombre (3), Salir (0)");
    save = Convert.ToInt32(Console.ReadLine());

    switch (save)
    {
        case 1: /*AÑADIR FICHAS*/

            Console.WriteLine("Nombre de la imagen");
            imatge.Name = Console.ReadLine() ?? "";
            Console.WriteLine("Ancho de imagen");
            imatge.amplePixels = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Altura de imagen");
            imatge.altPixels = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tamaño de la imagen");
            imatge.Kb = Convert.ToSingle(Console.ReadLine());
            System.Console.WriteLine("posicion");
            int posicion = Convert.ToInt32(Console.ReadLine());

            imatges[posicion] = imatge;
            break;


        case 2: /*AÑADIR TODOS*/
            foreach (var item in imatges)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Nombre de la imagen");
                    imatge.Name = Console.ReadLine() ?? "";
                    Console.WriteLine("Ancho de imagen");
                    imatge.amplePixels = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Altura de imagen");
                    imatge.altPixels = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Tamaño de la imagen");
                    imatge.Kb = Convert.ToSingle(Console.ReadLine());
                }
            }
            break;

        case 3: /*VER TODOS*/
            Console.WriteLine("Ingrese el nombre de la imagen a buscar:");
            string nombreBusqueda = Console.ReadLine() ?? "";


            foreach (var img in imatges)
            {
                if (img.Name == nombreBusqueda)
                {
                    Console.WriteLine($"Imagen encontrada: {img.Name}, Ancho: {img.amplePixels}, Altura: {img.altPixels}, Tamaño: {img.Kb} Kb");
                    Console.WriteLine("Imagen encontrada.");
                    break;
                }
            }
            break;

        case 0: /*SALIR*/
            opcion = 0;
            System.Console.WriteLine("saliendo del programa");
            break;

        default: /*ERROR*/
            Console.WriteLine("Opción No Válida");
            break;
    }

} while (opcion != 0);


/*Haz lo mismo que el ejercicio antereior pero 
guardando los datos a un array cuadrado de 4x4 */

Imatge[,] images = new Imatge[4, 4];
int option = 1;

do
{
    Console.WriteLine("Añadir todas las fichas (1), Ver todas las fichas (2), Buscar por nombre (3),Salir (0)");
    option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1: /*AÑADIR FICHAS*/
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Nombre de la imagen");
                    images[i, j].Name = Console.ReadLine() ?? "";
                    Console.WriteLine("Ancho de imagen");
                    images[i, j].amplePixels = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Altura de imagen");
                    images[i, j].altPixels = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Tamaño de la imagen");
                    images[i, j].Kb = Convert.ToSingle(Console.ReadLine());
                }
            }
            break;
        case 2: /*VER TODOS*/
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"Imagen {images[i, j].Name}, Ancho: {images[i, j].amplePixels}, Altura: {images[i, j].altPixels}, Tamaño: {images[i, j].Kb} Kb");
                }
            }
            break;
        case 3: /*BUSCAR POR NOMBRE*/
            Console.WriteLine("Ingrese el nombre de la imagen a buscar:");
            string nombreBusqueda = Console.ReadLine() ?? "";
            bool encontrado = false;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (images[i, j].Name == nombreBusqueda)
                    {
                        Console.WriteLine($"Imagen encontrada: {images[i, j].Name}, Ancho: {images[i, j].amplePixels}, Altura: {images[i, j].altPixels}, Tamaño: {images[i, j].Kb} Kb");
                        encontrado = true;
                    }
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("Imagen no encontrada.");
            }
            break;
        case 0: /*SALIR*/
            System.Console.WriteLine("saliendo del programa");
            break;
    }
} while (option != 0);

/* Recorre matriz cuadrada con struct de Pokémon */




struct Imatge
{
    public string Name;
    public int amplePixels;
    public int altPixels;
    public float Kb;

}


struct Reserva
{
    public string Nombre;
    public string Apellido;
    public int NumeroHabitacion;
}

struct DiaTemperatura
{
    public int TemperaturaMAX;
    public int TemperaturaMIN;
}

struct Contacto
{
    public int Teléfono;
    public string Nombre;
    public string Surname;

}


struct Alumno
{
    public string Nombre;
    public int Nota;
    public string Surname;
}

struct Película
{
    public string Nombre;
    public int Duración;
    public int Año;

}


struct Videojuego
{
    public string Nombre;
    public int HorasJugadas;
}


struct Producto
{
    public int Precio;
    public int Stock;
    public string Nombre;
}


struct Temperatura
{
    public int MaxTemperatura;
    public int MinTemperatura;
}
