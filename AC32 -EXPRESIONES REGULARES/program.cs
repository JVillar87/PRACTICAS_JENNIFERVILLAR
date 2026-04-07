using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {
        //Valida una dirección de correo electrónico (ej. usuario@dominio.com).
        string patternEmail = @"[A-Za-z0-9._%+-]+@[A-Za-z]+\.[A-Za-z]m";
        /*UTILIZAMOS ESTE MÉTOCO PARA QUE ME BUSQUE CUALQUIER CARACTER QUE SE ENCUENTRE
        ANTES DE LA @, LUEGO BUSQUE UNA PALABRA QUE SE ENCUENTRE ENTRE LA @ Y EL PUNTO, 
        Y POR ÚLTIMO BUSQUE UNA PALABRA QUE SE ENCUENTRE DESPUÉS DEL PUNTO.*/

        //Valida un número de teléfono con formato de 10 dígitos(ej. 123 - 456 - 7890).
        string patternPhone = @"\d{3}-\d{3}-\d{3}";
        /*CON ESTE MÉTODO BUSCA 3 DÍGITOS SEGUIDOS DE UN GUION, LUEGO OTROS 3 SEGUIDOS DE 
        OTRO GUION, Y POR ÚLTIMO OTROS 3 DÍGITOS.*/

        //Valida una fecha en formato día/ mes / año ej. 29 / 02 / 2024).
        string patternDate = @"\d{2}/\d{2}/\d{4}";
        /*CON ESTE MÉTODO BUSCA 2 DÍGITOS SEGUIDOS DE UN GUION, LUEGO OTROS 2 DÍGITOS SEGUIDOS 
        DE OTRO GUION, Y POR ÚLTIMO OTROS 4 DÍGITOS.*/

        //Valida una dirección IP en formato IPv4(ej. 192.168.1.1).
        string patternIP = @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}";
        /*CON ESTE MÉTODO BUSCA ENTRE 1 Y 3 DÍGITOS SEGUIDOS DE UN PUNTO, 
        LUEGO OTROS ENTRE 1 Y 3 DÍGITOS SEGUIDOS DE OTRO PUNTO, Y ASÍ HASTA TENER 4 GRUPOS 
        DE DÍGITOS SEGUIDOS DE UN PUNTO.*/

        //Valida un código postal de 5 dígitos(ej. 12345).
        string patternPostalCode = @"\d{5}$";
        /*CON ESTE MÉTODO BUSCA 5 DÍGITOS SEGUIDOS.*/

        //Valida una palabra que contenga solo letras, sin números ni caracteres especiales(ej. "Hola").
        string patternWord = @"^[A-Za-z]+$";
        /*CON ESTE MÉTODO BUSCAMOS UNA PALABRA QUE COMIENCE CON UNA LETRA MAYÚSCULA O MINÚSCULA
        Y QUE NO CONTENGA NINGÚN NÚMERO NI CARACTER ESPECIAL.*/

        //Valida un número entero positivo, que puede tener más de un dígito(ej. 123).
        string patternPositiveInteger = @"^[1-9]{9}$";
        /*CON ESTE MÉTODO BUSCA UN NÚMERO DE HASTA 9 DÍGITOS.*/

        //Valida una URL(ej.http://www.ejemplo.com/).
        string patternURL = @"^https?://[A-Za-z0-9.-]+\.[A-Za-z][A-Za-z]m$";
        /*CON ESTE MÉTODO BUSCA UNA URL QUE COMIENCE CON "http://" O "https://",
        LUEGO BUSCA UNA SECUENCIA DE CARACTERES QUE PUEDE INCLUIR LETRAS, NÚMEROS Y CARACTERES,
        SEGUIDA DE UN PUNTO Y UNA EXTENSIÓN DE DOMINIO QUE TERMINE EN -M. 
        TOMO EL EJEMPLO CON .COM, ELIMINANDO CUALQUIERO OTRA EXTENSIÓN DE DOMINIO TIPO .es; .org, ETC.*/

        //Valida un código de color hexadecimal(ej. #A3C1D7).
        string patternHexColor = @"^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$";
        /*CON ESTE MÉTODO BUSCA UN CÓDIGO DE COLOR HEXADECIMAL QUE COMIENCE CON UN "#",
        SEGUIDO DE 6 O 3 CARACTERES (LETRAS DE LA A A LA F Y NÚMEROS DEL 0 AL 9).*/

        //Valida un número decimal con punto(ej. 12.23)
        string patternDecimal = @"^\d+\.\d+$";
        /*CON ESTE MÉTODO BUSCA UN NÚMERO DECIMAL QUE COMIENCE CON UNO O MÁS DÍGITOS, 
        SEGUIDO DE UN PUNTO Y UNO O MÁS DÍGITOS.*/
    }
}