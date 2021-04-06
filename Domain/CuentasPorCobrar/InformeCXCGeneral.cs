using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CuentasPorCobrar
{
    public class InformeCXCGeneral
    {
        public List<ListaCXC> listaCXC { get; private set; }


        public void CargarDatos()
        {
            UserDao Read = new UserDao();
            DataTable cxc = Read.getCXCP();
            Constructor(cxc);
            
        }


        public void cargarDatosT(string cliente, DateTime desde, DateTime hasta, string estado)
        {
            UserDao Read = new UserDao();
            DataTable cxc = Read.getCXCPD(cliente, desde, hasta, estado);
            Constructor(cxc);
        }

        public void cargarDatosTL(string cliente, DateTime desde, DateTime hasta, string[] estado)
        {
            UserDao Read = new UserDao();
            DataTable cxc = Read.getCXCPDL(cliente, desde, hasta, estado);
            Constructor(cxc);
        }




        public static double ToDouble(object value)
        {
            if (value != DBNull.Value)
            {
                return Convert.ToDouble(value);
            }
            return 0;
        }





        public void Constructor(DataTable cxc)
        {
           // UserDao Read = new UserDao();
            listaCXC = new List<ListaCXC>();

            // Constructor 
            foreach (DataRow rowrs in cxc.Rows)
            {
                var CXCmodel = new ListaCXC()
                {
                    Cliente = Convert.ToString(rowrs[0]),
                    CiudadNacionalizacion = Convert.ToString(rowrs[1]),
                    NTramite = Convert.ToString(rowrs[2]),
                    SecuencialCliente = Convert.ToString(rowrs[3]),
                    DAI = Convert.ToString(rowrs[4]),
                    dateSalidaPuerto = Convert.ToDateTime(rowrs[5]),
                    dateVencimiento = Convert.ToDateTime(rowrs[6]),
                    Total = Convert.ToDouble(rowrs[7]),
                    estadoVencimiento = Convert.ToString(rowrs[8]),
                    AgenteGeneral = ToDouble(rowrs[10]),
                    TBC = ToDouble(rowrs[12]),
                    Transporte = ToDouble(rowrs[14]),
                    Honorarios_1 = ToDouble(rowrs[16]),
                    Honorarios_2 = ToDouble(rowrs[18]),
                    Honorarios_3 = ToDouble(rowrs[20]),
                    Gastos = ToDouble(rowrs[22])
                  
                    //nFAG = facturasfacturas,
                    //nFTBC = facturaTBC
                };
                listaCXC.Add(CXCmodel);
            }
        }

    }
}
