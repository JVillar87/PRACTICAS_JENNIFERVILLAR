internal class Program
{


    Pokemon A = new Pokemon();
    Pokemon B = new Pokemon();

    static void Main()
    {
        /* [[ FASE 1: INICIALIZACIÓN ]] */
        // Mostrar título del juego.
        Console.WriteLine("========= Bienvenido ======");
        Console.WriteLine("=== al Juego de Batallas ===");
        Console.WriteLine("========== POKÉMON =========");


        //Declaramos la matriz principal de equipos Pokémon.
        Pokemon[,] equipos = new Pokemon[2, 3];

        //Inicializamos los equipos de ambos jugadores.
        //Se inicia el equipo del Jugador.
        equipos[0, 0] = new Pokemon { nombre = "Charmander", tipo = "Fuego", vida = 100, vidaMaxima = 100, ataque = 40, defensa = 20, estaVivo = true };
        equipos[0, 1] = new Pokemon { nombre = "Bulbasaur", tipo = "Planta", vida = 110, vidaMaxima = 110, ataque = 35, defensa = 25, estaVivo = true };
        equipos[0, 2] = new Pokemon { nombre = "Squirtle", tipo = "Agua", vida = 105, vidaMaxima = 105, ataque = 38, defensa = 22, estaVivo = true };

        //Se inicia el equipo del enemigo (CPU).
        equipos[1, 0] = new Pokemon { nombre = "Pikachu", tipo = "Eléctrico", vida = 95, vidaMaxima = 95, ataque = 42, defensa = 18, estaVivo = true };
        equipos[1, 1] = new Pokemon { nombre = "Geodude", tipo = "Roca", vida = 120, vidaMaxima = 120, ataque = 30, defensa = 30, estaVivo = true };
        equipos[1, 2] = new Pokemon { nombre = "Pidgey", tipo = "Volador", vida = 90, vidaMaxima = 90, ataque = 36, defensa = 22, estaVivo = true };


        //Creamos un objeto Random para la generación de números aleatorios.
        //Probabilidad de golpe crítico.
        Random random = new Random();

        // Mostramos el equipo del jugador.
        Console.WriteLine("\n--- TU EQUIPO ---");

        int contador = 0;


        foreach (var equipoA in equipos)
        {

            if (contador < 3)
            {
                Console.WriteLine($"Nombre: {equipoA.nombre} (Tipo: {equipoA.tipo}, Vida: {equipoA.vida}, Ataque: {equipoA.ataque}, Defensa: {equipoA.defensa})");
            }

            contador++;
        }
        Console.WriteLine();

        // Mostramos el equipo del enemigo (CPU)
        Console.WriteLine("\n--- EQUIPO RIVAL---");

        int contadorRival = 0;

        foreach (var equipoB in equipos)
        {


            if (contadorRival > 2)
            {
                Console.WriteLine($"Nombre: {equipoB.nombre} (Tipo: {equipoB.tipo}, Vida: {equipoB.vida}, Ataque: {equipoB.ataque}, Defensa: {equipoB.defensa})");
            }

            contadorRival++;
        }
        Console.WriteLine();

        /* [[ FASE 2: PERSONALIZAR POKÉMON ]] */
        //Personalización del primer Pokémon del jugador.
        Console.WriteLine("¿Deseas personalizar tu primer Pokémon? (s/n): ");
        string respuesta = Console.ReadLine();

        if (respuesta == "s" || respuesta == "S")
        {
            Console.Write("Nombre: "); // Personalizamos el nombre.
            equipos[0, 0].nombre = Console.ReadLine();

            Console.Write("Vida (50-150): "); // Personalizamos la vida.
            int vidaEntrada = int.Parse(Console.ReadLine());
            if (vidaEntrada < 50) vidaEntrada = 50;
            if (vidaEntrada > 150) vidaEntrada = 150;
            equipos[0, 0].vida = vidaEntrada;
            equipos[0, 0].vidaMaxima = vidaEntrada;

            Console.Write("Ataque (20-50): "); // Personalizamos el ataque.
            int atqEntrada = int.Parse(Console.ReadLine());
            if (atqEntrada < 20) atqEntrada = 20;
            if (atqEntrada > 50) atqEntrada = 50;
            equipos[0, 0].ataque = atqEntrada;

            Console.Write("Defensa (10-35): "); // Personalizamos la defensa.
            int defEntrada = int.Parse(Console.ReadLine());
            if (defEntrada < 10) defEntrada = 10;
            if (defEntrada > 35) defEntrada = 35;
            equipos[0, 0].defensa = defEntrada;

            Console.WriteLine("\nTu Pokémon ha sido actualizado:\n");
            Pokemon EquipoMod = equipos[0, 0];
            Console.WriteLine($"{EquipoMod.nombre} ({EquipoMod.tipo}) HP: {EquipoMod.vida}/{EquipoMod.vidaMaxima} ATQ: {EquipoMod.ataque} | DEF: {EquipoMod.defensa}\n");
        }

        /* [[ FASE 2: PERSONALIZAR POKÉMON ]] */
        Console.WriteLine("¡La batalla va a comenzar!");
        int turno = 0; // 0 para el jugador, 1 para la CPU.
        bool combateActivo = true;

        int indiceActivo = 0;
        int indiceObjetivo = 0;

        while (combateActivo)
        {
            Console.WriteLine($"\n--- TURNO DEL {(turno == 0 ? "JUGADOR" : "CPU")} ---");

            // Selección del Pokémon activo.

            if (turno == 0)
            {
                // Turno del jugador: seleccionar Pokémon.
                Console.WriteLine("Selecciona tu Pokémon activo:");
                Pokemon EquipoMod;
                for (int i = 0; i < 3; i++)
                {
                    EquipoMod = equipos[0, i];
                    if (EquipoMod.estaVivo)
                    {
                        Console.WriteLine($"{i + 1}. {EquipoMod.nombre} (Vida: {EquipoMod.vida})");
                    }
                }
                indiceActivo = int.Parse(Console.ReadLine()); ;

            }
            else
            {
                // Turno de la CPU: seleccionar Pokémon aleatoriamente.
                do
                {
                    indiceActivo = random.Next(0, 3);
                } while (!equipos[1, indiceActivo].estaVivo);
                Console.WriteLine($"El enemigo (CPU) ha seleccionado a {equipos[1, indiceActivo].nombre}.");
            }

            // Selección del objetivo.
            ;
            if (turno == 0)
            {
                // Turno del jugador: seleccionar objetivo.
                Console.WriteLine("Selecciona el Pokémon objetivo:");
                for (int i = 0; i < 3; i++)
                {
                    Pokemon EquipoB = equipos[1, i];
                    if (EquipoB.estaVivo)
                    {
                        Console.WriteLine($"{i + 1}. {EquipoB.nombre} (Vida: {EquipoB.vida})");
                    }
                }
                indiceObjetivo = int.Parse(Console.ReadLine());
            }
            else
            {
                // Turno de la CPU: seleccionar objetivo aleatoriamente.
                do
                {
                    indiceObjetivo = random.Next(0, 3);
                } while (!equipos[0, indiceObjetivo].estaVivo);
                Console.WriteLine($"El enemigo ha seleccionado atacar a {equipos[0, indiceObjetivo].nombre}.");
            }

            // Comprobar si algún equipo ha perdido.
            int A = -1; // Índice del primer Pokémon vivo del jugador.
            for (int i = 0; i < 3; i++)
            {
                if (equipos[0, i].estaVivo)
                {
                    A = i;
                }
            }
            int B = -1; // Índice del primer Pokémon vivo del enemigo.
            for (int i = 0; i < 3; i++)
            {
                if (equipos[1, i].estaVivo)
                {
                    B = i;
                }
            }  //Si alguno no tiene Pokémon vivos, termina el combate.

            Console.Write("¿Deseas atacar? (s/n): "); // Opción de rendirse o continuar.
            string accion = Console.ReadLine();
            if (accion == "n" || accion == "N")
            {
                Console.WriteLine("¡Te has rendido! La CPU gana.");
                combateActivo = false;
            } // cualquier otra entrada se trata como 's' (continuar)
            break;
        }

        /* [[ FASE 4: ATAQUES ]] */

        // Ataque del jugador.
        Console.WriteLine($"\n{equipos[0, indiceActivo].nombre} ataca a {equipos[1, indiceObjetivo].nombre}!");
        int damage = equipos[0, indiceActivo].ataque - equipos[1, indiceObjetivo].defensa;

        if (damage < 1) damage = 1;
        if (damage > 50) damage = 50;
        if (random.Next(0, 100) < 15) // 15% de probabilidad de golpe crítico
        {
            damage *= 2;
            Console.WriteLine("¡Golpe crítico!");
        }
        equipos[1, indiceObjetivo].vida -= damage;
        Console.WriteLine($"{equipos[1, indiceObjetivo].nombre} recibe {damage} puntos de daño.");

        if (equipos[1, indiceObjetivo].vida <= 0) // Comprobar si el Pokémon ha sido debilitado.
        {
            equipos[1, indiceObjetivo].estaVivo = false;
            equipos[1, indiceObjetivo].vida = 0;
            Console.WriteLine($"{equipos[1, indiceObjetivo].nombre} se ha debilitado.");
        }
        else
        {
            Console.WriteLine($"{equipos[1, indiceObjetivo].nombre} tiene {equipos[1, indiceObjetivo].vida} puntos de vida restantes.");
        }
        // Comprobamos si el enemigo (CPU) ha perdido.
        bool cpuDerrotada = true;
        for (int c = 0; c < 3; c++)
        {
            if (equipos[1, c].estaVivo)
            {
                cpuDerrotada = false;
                break;
            }
        }
        if (cpuDerrotada)
        {
            Console.WriteLine("\n¡Has derrotado a todos los Pokémon de tu enemigo! ¡Has ganado!");
        }

        // Ataque del enemigo (CPU), si es que sigue con vida.

        Console.WriteLine($"\n{equipos[1, indiceObjetivo].nombre} ataca a {equipos[0, indiceActivo].nombre}!");
        damage = equipos[1, indiceObjetivo].ataque - equipos[0, indiceActivo].defensa;

        if (damage < 1) damage = 1;
        if (damage > 50) damage = 50;
        if (random.Next(0, 100) < 15) // 15% de probabilidad de golpe crítico
        {
            damage *= 2;
            Console.WriteLine("¡Golpe crítico!");
        }
        equipos[0, 0].vida -= damage;
        Console.WriteLine($"{equipos[0, 0].nombre} recibe {damage} puntos de daño.");

        // Comprobamos si el Pokémon ha sido debilitado.
        if (equipos[0, indiceActivo].vida <= 0)
        {
            equipos[0, indiceActivo].estaVivo = false;
            equipos[0, indiceActivo].vida = 0;
            Console.WriteLine($"{equipos[0, indiceActivo].nombre} se ha debilitado.");
        }
        else
        {
            Console.WriteLine($"{equipos[0, indiceActivo].nombre} tiene {equipos[0, indiceActivo].vida} puntos de vida restantes.");
        }

        bool jugadorDerrotado = true; // Comprobamos si el jugador ha perdido todos sus Pokémon.
        for (int c = 0; c < 3; c++)
        {
            if (equipos[0, c].estaVivo)
            {
                jugadorDerrotado = false;
            }
        }
        if (jugadorDerrotado)
        {
            Console.WriteLine("\nTodos tus Pokémon han sido derrotados. El enemigo (CPU) gana.");
        }
        turno = turno + 1; // Cambiamos de turno.

        /* [[ FASE 5: FINALIZACIÓN ]] */
        Console.WriteLine("=================================");
        Console.WriteLine("         FIN DEL COMBATE         ");
        Console.WriteLine("=================================");

        Console.WriteLine("=== ESTADO FINAL - JUGADOR ==="); //Estado de los Pokémon del jugador.
        for (int c = 0; c < 3; c++)
        {
            Pokemon p = equipos[0, c];
            string estado = p.estaVivo ? "VIVO" : "DERROTADO";
            Console.WriteLine($"{p.nombre} ({p.tipo}) HP: {p.vida}/{p.vidaMaxima} - {estado}");
        }
        Console.WriteLine();

        Console.WriteLine("=== ESTADO FINAL - CPU ==="); //Estado de los Pokémon del enemigo (CPU).
        for (int c = 0; c < 3; c++)
        {
            Pokemon p = equipos[1, c];
            string estado = p.estaVivo ? "VIVO" : "DERROTADO";
            Console.WriteLine($"{p.nombre} ({p.tipo}) HP: {p.vida}/{p.vidaMaxima} - {estado}");
        }

        Console.WriteLine("\nGracias por jugar. Pulsa Enter para salir.");
        Console.ReadLine();

    }


}


struct Pokemon
{
    public string nombre; // Nombre del Pokémon (ej: "Charmander") 
    public string tipo; // Tipo elemental (ej: "Fuego", "Agua", "Planta") 
    public int vida; // Puntos de vida actuales 
    public int vidaMaxima; // Vida máxima (para mostrar barras de vida) 
    public int ataque; // Poder de ataque base 
    public int defensa; // Capacidad defensiva 
    public bool estaVivo; // true si vida > 0, false si vida <= 0   
}


