using System.Data.SqlClient;
using CervezaClass;

class Program
{
    static void Main()
    {
        CervezaBD cervezaBD = new CervezaBD();
        var cervezas = cervezaBD.Get();
        foreach (var item in cervezas)
        {
            Console.WriteLine(item.Name);

        }
        Console.WriteLine("-------------------------------");

        Console.WriteLine(cervezas);
    }
}

// coneccion para la DataBase 
class CervezaBD
{
    private string connectionString = "Data Source=localhost; " +
        "Initial Catalog=dataBaseCSharp;" +
        "User ID=sa; Password=root123!abc";

    // metodo para traer la lista
    public List<Cerveza> Get()
    {
        //creamos el obj donde vamos a guardar los datos de la BD
        List<Cerveza> cervezas = new List<Cerveza>();
        // consulta sql
        string query = "select nombre, marca, alcohol, cantidad " +
             "from cerveza";

        // using sirve para especificar, todo lo que crees en () se va a morir cuando acaben las {}
        // con (sqlconection...) creamos la coneccion a la DB usando el conectionStrig
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // mandamos el query
            // SqlCommand recive 2 argumentos uno el query y el otro el objeto de la conection
            SqlCommand command = new SqlCommand(query, connection);

            // abrimos la conecciton 
            connection.Open();
            // codigo para leer los resultados 
            // con reader leemos los resultados uno a uno 
            SqlDataReader reader = command.ExecuteReader(); //en este punto ya se ejecuta la consulta

            // while va a ser la lectura de los resultados 
            while (reader.Read())
            {
                // para saber N en reader.GetInt32(N) solo tenemos que ver en el query 
                //         [0]     [1]    [2]       [3]
                // select nombre, marca, alcohol, cantidad
                int Cantidad = reader.GetInt32(3);
                string Nombre = reader.GetString(0);
                var cerveza = new Cerveza(Cantidad, Nombre);
                // asignamos los otros datos 
                cerveza.Marca = reader.GetString(1);
                cerveza.Alcohol = reader.GetInt32(2);

                // agregamos a la lista inicial 
                cervezas.Add(cerveza);
            }

            // cerramos las conecciones 
            reader.Close();
            connection.Close();

        }


        return cervezas;

    }
}