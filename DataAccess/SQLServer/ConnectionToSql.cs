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
            // connectionString = "Data Source = 201.218.26.35,1433; Initial Catalog = TBC; User Id = TBC_Server; Password = tbc2021";
            // connectionString = "Data Source = 201.218.26.28,1900; Initial Catalog = TBC; User Id = TBC_Server; Password = tbc2021";
            connectionString = "Data Source = 25.6.203.112,1900; Initial Catalog = TBC; User Id = TBC_SYSTEM; Password = Admin$system2024";
        }
        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
