public class Program
{
    public static void Main(string[] args)
    {
        List<Empleado> empleados = new List<Empleado>
        {
            new Empleado ("Laura", 28, "Marketing"),
            new Empleado ("Carlos", 35, "Ventas"),
            new Empleado ("Sofía", 23, "Marketing"),
            new Empleado ("Javier", 42, "Finanzas"),
            new Empleado ("Marta", 31, "Ventas")
        };


        //Obtener empleados menores de 20 años
        var empleadosMenores20 = from empleado in empleados
                                 where empleado.Edad < 20
                                 select empleado;
        Console.WriteLine("Empleados menores de 20 años:");
        foreach (var empleado in empleadosMenores20)
        {
            if (empleado.Edad < 20)
            {
                Console.WriteLine($"{empleado.Nombre}, {empleado.Edad} años");
            }
            else
            {
                Console.WriteLine("SIN EMPLEADOS MENORES DE 20 AÑOS");
            }
        }

        //Haz una media de edad de todos los empleados
        var mediaEdad = (from empleado in empleados
                         where empleado.Edad > 0
                         select empleado.Edad).Average();
        Console.WriteLine($"La edad mediade los empleados es de {mediaEdad} años");


        //Ordena la lista de empleados por departamento en orden ascendente 
        var empleadosOrdenados = from empleado in empleados
                                 orderby empleado.Departamento ascending
                                 select empleado;
        Console.WriteLine("Empleados ordenados por departamento:");
        foreach (var empleado in empleadosOrdenados)
        {
            Console.WriteLine($"{empleado.Nombre}, {empleado.Edad} años, Departamento: {empleado.Departamento}");
        }


        //Selecciona el empleado de mayor edad 
        var empleadoMayorEdad = (from empleado in empleados
                                 orderby empleado.Edad descending
                                 select empleado).First();
        Console.WriteLine($"El empleado de mayor edad es: {empleadoMayorEdad.Nombre} con {empleadoMayorEdad.Edad} años");


        //Selecciona el primer empleado que tenga más de 30 años
        var primerEmpleadoMayor30 = (from empleado in empleados
                                     where empleado.Edad > 30
                                     select empleado).First();
        Console.WriteLine($"El primer empleado con más de 30 años es: {primerEmpleadoMayor30?.Nombre} con {primerEmpleadoMayor30?.Edad} años");


        //Selecciona los 2 primeros empleados
        var primerosDosEmpleados = empleados.Take(2);
        Console.WriteLine("Los 2 primeros empleados son:");
        foreach (var empleado in primerosDosEmpleados)
        {
            Console.WriteLine($"{empleado.Nombre}, {empleado.Edad} años, Departamento: {empleado.Departamento}");
        }




    }

    public class Empleado
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Departamento { get; set; }

        public Empleado(string nombre, int edad, string departamento)
        {
            Nombre = nombre;
            Edad = edad;
            Departamento = departamento;
        }
    }
}
