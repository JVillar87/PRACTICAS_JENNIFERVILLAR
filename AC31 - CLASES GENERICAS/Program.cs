public class Program
{
    public static void Main(string[] args)
    {
        ApiGenerica<string> texto = new ApiGenerica<string>();
        texto.AgregarElemento("Hola Mundo");
        texto.AgregarElemento("Esto es una prueba");
        texto.AgregarElemento("de API genérica");
        texto.ActualizarElemento(2, "C#");
        texto.ListarElemento(0); 
        texto.ListarElemento(1); 
        texto.BuscarElemento("C#");

        
        ApiGenerica<int> enteros = new ApiGenerica<int>();
        enteros.AgregarElemento(10);
        enteros.AgregarElemento(20);
        enteros.AgregarElemento(30);
        enteros.AgregarElemento(40);
        enteros.ListarElemento(0); 
        enteros.ListarElemento(1);
        enteros.ListarElemento(2);
        enteros.ListarElemento(3);
        enteros.ActualizarElemento(0, 15);
        enteros.ListarElemento(0);
        enteros.BuscarElemento(20);
    
    }
}


public class ApiGenerica<T>
{
    private List<T> elementos;

    public ApiGenerica()
    {
        elementos = new List<T>();
    }

    public void AgregarElemento(T elemento)
    {
        elementos.Add(elemento);
    }

    public void ActualizarElemento(int indice, T nuevoElemento)
    {
        if (indice >= 0 && indice < elementos.Count)
        {
            elementos[indice] = nuevoElemento;
        }
        else
        {
            Console.WriteLine("Fuera de rango");
        }
    }

    public void ListarElemento(int indice)
    {
        if (indice >= 0 && indice < elementos.Count)
        {
            Console.WriteLine(elementos[indice]);
        }
        else
        {
            Console.WriteLine("Fuera de rango");
        }
    }

    public void BuscarElemento(T elemento)
    {
        int indice = elementos.IndexOf(elemento);
        if (indice != -1)
        {
            Console.WriteLine($"Elemento '{elemento}' encontrado en {indice}.");
        }
        else
        {
            Console.WriteLine($"Elemento '{elemento}' no encontrado en la lista.");
        }
    }

    

//     public T ObtenerElemento(int indice)
//     {
//         if (indice >= 0 && indice < elementos.Count)
//         {
//             return elementos[indice];
//         }
//         else
//         {
//             Console.WriteLine("Error! fuera de rango, devuelvo el primer elemento de la lista");
//             return elementos[0];
//         }
//     }

//     public void MostrarElementos()
//     {
//         Console.WriteLine("Elementos almacenados:");
//         foreach (var elemento in elementos)
//         {
//             Console.WriteLine(elemento);
//         }
//     }
}