using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Introduce un número A:");
        numA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce un número B:");
        numB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("El producto de A y B es " + (numA * numB));

      
    }
}