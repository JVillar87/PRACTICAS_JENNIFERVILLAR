using System;

// MUESTRA EJERCICIO

int numA, numB;

Console.WriteLine("Introduce un número A:");
numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduce un número B:");
numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("El producto de A y B es " + (numA * numB));

// Convert.ToInt32(Console.ReadLine()); transforma texto en número entero
// int hace referencia al número entero; numA y numB son variables que almacenan los números introducidos por el usuario

//Ejercicio 1
int numeroUsuario;
Console.WriteLine("Dame un número:");
numeroUsuario = Convert.ToInt32(Console.ReadLine());

if (numeroUsuario < 20)
{
    Console.WriteLine("El número es menor que 20.");
}
Console.WriteLine("Fin del programa.");

//Ejercicio 2


Console.WriteLine("Dame un número A:");
numA = Convert.ToInt32(Console.ReadLine());

if (numA == 0)
{
    Console.WriteLine("El producte de 0 per qualsevol número és 0");
}
else if (numA > 0)
{
    Console.WriteLine("Dame otro número B.");
    numB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("El producto de A y B es " + (numA * numB));
}
else
{
    Console.WriteLine("Fin del programa.");
}

//Ejercicio 3

Console.WriteLine("Dame un número A:");
numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Dame un número B:");
numB = Convert.ToInt32(Console.ReadLine());
if (numA % 2 == 0 && numA % 3 != 0)
{
    Console.WriteLine("El número A es par y no es múltiplo de 3.");
}
{
    Console.WriteLine("Fin del programa.");
}
//Ejercicio 4

Console.WriteLine("Dame un número A:");
numA = Convert.ToInt32(Console.ReadLine());
if (numA % 2 == 0 && numA < 10)
{
    Console.WriteLine("El número A es par y menor que 10.");
}
{
    Console.WriteLine("Fin del programa.");

}
