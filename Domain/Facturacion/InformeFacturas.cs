using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess; 

namespace Domain.Facturacion
{
    public class InformeFacturas
    {
        public DateTime dateInforme { get; private set; }
        public DateTime dateInicio { get; private set; }
        public DateTime dateFinal { get; private set; }
        public List<ListadoFacturas> listadoFacturas { get; private set; }
        public List<InformacionTramite> informacionTramite { get; private set; }
        public double totalFacturas { get; private set; }



        public void crearInformeFacturas(int idTramite)
        {
            dateInforme = DateTime.Now;

            UserDao Read = new UserDao();
            var facturas = Read.getFacturas(idTramite);
           // var infoTramite = Read.getInfoTramite(idTramite);


            listadoFacturas = new List<ListadoFacturas>();

            foreach (DataRow rowrs in facturas.Rows)
            {
                var facturasModel = new ListadoFacturas()
                {
                    tipoGasto = Convert.ToString(rowrs[0]),
                    empresa = Convert.ToString(rowrs[1]),
                    nFactura = Convert.ToString(rowrs[2]),
                    totalFactura = Convert.ToDouble(rowrs[3]),
                    nRetencion = Convert.ToString(rowrs[4]),
                    totalRetencion = Convert.ToDouble(rowrs[5]),
                    nNC = Convert.ToString(rowrs[6]),
                    totalNC = Convert.ToDouble(rowrs[7]),
                    valorAPagar = Convert.ToDouble(rowrs[8])
                   // abono = Convert.ToDouble(rowrs[9]),
                   // dateAbono = Convert.ToDateTime(rowrs[10]),
                   // detalleAbono = Convert.ToString(rowrs[11]),
                   // valorPendientePago = Convert.ToDouble(rowrs[12])
                };

                listadoFacturas.Add(facturasModel);
                totalFacturas += Convert.ToDouble(rowrs[8]);
            }
/*
            informacionTramite = new List<InformacionTramite>();

            foreach (DataRow rowrs in infoTramite.Rows)
            {
                var tramitesModel = new ListadoFacturas()
                {
                    tipoGasto = Convert.ToString(rowrs[0]),
                    empresa = Convert.ToString(rowrs[1]),
                    nFactura = Convert.ToString(rowrs[2]),
                    totalFactura = Convert.ToDouble(rowrs[3]),
                    nRetencion = Convert.ToString(rowrs[4]),
                    totalRetencion = Convert.ToDouble(rowrs[5]),
                    nNC = Convert.ToString(rowrs[6]),
                    totalNC = Convert.ToDouble(rowrs[7]),
                    valorAPagar = Convert.ToDouble(rowrs[8])
                };

                listadoFacturas.Add(tramitesModel);
            }*/
        }
    }
}
