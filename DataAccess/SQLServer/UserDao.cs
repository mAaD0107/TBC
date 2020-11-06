using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net.Configuration;
using System.Windows.Forms;
using System.Data.SqlTypes;
using Common.Cache;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DataAccess
{
    public class UserDao : ConnectionToSql                                   // Esta clase hereda atributos de ConnectionToSql
    {
        public bool Login(string user, string pass)                 // Crea un metodo donde se leen los datos de la BD
        {
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select *from Users where LoginName=@user and Password=@pass COLLATE Latin1_General_CS_AS";
                        command.Parameters.AddWithValue("@user", user);
                        command.Parameters.AddWithValue("@pass", pass);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                       
                        if (reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                UserCache.idUser = reader.GetInt32(0);
                                UserCache.FirstName = reader.GetString(3);
                                UserCache.LastName = reader.GetString(4);
                                UserCache.Position = reader.GetString(5);
                                UserCache.Email = reader.GetString(6);
                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (SqlException)
                {
                    
                    DialogResult result = MessageBox.Show(
                        "Error al conectarse a la base de datos:\n\n" +
                        "Servidor no encontrado o inaccesible\n" +
                        "Por favor, verifique su conexión a Internet o\n" +
                        "Verifique el estado del Servidor",
                        "ALERTA", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning
                        );
                    //Application.Exit();
                    return false;
                }
                

            }
        }


        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select * from Users where LoginName=@user or Email=@email";
                        command.Parameters.AddWithValue("@user", userRequesting);
                        command.Parameters.AddWithValue("@email", userRequesting);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read() == true)
                        {
                            string userName = reader.GetString(3);
                            string userMail = reader.GetString(6);
                            string userPassword = reader.GetString(2);

                            var mailService = new MailService.SystemSuportMail();
                            if (mailService.sendMail(
                                subject: "Sistema de recuperación de contraseña",
                                body: "Hola " + userName + ", tu contraseña es: " + userPassword +
                                "\nPor favor, cambia tu contraseña al reingresar al sistema",
                                recipientMail: new List<string> { userMail }
                                ))
                            {
                                return "Hola " + userName +
                                        "\nTu solicitud de recuperación de contraseña ha sido procesada exitosamente." +
                                        "\nPor favor, reivisa tu correo " + userMail + " y cambia tu contraseña al re ingresar al sistema.";
                            }
                            else
                                return "Lo sentimos, no es posible acceder al servidor SMTP";

                        }
                        else
                            return "Lo sentimos, no hay un usuario registrado con ese email o nombre de usuario";

                    }
                }
                catch (Exception)
                {
                    return "Lo sentimos, no es posible acceder al servidor SMTP" +
                           "\nPor favor, revise su conexión a Internet";

                }
                

            }
        }

        public DataTable readClients()
        {
            DataTable table = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "readClients";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    table.Load(reader);
                    return table;

                }
            }
        }






        public DataTable readProveedores()
        {
            DataTable table = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "readProveedores";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    table.Load(reader);
                    return table;

                }
            }
        }


        public DataTable readTramitesImport()
        {
            DataTable table = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "readTramitesImport";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    table.Load(reader);
                    return table;

                }
            }
        }

        public DataTable readTramitesComision()
        {
            DataTable table = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "readTramitesComision";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    table.Load(reader);
                    return table;

                }
            }
        }

        public DataTable readTramitesComisionFactura(string[] values)
        {
            DataTable table = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "readTramitesComisionFactura";
                    command.CommandType = CommandType.StoredProcedure;
                    
                    command.Parameters.AddWithValue("@FechaInicio", values[0]);
                    command.Parameters.AddWithValue("@FechaLimite", values[1]);
                    command.Parameters.AddWithValue("@CiudadNacionali", values[2]);
                    SqlDataReader reader = command.ExecuteReader();

                    table.Load(reader);
                    return table;

                }
            }
        }

        public DataTable readTramitesComisionNotaVenta(string[] values)
        {
            DataTable table = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "readTramitesComisionNotaVenta";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FechaInicio", values[0]);
                    command.Parameters.AddWithValue("@FechaLimite", values[1]);
                    command.Parameters.AddWithValue("@CiudadNacionali", values[2]);
                    SqlDataReader reader = command.ExecuteReader();

                    table.Load(reader);
                    return table;

                }
            }
        }


        public int readIDTramitesImport()
        {
            DataTable ID = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT IDENT_CURRENT('Tramites_Importacion') as IDTramite";
                    command.CommandType = CommandType.Text;
                    
                    SqlDataReader reader = command.ExecuteReader();

                    ID.Load(reader);
                    int id = Int32.Parse(ID.Rows[0]["IDTramite"].ToString());

                    return id;

                }
            }

        }
        public List<string> readTipoFactura(int nTramite)
        {
            DataTable table = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from TipoFactura where idTramite = @ntramite";
                    command.Parameters.AddWithValue("@ntramite", nTramite);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    table.Load(reader);

                    DataTable dtAux = table.Clone();

                    List<string> datosC = new List<string>();
                    List<string> listaFacturas = new List<string>();


                    foreach (DataColumn column in table.Columns)datosC.Add(column.ColumnName);
                    

                    string[] array = datosC.ToArray();

                    if (table.Rows.Count != 0)
                    {
                        for (int i = 2; i < table.Columns.Count; i++)
                        {
                            if (table.Rows[0][i].ToString() == "False")
                            {
                                listaFacturas.Add(array[i]);
                            }
                        }
                    }
                    return listaFacturas;
                }
            }
        }

        public List<string> readFacturasIngresados(int nTramite)
        {
            DataTable table = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from TipoFactura where idTramite = @numeroTramite";
                    command.Parameters.AddWithValue("@numeroTramite", nTramite);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    table.Load(reader);

                    DataTable dtAux = table.Clone();

                    List<string> datosC = new List<string>();
                    List<string> listaFacturas = new List<string>();


                    foreach (DataColumn column in table.Columns) datosC.Add(column.ColumnName);


                    string[] array = datosC.ToArray();

                    if (table.Rows.Count != 0)
                    {
                        for (int i = 2; i < table.Columns.Count; i++)
                        {
                            if (table.Rows[0][i].ToString() == "True")
                            {
                                listaFacturas.Add(array[i]);
                            }
                        }
                    }
                    return listaFacturas;
                }
            }
        }


        public DataTable readPagos(int nTramite)
        {
            DataTable table = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "searchPagos";
                    command.Parameters.AddWithValue("@idTramite", nTramite);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    table.Load(reader);
                    return table;
                }
            }
        }


        public DataTable readAbonos(string nFactura)
        {
            DataTable table = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "searchAbonos";
                    command.Parameters.AddWithValue("@nFactura", nFactura);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    table.Load(reader);
                    return table;
                }
            }
        }


        public DataTable readAbonoFactura(string nFactura)
        {
            DataTable table = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "searchAbonoFactura";
                    command.Parameters.AddWithValue("@nFactura", nFactura);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    table.Load(reader);
                    return table;
                }
            }
        }


        public DataTable readIVA()
        {
            DataTable table = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from IVA";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    table.Load(reader);
                    return table;

                }
            }
        }


        public bool deleteIVA(double iva)
        {
            int retorno = 0;

            using (var connection = GetSqlConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "delete from IVA where Porcentaje = @IVA";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@IVA", iva);

                    retorno = command.ExecuteNonQuery();

                    if (retorno != 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }




        public DataTable searchClients(string data)
        {
            DataTable table = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "searchClient";
                    command.Parameters.AddWithValue("@RUC", data);
                    command.Parameters.AddWithValue("@Empresa", data);
                    command.Parameters.AddWithValue("@Contacto", data);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    table.Load(reader);
                    return table;


                }
            }
        }


        public DataTable searchProveedores(string data)
        {
            DataTable table = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "searchProveedores";
                    command.Parameters.AddWithValue("@RUC", data);
                    command.Parameters.AddWithValue("@Empresa", data);
                    command.Parameters.AddWithValue("@Contacto", data);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    table.Load(reader);
                    return table;
                }
            }
        }


        public DataTable searchTramiteImport(string data)
        {
            DataTable table = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "searchTramiteImport";
                    command.Parameters.AddWithValue("@NombreEmpresa", data);
                    command.Parameters.AddWithValue("@SecuencialCliente", data);
                    command.Parameters.AddWithValue("@DAI", data);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    table.Load(reader);
                    return table;
                }
            }
        }

        public double saldoTramite(int numeroTramite)
        {
            DataTable table = new DataTable();
            double totalSaldo = 0;

            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "searchSaldoTramite";
                    command.Parameters.AddWithValue("@numeroTramite", numeroTramite);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    table.Load(reader);

                    if (table.Rows.Count > 0)
                    {
                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            totalSaldo += double.Parse(table.Rows[i]["Saldo"].ToString());
                        }

                        return totalSaldo;
                    }
                    else
                    {
                        return 0;
                    }

                    
                }
            }
        }


        public void searchRetenciones(string RUCEmpresa)
        {
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select Retencion_Renta_Factura_Agente, " +
                                              "Retencion_IVA_Factura_Agente, " +
                                              "Retencion_Renta_Factura_TBC, " +
                                              "Retencion_IVA_Factura_TBC, " +
                                              "Dias_Credito_Factura_Agente, " +
                                              "Dias_Credito_Factura_TBC, " +
                                              "Dias_Credito_Gastos, " +
                                              "Dias_Credito_Transporte " +
                                              "from Cliente where RUC = @RUC";
                        
                        command.Parameters.AddWithValue("@RUC", RUCEmpresa);

                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read() == true)
                        {
                            TramiteCache.porcentajeRetRentaAgente = reader.GetDouble(0);
                            TramiteCache.porcentajeRetIVAAgente = reader.GetDouble(1);
                            TramiteCache.porcentajeRetRentaTBC = reader.GetDouble(2);
                            TramiteCache.porcentajeRetIVATBC = reader.GetDouble(3);
                            TramiteCache.diasCreditoFacturaAgente = reader.GetInt32(4);
                            TramiteCache.diasCreditoFacturaTBC = reader.GetInt32(5);
                            TramiteCache.diasCreditoGastos = reader.GetInt32(6);
                            TramiteCache.diasCreditoTransporte = reader.GetInt32(7);
                        }

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: \n" + e,
                                    "ERROR",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                }


            }
        }



        public bool insertDataClient(string [] values)
        {
            int retorno = 0;
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                       

                        command.Connection = connection;
                        command.CommandText = "modifyClient";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StatementType", values[0]);

                        //Datos Generales

                        command.Parameters.AddWithValue("@RUC", values[1]);
                        command.Parameters.AddWithValue("@Nombre_Empresa", values[2]);

                        //Personas de Contacto

                        command.Parameters.AddWithValue("@Persona_Contacto_1", values[3]);
                        command.Parameters.AddWithValue("@Telefono_Persona_De_Contacto_1", values[4]);
                        command.Parameters.AddWithValue("@Celular_Persona_De_Contacto_1", values[5]);
                        command.Parameters.AddWithValue("@Correo_Personas_Contacto_1", values[6]);
                        command.Parameters.AddWithValue("@Titulo_Persona_Contacto_1", values[7]);
                        command.Parameters.AddWithValue("@Cargo_Persona_Contacto_1", values[8]);


                        command.Parameters.AddWithValue("@Persona_Contacto_2", values[9]);
                        command.Parameters.AddWithValue("@Telefono_Persona_De_Contacto_2", values[10]);
                        command.Parameters.AddWithValue("@Celular_Persona_De_Contacto_2", values[11]);
                        command.Parameters.AddWithValue("@Correo_Personas_Contacto_2", values[12]);
                        command.Parameters.AddWithValue("@Titulo_Persona_Contacto_2", values[13]);
                        command.Parameters.AddWithValue("@Cargo_Persona_Contacto_2", values[14]);


                        command.Parameters.AddWithValue("@Persona_Contacto_3", values[15]);
                        command.Parameters.AddWithValue("@Telefono_Persona_De_Contacto_3", values[16]);
                        command.Parameters.AddWithValue("@Celular_Persona_De_Contacto_3", values[17]);
                        command.Parameters.AddWithValue("@Correo_Personas_Contacto_3", values[18]);
                        command.Parameters.AddWithValue("@Titulo_Persona_Contacto_3", values[19]);
                        command.Parameters.AddWithValue("@Cargo_Persona_Contacto_3", values[20]);


                        command.Parameters.AddWithValue("@Persona_Contacto_4", values[21]);
                        command.Parameters.AddWithValue("@Telefono_Persona_De_Contacto_4", values[22]);
                        command.Parameters.AddWithValue("@Celular_Persona_De_Contacto_4", values[23]);
                        command.Parameters.AddWithValue("@Correo_Personas_Contacto_4", values[24]);
                        command.Parameters.AddWithValue("@Titulo_Persona_Contacto_4", values[25]);
                        command.Parameters.AddWithValue("@Cargo_Persona_Contacto_4", values[26]);

                        command.Parameters.AddWithValue("@Persona_Contacto_5", values[27]);
                        command.Parameters.AddWithValue("@Telefono_Persona_De_Contacto_5", values[28]);
                        command.Parameters.AddWithValue("@Celular_Persona_De_Contacto_5", values[29]);
                        command.Parameters.AddWithValue("@Correo_Personas_Contacto_5", values[30]);
                        command.Parameters.AddWithValue("@Titulo_Persona_Contacto_5", values[31]);
                        command.Parameters.AddWithValue("@Cargo_Persona_Contacto_5", values[32]);


                        //Personas de Cobranzas

                        command.Parameters.AddWithValue("@Persona_Cobranzas_1", values[33]);
                        command.Parameters.AddWithValue("@Correo_Persona_Cobranzas_1", values[34]);
                        command.Parameters.AddWithValue("@Telefono_Persona_Cobranzas_1", values[35]);
                        command.Parameters.AddWithValue("@Celular_Persona_Cobranzas_1", values[36]);

                        command.Parameters.AddWithValue("@Persona_Cobranzas_2", values[37]);
                        command.Parameters.AddWithValue("@Correo_Persona_Cobranzas_2", values[38]);
                        command.Parameters.AddWithValue("@Telefono_Persona_Cobranzas_2", values[39]);
                        command.Parameters.AddWithValue("@Celular_Persona_Cobranzas_2", values[40]);

                        command.Parameters.AddWithValue("@Persona_Cobranzas_3", values[41]);
                        command.Parameters.AddWithValue("@Correo_Persona_Cobranzas_3", values[42]);
                        command.Parameters.AddWithValue("@Telefono_Persona_Cobranzas_3", values[43]);
                        command.Parameters.AddWithValue("@Celular_Persona_Cobranzas_3", values[44]);


                        //Factura Agente

                        command.Parameters.AddWithValue("@Subtotal_Factura_Agente_Maritima", double.Parse(values[45]));
                        command.Parameters.AddWithValue("@Subtotal_Factura_Agente_Aerea", double.Parse(values[46]));
                        command.Parameters.AddWithValue("@Retencion_Renta_Factura_Agente", double.Parse(values[47]));
                        command.Parameters.AddWithValue("@Retencion_IVA_Factura_Agente", double.Parse(values[48]));
                        command.Parameters.AddWithValue("@Dias_Credito_Factura_Agente", int.Parse(values[49]));
                        command.Parameters.AddWithValue("@Comision_Factura_Agente_Maritimo", double.Parse(values[50]));
                        command.Parameters.AddWithValue("@Comision_Factura_Agente_Aerea", double.Parse(values[51]));

                        //Factura TBC

                        command.Parameters.AddWithValue("@Subtotal_Factura_TBC", double.Parse(values[52]));
                        command.Parameters.AddWithValue("@Retencion_Renta_Factura_TBC", double.Parse(values[53]));
                        command.Parameters.AddWithValue("@Retencion_IVA_Factura_TBC", double.Parse(values[54]));
                        command.Parameters.AddWithValue("@Dias_Credito_Factura_TBC", int.Parse(values[55]));
                        command.Parameters.AddWithValue("@Comisiones_Bancarias", values[56]);
                        command.Parameters.AddWithValue("@Personas_Comisiones_Extra", values[57]);
                        command.Parameters.AddWithValue("@Valor_Comisiones_Extra", double.Parse(values[58]));
                        command.Parameters.AddWithValue("@Dias_Credito_Transporte", int.Parse(values[59]));
                        command.Parameters.AddWithValue("@Dias_Credito_Gastos", int.Parse(values[60]));

                        //Datos Bancarios

                        command.Parameters.AddWithValue("@Beneficiario_1", values[61]);
                        command.Parameters.AddWithValue("@Nombre_Banco_1", values[62]);
                        command.Parameters.AddWithValue("@Tipo_Cuenta_1", values[63]);
                        command.Parameters.AddWithValue("@Numero_Cuenta_1", values[64]);

                        command.Parameters.AddWithValue("@Beneficiario_2", values[65]);
                        command.Parameters.AddWithValue("@Nombre_Banco_2", values[66]);
                        command.Parameters.AddWithValue("@Tipo_Cuenta_2", values[67]);
                        command.Parameters.AddWithValue("@Numero_Cuenta_2", values[68]);

                        //Direccion

                        command.Parameters.AddWithValue("@Calle_Principal", values[69]);
                        command.Parameters.AddWithValue("@Numeracion", values[70]);
                        command.Parameters.AddWithValue("@Calle_Secundaria", values[71]);
                        command.Parameters.AddWithValue("@Nombre_Edificio", values[72]);
                        command.Parameters.AddWithValue("@Referencia", values[73]);


                        retorno = command.ExecuteNonQuery();

                        if (retorno != 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error \n"+e);
                    return false; 

                }
            }
        }



        public bool insertDataProveedor(string[] values)
        {
            int retorno = 0;
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {


                        command.Connection = connection;
                        command.CommandText = "modifyProveedor";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StatementType", values[0]);

                        //Datos Generales


                        command.Parameters.AddWithValue("@RUC", values[1]);
                        command.Parameters.AddWithValue("@EMPRESA", values[2]);
                        command.Parameters.AddWithValue("@TIPO_DE_CONTRIBUYENTE", values[3]);

                        //Datos Bancarios
                        command.Parameters.AddWithValue("@BENEFICIARIO_1", values[4]);
                        command.Parameters.AddWithValue("@NOMBRE_BANCO_1", values[5]);
                        command.Parameters.AddWithValue("@TIPO_DE_CUENTA_1", values[6]);
                        command.Parameters.AddWithValue("@NUMERO_CUENTA_1", values[7]);

                        command.Parameters.AddWithValue("@BENEFICIARIO_2", values[8]);
                        command.Parameters.AddWithValue("@NOMBRE_BANCO_2", values[9]);
                        command.Parameters.AddWithValue("@TIPO_DE_CUENTA_2", values[10]);
                        command.Parameters.AddWithValue("@NÚMERO_CUENTA_2", values[11]);

                        //Personas Contacto
                        command.Parameters.AddWithValue("@PERSONA_DE_CONTACTO_1", values[12]);
                        command.Parameters.AddWithValue("@CORREO_PERSONA_DE_CONTACTO_1", values[13]);
                        command.Parameters.AddWithValue("@TELÉFONO_PERSONA_DE_CONTACTO_1", values[14]);
                        command.Parameters.AddWithValue("@CELULAR_PERSONA_DE_CONTACTO_1", values[15]);
                        command.Parameters.AddWithValue("@DEPARTAMENTO_1", values[16]);
                        command.Parameters.AddWithValue("@CARGO_1", values[17]);

                        command.Parameters.AddWithValue("@PERSONA_DE_CONTACTO_2", values[18]);
                        command.Parameters.AddWithValue("@CORREO_PERSONA_DE_CONTACTO_2", values[19]);
                        command.Parameters.AddWithValue("@TELÉFONO_PERSONA_DE_CONTACTO_2", values[20]);
                        command.Parameters.AddWithValue("@CELULAR_PERSONA_DE_CONTACTO_2", values[21]);
                        command.Parameters.AddWithValue("@DEPARTAMENTO_2", values[22]);
                        command.Parameters.AddWithValue("@CARGO_2", values[23]);

                        command.Parameters.AddWithValue("@PERSONA_DE_CONTACTO_3", values[24]);
                        command.Parameters.AddWithValue("@CORREO_PERSONA_DE_CONTACTO_3", values[25]);
                        command.Parameters.AddWithValue("@TELÉFONO_PERSONA_DE_CONTACTO_3", values[26]);
                        command.Parameters.AddWithValue("@CELULAR_PERSONA_DE_CONTACTO_3", values[27]);
                        command.Parameters.AddWithValue("@DEPARTAMENTO_3", values[28]);
                        command.Parameters.AddWithValue("@CARGO_3", values[29]);


                        command.Parameters.AddWithValue("@PERSONA_DE_CONTACTO_4", values[30]);
                        command.Parameters.AddWithValue("@CORREO_PERSONA_DE_CONTACTO_4", values[31]);
                        command.Parameters.AddWithValue("@TELÉFONO_PERSONA_DE_CONTACTO_4", values[32]);
                        command.Parameters.AddWithValue("@CELULAR_PERSONA_DE_CONTACTO_4", values[33]);
                        command.Parameters.AddWithValue("@DEPARTAMENTO_4", values[34]);
                        command.Parameters.AddWithValue("@CARGO_4", values[35]);


                        command.Parameters.AddWithValue("@PERSONA_DE_CONTACTO_5", values[36]);
                        command.Parameters.AddWithValue("@CORREO_PERSONA_DE_CONTACTO_5", values[37]);
                        command.Parameters.AddWithValue("@TELÉFONO_PERSONA_DE_CONTACTO_5", values[38]);
                        command.Parameters.AddWithValue("@CELULAR_PERSONA_DE_CONTACTO_5", values[39]);
                        command.Parameters.AddWithValue("@DEPARTAMENTO_5", values[40]);
                        command.Parameters.AddWithValue("@CARGO_5", values[41]);


                        command.Parameters.AddWithValue("@PERSONA_DE_CONTACTO_6", values[42]);
                        command.Parameters.AddWithValue("@CORREO_PERSONA_DE_CONTACTO_6", values[43]);
                        command.Parameters.AddWithValue("@TELÉFONO_PERSONA_DE_CONTACTO_6", values[44]);
                        command.Parameters.AddWithValue("@CELULAR_PERSONA_DE_CONTACTO_6", values[45]);
                        command.Parameters.AddWithValue("@DEPARTAMENTO_6", values[46]);
                        command.Parameters.AddWithValue("@CARGO_6", values[47]);


                        command.Parameters.AddWithValue("@PERSONA_DE_CONTACTO_7", values[48]);
                        command.Parameters.AddWithValue("@CORREO_PERSONA_DE_CONTACTO_7", values[49]);
                        command.Parameters.AddWithValue("@TELÉFONO_PERSONA_DE_CONTACTO_7", values[50]);
                        command.Parameters.AddWithValue("@CELULAR_PERSONA_DE_CONTACTO_7", values[51]);
                        command.Parameters.AddWithValue("@DEPARTAMENTO_7", values[52]);
                        command.Parameters.AddWithValue("@CARGO_7", values[53]);


                        command.Parameters.AddWithValue("@PERSONA_DE_CONTACTO_8", values[54]);
                        command.Parameters.AddWithValue("@CORREO_PERSONA_DE_CONTACTO_8", values[55]);
                        command.Parameters.AddWithValue("@TELÉFONO_PERSONA_DE_CONTACTO_8", values[56]);
                        command.Parameters.AddWithValue("@CELULAR_PERSONA_DE_CONTACTO_8", values[57]);
                        command.Parameters.AddWithValue("@DEPARTAMENTO_8", values[58]);
                        command.Parameters.AddWithValue("@CARGO_8", values[59]);


                        command.Parameters.AddWithValue("@PERSONA_DE_CONTACTO_9", values[60]);
                        command.Parameters.AddWithValue("@CORREO_PERSONA_DE_CONTACTO_9", values[61]);
                        command.Parameters.AddWithValue("@TELÉFONO_PERSONA_DE_CONTACTO_9", values[62]);
                        command.Parameters.AddWithValue("@CELULAR_PERSONA_DE_CONTACTO_9", values[63]);
                        command.Parameters.AddWithValue("@DEPARTAMENTO_9", values[64]);
                        command.Parameters.AddWithValue("@CARGO_9", values[65]);


                        command.Parameters.AddWithValue("@PERSONA_DE_CONTACTO_10", values[66]);
                        command.Parameters.AddWithValue("@CORREO_PERSONA_DE_CONTACTO_10", values[67]);
                        command.Parameters.AddWithValue("@TELÉFONO_PERSONA_DE_CONTACTO_10", values[68]);
                        command.Parameters.AddWithValue("@CELULAR_PERSONA_DE_CONTACTO_10", values[69]);
                        command.Parameters.AddWithValue("@DEPARTAMENTO_10", values[70]);
                        command.Parameters.AddWithValue("@CARGO_10", values[71]);

                        //Dirección
                        command.Parameters.AddWithValue("@CALLE_PRINCIPAL", values[72]);
                        command.Parameters.AddWithValue("@NUMERACIÓN", values[73]);
                        command.Parameters.AddWithValue("@CALLE_SECUNDARIA", values[74]);
                        command.Parameters.AddWithValue("@NOMBRE_EDIFICIO", values[75]);
                        command.Parameters.AddWithValue("@REFERENCIA", values[76]);


                        retorno = command.ExecuteNonQuery();

                        if (retorno != 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error \n" + e);
                    return false;

                }
            }
        }





        public bool insertDataTramite(string[] values)
        {
            int retorno = 0;
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {


                        command.Connection = connection;
                        command.CommandText = "modifyTramite";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StatementType", values[0]);

                        command.Parameters.AddWithValue("@Numero_Tramite", values[1]);
                        command.Parameters.AddWithValue("@Nombre_Empresa", values[2]);
                        command.Parameters.AddWithValue("@Tipo_Tramite", values[3]);
                        command.Parameters.AddWithValue("@Ciudad_Nacionalizacion", values[4]);
                        command.Parameters.AddWithValue("@Secuencial_Cliente", values[5]);
                        command.Parameters.AddWithValue("@Proveedor", values[6]);
                        command.Parameters.AddWithValue("@Numero_Factura_Proveedor", values[7]);
                        command.Parameters.AddWithValue("@Fecha_Inicio", values[8]);
                        command.Parameters.AddWithValue("@Fecha_Limite", values[9]);
                        command.Parameters.AddWithValue("@Fecha_Finalizacion", values[10]);
                        command.Parameters.AddWithValue("@ComentariosCrear", values[11]);
                        command.Parameters.AddWithValue("@Numero_DAI", values[12]);
                        command.Parameters.AddWithValue("@Numero_Liquidacion", values[13]);
                        command.Parameters.AddWithValue("@Numero_Orden_LDM", values[14]);
                        command.Parameters.AddWithValue("@Numero_Contenedor", values[15]);
                        command.Parameters.AddWithValue("@Naviera", values[16]);
                        command.Parameters.AddWithValue("@Forwarder1", values[17]);
                        command.Parameters.AddWithValue("@Numero_Guia", values[18]);
                        command.Parameters.AddWithValue("@Aerolinea", values[19]);
                        command.Parameters.AddWithValue("@Forwarder2", values[20]);
                        command.Parameters.AddWithValue("@Numero_PasePuerta", values[21]);
                        command.Parameters.AddWithValue("@Transportador", values[22]);
                        command.Parameters.AddWithValue("@Forwarder3", values[23]);
                        command.Parameters.AddWithValue("@ComentariosAgregar", values[24]);

                        retorno = command.ExecuteNonQuery();

                        if (retorno != 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error \n" + e);
                    return false;

                }
            }
        }



        public bool insertDataFactura(string[] values)
        {
            int retorno = 0;
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {


                        command.Connection = connection;
                        command.CommandText = "modifyFactura";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StatementType", values[0]);

                        command.Parameters.AddWithValue("@Numero_Factura", values[1]);
                        command.Parameters.AddWithValue("@Empresa_Factura", values[2]);
                        command.Parameters.AddWithValue("@Numero_Tramite1", int.Parse(values[3]));
                        command.Parameters.AddWithValue("@Tipo_Factura", values[4]);
                        command.Parameters.AddWithValue("@Fecha_Factura", values[5]);
                        command.Parameters.AddWithValue("@Concepto",values[6]);
                        command.Parameters.AddWithValue("@SubTotal_Factura", double.Parse(values[7]));
                        command.Parameters.AddWithValue("@PorcentajeIVA", double.Parse(values[8]));
                        command.Parameters.AddWithValue("@IVAFactura", double.Parse(values[9]));
                        command.Parameters.AddWithValue("@TotalFactura", double.Parse(values[10]));
                        command.Parameters.AddWithValue("@Numero_Retencion", values[11]);
                        command.Parameters.AddWithValue("@Valor_Ret_Renta", double.Parse(values[12]));
                        command.Parameters.AddWithValue("@Porcentaje_Ret_Renta", double.Parse(values[13]));
                        command.Parameters.AddWithValue("@Valor_Ret_IVA", double.Parse(values[14]));
                        command.Parameters.AddWithValue("@Porcentaje_Ret_IVA", double.Parse(values[15]));
                        command.Parameters.AddWithValue("@Total_Retencion", double.Parse(values[16]));
                        command.Parameters.AddWithValue("@Numero_Nota_Credito", values[17]);
                        command.Parameters.AddWithValue("@Empresa_Nota_Credito", values[18]);
                        command.Parameters.AddWithValue("@Subtotal_Nota_Credito", double.Parse(values[19]));
                        command.Parameters.AddWithValue("@IVA_Nota_Credito", double.Parse(values[20]));
                        command.Parameters.AddWithValue("@Total_Nota_Credito", double.Parse(values[21]));
                        command.Parameters.AddWithValue("@ValorACobrarFactura", double.Parse(values[22]));
                        command.Parameters.AddWithValue("@Dias_Credito", int.Parse(values[23]));
                        command.Parameters.AddWithValue("@Fecha_Vencimiento", values[24]);
                        command.Parameters.AddWithValue("@Comentarios", values[25]);


                        retorno = command.ExecuteNonQuery();

                        if (retorno != 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error \n" + e);
                    return false;

                }
            }
        }


        public bool insertDataPago(string[] values)
        {
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {


                        command.Connection = connection;
                        command.CommandText = "modifyPago";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StatementType", values[0]);

                        command.Parameters.AddWithValue("@idPago", int.Parse(values[1]));
                        command.Parameters.AddWithValue("@PagoGeneral", double.Parse(values[2]));
                        command.Parameters.AddWithValue("@AbonoFactura", double.Parse(values[3]));
                        command.Parameters.AddWithValue("@FechaPago", values[4]);
                        command.Parameters.AddWithValue("@DetallePago", values[5]);
                        command.Parameters.AddWithValue("@idFactura", values[6]);


                        int retorno = command.ExecuteNonQuery();

                        if (retorno != 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error \n" + e);
                    return false;

                }
            }
        }


        public bool insertDataSaldo(string[] values)
        {
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {


                        command.Connection = connection;
                        command.CommandText = "modifySaldo";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StatementType", values[0]);

                        command.Parameters.AddWithValue("@idSaldo", int.Parse(values[1]));
                        command.Parameters.AddWithValue("@Saldo", double.Parse(values[2]));
                        command.Parameters.AddWithValue("@FechaPago", values[3]);
                        command.Parameters.AddWithValue("@idNTramite", int.Parse(values[4]));


                        int retorno = command.ExecuteNonQuery();

                        if (retorno != 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error \n" + e);
                    return false;

                }
            }
        }


        public bool searchRUC(string RUC)
        {
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select *from Cliente where RUC=@RUC";
                        command.Parameters.AddWithValue("@RUC", RUC);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (SqlException)
                {

                    DialogResult result = MessageBox.Show(
                        "Se perdio conexión con el Servidor",
                        "ALERTA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );

                    return false;
                }


            }
        }



        public bool searchRUCProveedor(string RUC)
        {
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select *from Proveedor where RUC=@RUC";
                        command.Parameters.AddWithValue("@RUC", RUC);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (SqlException)
                {

                    DialogResult result = MessageBox.Show(
                        "Se perdio conexión con el Servidor",
                        "ALERTA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );

                    return false;
                }


            }
        }



        public bool searchNFactura(string nfactura)
        {
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select *from Facturas where Numero_Factura=@nfactura";
                        command.Parameters.AddWithValue("@nfactura", nfactura);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (SqlException)
                {

                    DialogResult result = MessageBox.Show(
                        "Se perdio conexión con el Servidor",
                        "ALERTA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );

                    return false;
                }


            }
        }


        public bool searchIVA(string IVA)
        {
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select *from IVA where Porcentaje=@IVA";
                        command.Parameters.AddWithValue("@IVA", IVA);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (SqlException)
                {

                    DialogResult result = MessageBox.Show(
                        "Se perdio conexión con el Servidor",
                        "ALERTA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );

                    return false;
                }
            }
        }


        public DataTable searchComisionesCliente(string cliente)
        {
            DataTable table = new DataTable();


            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "searchComisionTBC";
                    command.Parameters.AddWithValue("@cliente", cliente);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    table.Load(reader);

                    return table;

                }
            }
        }

        public double searchValorFacturaLDM(int nTramite)
        {
            DataTable table = new DataTable();


            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "searchValorFacturaLDM";
                    command.Parameters.AddWithValue("@nTramite", nTramite);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    table.Load(reader);

                    if (table.Rows.Count > 0)
                    {
                        return double.Parse(table.Rows[0]["Subtotal_LDM"].ToString());
                    }
                    else
                    {
                        return -1;
                    }

                }
            }
        }



        public bool insertIVA(string IVA)
        {
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "insert into IVA values(@IVA)";
                        command.Parameters.AddWithValue("@IVA", IVA);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (SqlException)
                {

                    DialogResult result = MessageBox.Show(
                        "Se perdio conexión con el Servidor",
                        "ALERTA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );

                    return false;
                }


            }
        }


        public void metodo()
        {
            if(UserCache.Position == Positions.Administrador)
            {
                // Si el usuario es administrador 
            }
            else
            {

            }

        }
    }
}
