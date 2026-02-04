public class Program
{
    public static void Main()
{
    Robot[] fabrica = new Robot[10]; 
    int opcion;

    do
    {
        Console.WriteLine("1. Crear robot");
        Console.WriteLine("2. Restablecer robot");
        Console.WriteLine("3. Ver robot");
        Console.WriteLine("4. Eliminar robot");
        Console.WriteLine("5. Listar robots");
        Console.WriteLine("0. Salir");

        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:                
                CrearRobot(fabrica);
                break;

            case 2:
                NuevoNombre(fabrica);
                break;

            case 3:
                VerRobot(fabrica);
                break;
            case 4:
                EliminarRobot(fabrica);
                break;
            case 5:
                ListarRobots(fabrica);
                break;
            case 0:
                Console.WriteLine("Saliendo del programa...");
                break;
        }

    } while (opcion != 0);
}

    public static void CrearRobot(Robot[] fabrica)
    {
        int posicionLibre = -1;

        for (int i = 0; i < fabrica.Length; i++)
        {
            if (fabrica[i] == null)
            {
                posicionLibre = i;
                break;
            }
        }

        if (posicionLibre == -1)
        {
            Console.WriteLine("Fábrica llena");
            return;
        }

        string nombre = Robot.GetNombre();
        string modelo = Robot.GetModelo();

        Robot robot;

        switch (modelo)
        {
            case "R2D2":
                robot = new R2D2(nombre, 100);
                break;

            case "C3PO":
                robot = new C3PO(nombre, 5);
                break;

            default:
                robot = new BB8(nombre, 50);
                break;
        }

        fabrica[posicionLibre] = robot;

        Console.WriteLine($"【ROBOT CREADO】 {robot.ObtenerNombre()} - {robot.ObtenerModelo()} en posición {posicionLibre}");
    }

    public static void NuevoNombre(Robot[] fabrica)
    {
        Console.WriteLine("Introduce posición del robot a resetear:");
        string? input = Console.ReadLine();
        
        if (int.TryParse(input, out int posicion))
        {
            if (posicion >= 0 && posicion < fabrica.Length && fabrica[posicion] != null)
            {
                fabrica[posicion].ResetNombre();
                Console.WriteLine("【RESETEADO】 Nuevo nombre: " + fabrica[posicion].ObtenerNombre());
            }
            else
            {
                Console.WriteLine("No hay robot en esta posición");
            }
        }
        else
        {
            Console.WriteLine("ERROR: Entrada equivocada");
        }
    }

    public static void VerRobot(Robot[] fabrica)
    {
        Console.WriteLine("Introduce posición:");
        int position = int.Parse(Console.ReadLine());

        if (position >= 0 && position < fabrica.Length && fabrica[position] != null)
        {
            Console.WriteLine($"【ROBOT】: {fabrica[position].ObtenerNombre()} - {fabrica[position].ObtenerModelo()}");
        }
        else
        {
            Console.WriteLine("No hay ningún robot en esta posición");
        }
    }

    public static string EliminarRobot(Robot[] fabrica)
    {
       
        Console.WriteLine("Posición:");
        int pos = int.Parse(Console.ReadLine());

        if (pos >= 0 && pos < fabrica.Length && fabrica[pos] != null)
        {
            fabrica[pos] = null;
            Console.WriteLine("【 ROBOT ELIMINADO 】");
        }
        else
        {
            Console.WriteLine("No hay robot en esa posición");
        }
        return null;
    }

    public static void ListarRobots(Robot[] fabrica)
    {
        for (int i = 0; i < fabrica.Length; i++)
        {
            if (fabrica[i] != null)
            {
                Console.WriteLine($"【POSICIÓN】{i} -> {fabrica[i].ObtenerNombre()} - {fabrica[i].ObtenerModelo()}");
            }
            else
            {
                Console.WriteLine($"【POSICIÓN】 {i} -> Vacío");
            }
        }
    }

  
}