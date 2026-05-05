using System.Data.SQLite;

public class Program
{
    public static void Main(string[] args)
    { /*CRUD SQLITE*/

        string connectionString = "Data Source=USUARIOS.db";
        SQLiteConnection connection = new SQLiteConnection(connectionString);

        connection.Open();
        CREATE(connection);

        while (true)
        {
            MostrarMenu();
            string opcion = Console.ReadLine() ?? "";

            switch (opcion)
            {
                case "1":
                    INSERT(connection);
                    break;
                case "2":
                    READ(connection);
                    break;
                case "3":
                    SEARCHbyID(connection);
                    break;
                case "4":
                    UPDATE(connection);
                    break;
                case "5":
                    DELETE(connection);
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intenta de nuevo.");
                    break;
            }
        }

        connection.Close();

        //MOSTRAR MENU
        void MostrarMenu()
        {
            Console.WriteLine("--- Menú CRUD SQLite ---");
            Console.WriteLine("1. Añadir datos");
            Console.WriteLine("2. Leer registro");
            Console.WriteLine("3. Buscar por ID");
            Console.WriteLine("4. Actualizar datos");
            Console.WriteLine("5. Eliminar datos");
            Console.Write("Selecciona una opción: ");
        }


        //CREAMOS TABLA USUARIOS
        void CREATE(SQLiteConnection connection)
        {
            string createTableQuery = "CREATE TABLE IF NOT EXISTS USUARIOS (ID INTEGER PRIMARY KEY AUTOINCREMENT, NOMBRE TEXT, EDAD INTEGER, EMAIL TEXT)";
            SQLiteCommand createCommand = new SQLiteCommand(createTableQuery, connection);
            {
                createCommand.ExecuteNonQuery();
            }
        }

        //AÑADIMOS REGISTROS
        void INSERT(SQLiteConnection connection)
        {
            string insertQuery = "INSERT INTO USUARIOS (NOMBRE, EDAD, EMAIL) VALUES (@nombre, @edad, @email)";
            SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection);
            Console.WriteLine("¿Nombre?");
            string Name = Console.ReadLine() ?? "";
            Console.WriteLine("¿edad?");
            int age = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("¿email?");
            string email = Console.ReadLine() ?? "";

            {
                insertCommand.Parameters.AddWithValue("@nombre", Name);
                insertCommand.Parameters.AddWithValue("@edad", age);
                insertCommand.Parameters.AddWithValue("@email", email);
                insertCommand.ExecuteNonQuery();
            }
        }

        //LEEMOS REGISTROS EN LISTA
        void READ(SQLiteConnection connection)
        {
            string selectQuery = "SELECT * FROM USUARIOS";
            SQLiteCommand readCommand = new SQLiteCommand(selectQuery, connection);
            {
                using (SQLiteDataReader reader = readCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["ID"]}, Nombre: {reader["NOMBRE"]}, Edad: {reader["EDAD"]}, Email: {reader["EMAIL"]}");
                    }
                }
            }
        }

        //BUSCAR REGISTRO POR ID
        void SEARCHbyID(SQLiteConnection connection)
        {
            Console.Write("Ingresa el ID a buscar: ");
            int id = int.Parse(Console.ReadLine() ?? "0");
            string searchQuery = "SELECT * FROM USUARIOS WHERE ID = @id";
            SQLiteCommand searchCommand = new SQLiteCommand(searchQuery, connection);
            {
                searchCommand.Parameters.AddWithValue("@id", id);
                using (SQLiteDataReader reader = searchCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["ID"]}, Nombre: {reader["NOMBRE"]}, Edad: {reader["EDAD"]}, Email: {reader["EMAIL"]}");
                    }
                    else
                    {
                        Console.WriteLine("Usuario no encontrado.");
                    }
                }
            }
        }

        //ACTUALIZAR REGISTRO
        void UPDATE(SQLiteConnection connection)
        {
            Console.Write("Ingresa el ID del usuario a actualizar: ");
            if (!int.TryParse(Console.ReadLine() ?? "", out int userId)) { Console.WriteLine("ID inválido."); return; }

            Console.Write("Nuevo nombre: ");
            string nombre = Console.ReadLine() ?? "";
            Console.Write("Nueva edad: ");
            int edad = int.TryParse(Console.ReadLine() ?? "", out int e) ? e : 0;
            Console.Write("Nuevo email: ");
            string email = Console.ReadLine() ?? "";

            string updateQuery = "UPDATE USUARIOS SET NOMBRE = @nombre, EDAD = @edad, EMAIL = @email WHERE ID = @id";
            using (var updateCommand = new SQLiteCommand(updateQuery, connection))
            {
                updateCommand.Parameters.AddWithValue("@nombre", nombre);
                updateCommand.Parameters.AddWithValue("@edad", edad);
                updateCommand.Parameters.AddWithValue("@email", email);
                updateCommand.Parameters.AddWithValue("@id", userId);
                int rows = updateCommand.ExecuteNonQuery();
                Console.WriteLine(rows > 0 ? "Usuario actualizado." : "Usuario no encontrado.");
            }
        }

        //ELIMINAR REGISTRO
        void DELETE(SQLiteConnection connection)
        {
            Console.Write("Ingresa el ID a eliminar: ");
            int id = int.Parse(Console.ReadLine() ?? "");

            string deleteQuery = "DELETE FROM USUARIOS WHERE ID = @id";
            using (SQLiteCommand deleteCommand = new SQLiteCommand(deleteQuery, connection))
            {
                deleteCommand.Parameters.AddWithValue("@id", id);
                int rowsAffected = deleteCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Usuario eliminado correctamente.");
                }
                else
                {
                    Console.WriteLine("Usuario no encontrado.");
                }
            }
        }
    }
}

