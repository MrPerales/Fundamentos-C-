using System.Data.SqlClient;
using CervezaClass;


namespace Fundamentos.conectionDB
{
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

        public void Add(Cerveza cerveza)
        {
            // se escriben con "@..." por proteccion 
            string query = "INSERT into cerveza (id ,nombre ,marca,alcohol,cantidad) " +
            "VALUES (@id,@nombre,@marca,@alcohol,@cantidad);";

            using (var connection = new SqlConnection(connectionString))
            {

                var command = new SqlCommand(query, connection);
                var randomId = new Random().Next(0, 100); //solo por fines practicos el id :S
                                                          // mandamos los valores 
                command.Parameters.AddWithValue("@id", randomId);
                command.Parameters.AddWithValue("@nombre", cerveza.Name);
                command.Parameters.AddWithValue("@marca", cerveza.Marca);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@cantidad", cerveza.Cantidad);



                connection.Open();

                command.ExecuteNonQuery();//ejecutamos el query 

                connection.Close();

            }
        }
        public void Edit(Cerveza cerveza, int id)
        {
            string query = "update cerveza set" +
                " nombre=@nombre,marca=@marca," +
                "alcohol=@alcohol,cantidad=@cantidad " +
                "where id=@id";

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nombre", cerveza.Name);
                command.Parameters.AddWithValue("@marca", cerveza.Marca);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@cantidad", cerveza.Cantidad);

                connection.Open();

                command.ExecuteNonQuery();//ejecutamos el query 

                connection.Close();
            }
        }
        public void Delete(int id)
        {
            string query = "delete from cerveza where id=@id";

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

    }
}