
public class Program
{
    public static void Main(string[] args)
    {
        ApiGenerica<Cliente> apiClientes = new ApiGenerica<Cliente>();
        apiClientes.AgregarElemento(new Cliente { Nombre = "Juan", Email = "juan@example.com" });
        apiClientes.AgregarElemento(new Cliente { Nombre = "Maria", Email = "maria@example.com" });
        apiClientes.AgregarElemento(new Cliente { Nombre = "Laura", Email = "laura@example.com" });
        apiClientes.AgregarElemento(new Cliente { Nombre = "Pedro", Email = "pablo@example.com"});
        apiClientes.EliminarElemento(1);
        ApiGenerica<Productos> apiProductos = new ApiGenerica<Productos>();
        apiProductos.AgregarElemento(new Productos { Nombre = "Laptop", Precio = 999.99F, Stock = 10 });
        apiProductos.AgregarElemento(new Productos { Nombre = "Smartphone", Precio = 499.99F, Stock = 20 });
        apiProductos.AgregarElemento(new Productos { Nombre = "Television", Precio = 399.99F, Stock = 15 });
        apiProductos.EliminarElemento(2);
        ApiGenerica<Empleados> apiEmpleados = new ApiGenerica<Empleados>();
        apiEmpleados.AgregarElemento(new Empleados { Nombre = "Ana", Puesto = "Gerente", Antiguedad = 5});
        apiEmpleados.AgregarElemento(new Empleados { Nombre = "Carlos", Puesto = "Vendedor", Antiguedad = 2 });
        apiEmpleados.AgregarElemento(new Empleados { Nombre = "Sofia", Puesto = "Asistente", Antiguedad = 10 });
        apiEmpleados.EliminarElemento(1);
        Console.WriteLine("Clientes:");
        apiClientes.MostrarElementos();
        Console.WriteLine("Productos:");
        apiProductos.MostrarElementos();
        Console.WriteLine("Empleados:");
        apiEmpleados.MostrarElementos();

    }
}


public class Cliente
{
    public required string Nombre { get; set; }
    public required string Email { get; set; }
    

    public override string ToString()
    {
        return $"Nombre: {Nombre}, Email: {Email}";
    }
}

public class Productos
{
    public required string Nombre { get; set; }
    public required int Stock { get; set; }
    public required float Precio { get; set; }
    public override string ToString()
    {
        return $"Nombre: {Nombre}, Precio: {Precio}, Stock: {Stock}";
    }
}

public class Empleados
{
    public required string Nombre { get; set; }
    public required string Puesto { get; set; }
    public required int Antiguedad { get; set; }
    public override string ToString()    {
        return $"Nombre: {Nombre}, Puesto: {Puesto}, Antiguedad: {Antiguedad} años";
    }
}

public class ApiGenerica<T>
{
    private List<T> Elementos;

    public ApiGenerica()
    {
     Elementos = new List<T>();
    }

    public void AgregarElemento(T elemento)
    {
        Elementos.Add(elemento);
    }

    public void ActualizarElemento(int indice, T nuevoElemento)
    {
        if (indice >= 0 && indice < Elementos.Count)
        {
            Elementos[indice] = nuevoElemento;
        }
        else
        {
            Console.WriteLine("Fuera de rango");
        }
    }

    public void BuscarElemento(T elemento)
    {
        int indice = Elementos.IndexOf(elemento);
        if (indice != -1)
        {
            Console.WriteLine($"Elemento '{elemento}' encontrado en {indice}.");
        }
        else
        {
            Console.WriteLine($"Elemento '{elemento}' no encontrado en la lista.");
        }
    }

    public void EliminarElemento(int indice)
    {
        if (indice >= 0 && indice < Elementos.Count)
        {
            Elementos.RemoveAt(indice);
        }
        else
        {
            Console.WriteLine("Fuera de rango");
        }
    }

    public T ObtenerElemento(int indice)
    {
        if (indice >= 0 && indice < Elementos.Count)
        {
            return Elementos[indice];
        }
        else
        {
            Console.WriteLine("Error! fuera de rango");
            return Elementos[0];
        }
    }

    public void MostrarElementos()
    {
        Console.WriteLine("Elementos almacenados:");
        foreach (var elemento in Elementos)
        {
            Console.WriteLine(elemento);
        }
    }
}