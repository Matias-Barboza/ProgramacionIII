using System.Data.SqlClient;

internal class Program
{
    private static void Main(string[] args)
    {
        //using hace manejo de los recursos pero no es imprescindible para la conexion
        //SqlConnection -> proveedor de datos
        using (SqlConnection cn = new SqlConnection()) 
        {
            //ConnectionString es la propiedad mas importante de la clase SqlConnection
            cn.ConnectionString = GetConnectionString();
            cn.Open();
            Console.WriteLine($"Estado: {cn.State}");
            Console.ReadLine();
            Console.Clear();

            String sqlString = "Select count(*) From Clientes";
            String sqlString1 = "Select Id, Nombre, Apellido From Clientes";

            SqlCommand myCommand = new SqlCommand(sqlString,cn);
            SqlCommand myCommand1 = new SqlCommand(sqlString1,cn);

            /* FORMA ALTERNATIVA
             * SqlCommand myCommand = new SqlCommand();
             * myCommand.Connection(cn);
             * myCommand.CommandText(sqlString);
             */

            //El metodo ExecuteScalar devuelve un solo dato
            Console.WriteLine($"La cantidad es: {myCommand.ExecuteScalar()}");

            SqlDataReader myDataReader = myCommand1.ExecuteReader();

            if (myDataReader.HasRows) 
            {
                while(myDataReader.Read()) 
                {
                    //Dentro de los metodos, van las columnas de donde voy a extrar
                    Console.WriteLine($"[{myDataReader.GetInt32(0)}] {myDataReader.GetString(1)} {myDataReader.GetString(2)}");

                    /* FORMAS ALTERNATIVAS
                     * 
                     * Console.WriteLine($"[{myDataReader["Id"].ToString()}] {myDataReader["Nombre"].ToString()} {myDataReader["Apellido"].ToString()}");
                     * 
                     * Console.WriteLine($"[{myDataReader[0].ToString()}] {myDataReader[1].ToString()} {myDataReader[2].ToString()}");
                     */

                }
            }
        }
    }

    private static string GetConnectionString()
    {
        return @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename = C:\Users\Matias Barboza\source\repos\ProgramacionIII\clase10_IntroduccionBD\Database1.mdf;Integrated Security=True";
    }
}