public class Program
{
    public static void Main()
{
    List<Robot> robots = new List<Robot>();
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
                CrearRobot(robots);
                break;

            case 2:
                NuevoNombre(robots);
                break;

            case 3:
                VerRobot(robots);
                break;
            case 4:
                EliminarRobot(robots);
                break;
            case 5:
                ListarRobots(robots);
                break;
            case 0:
                Console.WriteLine("Saliendo del programa...");
                break;
        }

    } while (opcion != 0);
}

    public static void CrearRobot(List<Robot> robots)
    {
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

        robots.Add(robot);

        Console.WriteLine($"【ROBOT CREADO】 {robot.ObtenerNombre()} - {robot.ObtenerModelo()} en posición {robots.Count - 1}");
    }

    public static void NuevoNombre(List<Robot> robots)
    {
        Console.WriteLine("Introduce posición del robot a resetear:");
        int input = Convert.ToInt32(Console.ReadLine());
        
        if (input >= 0 && input < robots.Count)
        {
            int posicion = input;
            if (robots[posicion] != null)
            {
                robots[posicion].ResetNombre();
                Console.WriteLine("【RESETEADO】 Nuevo nombre: " + robots[posicion].ObtenerNombre());
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

    public static void VerRobot(List<Robot> robots)
    {
        Console.WriteLine("Introduce posición:");
        int position = int.Parse(Console.ReadLine());

        if (position >= 0 && position < robots.Count && robots[position] != null)
        {
            Console.WriteLine($"【ROBOT】: {robots[position].ObtenerNombre()} - {robots[position].ObtenerModelo()}");
        }
        else
        {
            Console.WriteLine("No hay ningún robot en esta posición");
        }
    }

    public static string EliminarRobot(List<Robot> robots)
    {
       
        Console.WriteLine("Posición:");
        int pos = int.Parse(Console.ReadLine());

        if (pos >= 0 && pos < robots.Count && robots[pos] != null)
        {
            robots[pos] = null;
            Console.WriteLine("【 ROBOT ELIMINADO 】");
        }
        else
        {
            Console.WriteLine("No hay robot en esa posición");
        }
        return null;
    }

    public static void ListarRobots(List<Robot> robots)
    {
        for (int i = 0; i < robots.Count; i++)
        {
            if (robots[i] != null)
            {
                Console.WriteLine($"【POSICIÓN】{i} -> {robots[i].ObtenerNombre()} - {robots[i].ObtenerModelo()}");
            }
            else
            {
                Console.WriteLine($"【POSICIÓN】 {i} -> Vacío");
            }
        }
    }

  
}