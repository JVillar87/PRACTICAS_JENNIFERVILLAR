public class Program
{
    public static void Main()
    {

    /*Escribe un programa que solicite al usuario ingresar dos números y realice la división entre ellos. 
    Maneja una excepción cuando el usuario introduce valores no numéricos.*/
    try
        {
        Console.WriteLine("Introduzca el primer numero");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduzca el segundo numero");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int resultado = number1 / number2;
        Console.WriteLine("Su división es: " + resultado);
        }

    catch (FormatException ex)
        {
        Console.WriteLine("Error de formato: " + ex.Message);
        }
    catch (Exception e)
        {
        Console.WriteLine("Ha habido un error: " + e.Message);
        }

    /*Escribe un programa que implemente un método que reciba un número entero como entrada y lance una excepción 
    si el número es negativo. Maneja la excepción en el código que llama al método.*/
    
    try
        {
            Console.Write("Introduce un número entero: ");
            int number = int.Parse(Console.ReadLine());
            ValidarNumeroPositivo(number);
            Console.WriteLine($"El número {number} es válido.");
        }
    catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    catch (FormatException)
        {
            Console.WriteLine("Error: Debes introducir un número entero válido.");
        }
    catch (Exception ex)
        {
           Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
        }


    static void ValidarNumeroPositivo(int numbers)
    {
        if (numbers < 0)
        {
            throw new ArgumentOutOfRangeException(null, "El número no puede ser negativo.");
        }
    }
    
    /*Escribe un programa que lea una ruta de archivo proporcionada por el usuario e intente abrir el archivo. 
    Maneja excepciones si el archivo no existe.*/

    Console.Write("Ingresa la ruta completa del archivo: ");
    string ruta = Console.ReadLine();

        try
        {
            
        }
        catch
        {
            
        }
            
    /*Escribe un programa que solicite al usuario ingresar un número entero.
    Lanza una excepción si el número es menor que 0 o mayor que 1000.*/

    Console.WriteLine("Ingresa un número entero:");
    int numero = int.Parse (Console.ReadLine());

    try
        {
            if (numero >= 1000)
            {
                Console.WriteLine($"Su número es {numero}");
            }
        }
    catch (Exception ex)
        {
            Console.WriteLine ("Ha habido un error" + ex.Message);
        }

    /*Escribe un programa que implemente un método que reciba un arreglo de enteros como entrada y calcule el valor promedio. 
    Maneja la excepción si el índice está fuera de rango*/




    /*Escribe un programa que lea una cadena del usuario y la convierta en un entero. 
    Maneja la excepción si la entrada no se puede  analizar como un entero.*/




    /*Escribe un programa que lea una lista de números enteros del usuario. 
    Maneja la excepción que ocurre si el usuario ingresa un valor fuera del rango de Int32.*/


    /*Escribe un programa que implemente un método que divida dos números. 
    Controla la excepción DivideByZeroException que se produce si el denominador es 0.*/

    Console.WriteLine ("Dame un primer número:");
    int number4 = int.Parse(Console.ReadLine());
    Console.WriteLine("Dame un segundo número:");
    int number5 = int.Parse(Console.ReadLine());

    try
        {
            Console.WriteLine (number4 / number5); 
        }

    catch (System.DivideByZeroException)
        {
            Console.WriteLine("No se puede dividir por 0");
        }


    /*Escribe un programa que lea un número del usuario y calcule su raíz cuadrada. 
    Maneja la excepción si el número es negativo.*/
    
    double number6=0;
    double result=0;

    try
        {
           Console.WriteLine("Proporcione un número:");
            number6 = int.Parse(Console.ReadLine()); 
            result = Math.Sqrt(number6);
        }

    catch
        {
           if (result < 0)
            {
            throw new ArithmeticException("El resultado no puede ser negativo.");
            }
        }

    /*Escribe un programa que cree un método que tome una cadena como entrada y la convierta a mayúsculas. 
    Controla la excepción NullReferenceException que se produce si la cadena de entrada es nula.*/

    


    }
}