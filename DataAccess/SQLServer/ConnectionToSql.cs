using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DataAccess
{
    public abstract class ConnectionToSql               // Esta clase no puede ser instanciada
    {
        private readonly string connectionString;

        public ConnectionToSql()                        // Crea el constructor
        {
            // Conexion local
            // connectionString = "Server = localhost\\SQLEXPRESS; DataBase = TBC; integrated security = true";    // Se conecta con sql server, como es locall host se puede poner . o (local)
            // Conexion Remota                                                                                                    //Coneccion Remota
            connectionString = "Data Source = 201.183.99.88,1433; Initial Catalog = TBC; User Id = TBC_Server; Password = tbc2020";
        }
        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
