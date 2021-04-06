using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CuentasPorCobrarDetallado
{
    public class InformeCXCDetallado
    {

        public List<ListaCXCD> listaCXCD { get; private set; }

        public void CargarDatos()
        {
            UserDao Read = new UserDao();
            DataTable cxc = Read.getCXCDP();
            Constructor(cxc);
        }

        public void cargarDatosT(string cliente, DateTime desde, DateTime hasta, string estado)
        {
            UserDao Read = new UserDao();
            DataTable cxc = Read.getCXCDPD(cliente, desde, hasta, estado);
            Constructor(cxc);
        }

        public void cargarDatosTL(string cliente, DateTime desde, DateTime hasta, string[] estado)
        {
            UserDao Read = new UserDao();
            DataTable cxc = Read.getCXCDPDL(cliente, desde, hasta, estado);
            Constructor(cxc);
        }

        public void Constructor(DataTable cxc)
        {
            UserDao Read = new UserDao();
            listaCXCD = new List<ListaCXCD>();

            // Constructor 
            foreach (DataRow rowrs in cxc.Rows)
            {
                var CXCmodel = new ListaCXCD()
                {
                    Cliente = Convert.ToString(rowrs[0]),
                    NTramite = Convert.ToString(rowrs[1]),
                    CiudadNacionalizacion = Convert.ToString(rowrs[2]),
                    SecuencialCliente = Convert.ToString(rowrs[3]),
                    DAI = Convert.ToString(rowrs[4]),
                    dateSalidaPuerto = Convert.ToDateTime(rowrs[5]),
                    EmpresaFactura = Convert.ToString(rowrs[6]),
                    TF = Convert.ToString(rowrs[7]),
                    dateFactura = Convert.ToDateTime(rowrs[8]),
                    dateVencimiento = Convert.ToDateTime(rowrs[9]),
                    estadoVencimiento = Convert.ToString(rowrs[10]),
                    nFactura = Convert.ToString(rowrs[11]),
                    valorACobrar = Convert.ToDouble(rowrs[12])
                };
                listaCXCD.Add(CXCmodel);
            }
        }
    }
}
