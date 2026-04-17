using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {
        //Valida una dirección de correo electrónico (ej. usuario@dominio.com).
        string texto = @"Los correos electrónicos son una forma común de comunicación en la era digital. Un correo electrónico consta de varias partes, como el remitente, el destinatario, el asunto y el cuerpo del mensaje.
        Algunos ejemplos de direcciones de correo electrónico son: usuario@gmail.com, contacto@empresa.com, soporte@servicio123.net. 
        En el ámbito de la programación, las expresiones regulares son útiles para validar y buscar patrones en direcciones de correo electrónico.
        Las expresiones regulares se pueden utilizar en muchos lenguajes de programación, incluyendo C#, Python, JavaScript, Java…";

        string patternEmail = @"^[A-Za-z0-9._%+-]+@[A-Za-z]+\.[A-Za-z]{2,}";
        var matchesEmail = Regex.Matches(texto, patternEmail);
        foreach (Match mail in matchesEmail)
            Console.WriteLine($"Email encontrado: {mail.Value}");

        /*CON ESTE MÉTODO SOLO ENCONTRAMOS TODAS LAS COINCIDENCIAS*/

        //Valida un número de teléfono con formato de 10 dígitos(ej. 123 - 456 - 7890).
        string textPhone = @"Los números de teléfono son una forma común de contacto en la vida cotidiana. Un número de teléfono consta de varias partes, como el código de área, el número local y el número de extensión.
        Algunos ejemplos de números de teléfono son: 123-456-7890, +34-659-985-002, (555) 123-4567 o 975321753.
        En el ámbito de la programación, las expresiones regulares son útiles para validar y buscar patrones en números de teléfono.";

        string patternPhone = @"^\d{3}-\d{3}-\d{3,4}";
        var matchesPhone = Regex.Matches(textPhone, patternPhone);
        foreach (Match phone in matchesPhone)
            Console.WriteLine($"Teléfono válido: {phone.Value}");

        /*UTILIZAMOS ESTE MÉTODO PARA ENCONTRAR TODAS LAS COINCIDENCIAS DE UN PATRÓN EN UNA CADENA DE TEXTO*/

        //Valida una fecha en formato día/ mes / año ej. 29 / 02 / 2024).
        string NewText = @"Las fechas son una parte fundamental de nuestra vida diaria. Una fecha consta de varias partes, como el día, el mes y el año.
        Algunos ejemplos de fechas son: 29/02/2024, 15/08/2023, 01-01-2022 o 31.12.2021.";
        string patternDate = @"^\d{2}/\d{2}/\d{4}";

        var matchesDate = Regex.Matches(NewText, patternDate);
        foreach (Match date in matchesDate)
            Console.WriteLine($"Fecha encontrada: {date.Value}");

        /*UTILIZAMOS ESTE MÉTODO PARA ENCONTRAR TODAS LAS COINCIDENCIAS DE UN PATRÓN EN UNA CADENA DE TEXTO, IGUAL QUE EL ANTERIOR*/

        //Valida una dirección IP en formato IPv4(ej. 192.168.1.1).
        string TextIP = @"Las direcciones IP son una parte fundamental de la infraestructura de Internet. Una dirección IP consta de varias partes, como el número de red, el número de host y el número de subred.
        Algunos ejemplos de direcciones IP son: 192.168.1.55 o 172.192.0.1.";

        string patternIP = @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}";
        foreach (Match ip in Regex.Matches(TextIP, patternIP))
            Console.WriteLine($"Dirección IP encontrada: {ip.Value}");

        /*IGUAL QUE EN LOS ANTERIORES, CREO QUE ES EL MEJOR FORMATO PARA TEXTO CON NÚMEROS ENTEROS, PERO CON UN FORMATO ESPECÍFICO DE DIRECCIÓN IP.*/

        //Valida un código postal de 5 dígitos(ej. 12345).
        string TextPostalCode = @"Los códigos postales son una parte fundamental del sistema de correo. Un código postal consta de varias partes, como el número de zona, el número de distrito y el número de sector.
        Algunos ejemplos de códigos postales son: 12345, 54321 o 98765.";

        string patternPostalCode = @"\d{5}";
        foreach (Match postalCode in Regex.Matches(TextPostalCode, patternPostalCode))
            Console.WriteLine($"Código postal encontrado: {postalCode.Value}");

        /*SEGUIMOS UTILIZANDO UN MÉTODO EFECTIVO PARA INT*/

        //Valida una palabra que contenga solo letras, sin números ni caracteres especiales(ej. "Hola").
        string TextWord = @"Hola, Mundo!";

        string patternWord = @"[A-Za-z]+";
        if (Regex.IsMatch(TextWord, patternWord))
            Console.WriteLine($"'{TextWord}' es una palabra válida.");
        /*CON ESTE MÉTODO BUSCA UNA PALABRA QUE COMIENCE Y TERMINE CON LETRAS, SIN NÚMEROS NI CARACTERES ESPECIALES.*/

        //Valida un número entero positivo, que puede tener más de un dígito(ej. 123).
        string TextPositive = @"Encontramos números en casi cualquier texto. Algunos ejemplos de números enteros positivos son: 123, 456789 o 987654321. 
        En el ámbito de la programación, las expresiones regulares son útiles para validar y buscar patrones en números enteros positivos.";

        string patternINTpositive = @"[1-9]\d{0,8}";
        foreach (Match INT in Regex.Matches(TextPositive, patternINTpositive))
        {
            Console.WriteLine($"{INT.Value} - Número entero positivo válido");
        }
        /*CON ESTE MÉTODO BUSCA UN NÚMERO ENTERO POSITIVO QUE COMIENCE CON UN DÍGITO DEL 1 AL 9 Y PUEDE TENER HASTA 9 DÍGITOS.*/

        //Valida una URL(ej.http://www.ejemplo.com/).
        string TextURL = @"Las URL son una parte fundamental de la navegación web. Una URL consta de varias partes, como el protocolo, el nombre de dominio y la ruta.
        Algunos ejemplos de URL son: http://www.ejemplo.com/, https://www.google.com/ o http://www.misitio.net/. 
        // En el ámbito de la programación, las expresiones regulares son útiles para validar y buscar patrones en URL.";

        string patternURL = @"https?://[A-Za-z0-9.-]+\.[A-Za-z][A-Za-z]m";
        MatchCollection matchesURL = Regex.Matches(TextURL, patternURL);

        foreach (Match url in matchesURL)
        {
            Console.WriteLine($"URL encontrada: {url.Value}");
        }

        /*CON ESTE MÉTODO BUSCA UNA URL QUE COMIENCE CON "http://" O "https://", SEGUIDO DE UN NOMBRE DE DOMINIO Y UNA EXTENSIÓN DE DOMINIO.*/

        //Valida un código de color hexadecimal(ej. #A3C1D7).
        string TextColor = @"Los códigos de color hexadecimal son una forma común de representar colores en la web. Un código de color hexadecimal consta de varias partes, como el símbolo # seguido de seis dígitos hexadecimales que representan los valores de rojo, verde y azul.
        Algunos ejemplos de códigos de color hexadecimal son: #A3C1D7, #FF5733 o #00FF00. En el ámbito de la programación, las expresiones regulares son útiles para validar y buscar patrones en códigos de color hexadecimal.";

        string patternHexColor = @"#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})\b";
        MatchCollection matchesHexColor = Regex.Matches(TextColor, patternHexColor);
        foreach (Match m in matchesHexColor)
        {
            Console.WriteLine($"Código de color hexadecimal encontrado: {m.Value}");
        }

        /* UTILIZAMOS MATCHCOLLECTION PARA ENCONTRAR TODAS LAS COINCIDENCIAS DE CÓDIGOS DE COLOR HEXADECIMAL EN EL TEXTO.*/

        //Valida un número decimal con punto(ej. 12.23)
        string TextDecimal = @"Los números decimales son una parte fundamental de las matemáticas y la ciencia. Un número decimal consta de varias partes, como la parte entera, el punto decimal y la parte fraccionaria.
        Algunos ejemplos de números decimales son: 12.23, 3.14159 o 0.001. En el ámbito de la programación, las expresiones regulares son útiles para validar y buscar patrones en números decimales.";

        string patternDecimal = @"\d+\.\d+";
        if (Regex.IsMatch(TextDecimal, patternDecimal))
        {
            Console.WriteLine($"Número decimal válido: {Regex.Match(TextDecimal, patternDecimal).Value}");
        }

        /*REGRESAMOS AL IsMatch PARA VALIDAR UN NÚMERO DECIMAL CON PUNTO, YA QUE ES UNA FORMA EFECTIVA DE ENCONTRAR NÚMEROS DECIMALES EN EL TEXTO.*/
    }
}