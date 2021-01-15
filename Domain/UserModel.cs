using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;
using DataAccess;

namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }


        public string recoverPassword(string userRecovering)
        {
            return userDao.recoverPassword(userRecovering);
        }


        public DataTable readClients()
        {
            return userDao.readClients();
        }

        public DataTable readProveedores()
        {
            return userDao.readProveedores();
        }


        public List<string> readTipoFactura(int nTramite)
        {
            return userDao.readTipoFactura(nTramite);
        }


        public List<string> readFacturasIngresados(int nTramite)
        {
            return userDao.readFacturasIngresados(nTramite);
        }

        public DataTable readPagos(int nTramite)
        {
            return userDao.readPagos(nTramite);
        }

        public DataTable readAbonos(string nFactura)
        {
            return userDao.readAbonos(nFactura);
        }

        public DataTable readAbonoFactura(string nFactura)
        {
            return userDao.readAbonoFactura(nFactura);
        }

        public DataTable informeTBC()
        {
            return userDao.informeTBC();
        }

        public DataTable informeLDM()
        {
            return userDao.informeLDM();
        }

        public int readIDTramiteImport()
        {
            return userDao.readIDTramitesImport();
        }

        public int readIDInformes()
        {
            return userDao.readIDInformes();
        }

        public DataTable readIVA()
        {
            return userDao.readIVA();
        }

        public DataTable readRetencionRenta()
        {
            return userDao.readRetencionRenta();
        }

        public DataTable readRetencionIVA()
        {
            return userDao.readRetencionIVA();
        }

        public bool deleteIVA(double iva)
        {
            return userDao.deleteIVA(iva);
        }

        public bool deleteRetRenta(double iva)
        {
            return userDao.deleteRetRenta(iva);
        }

        public bool deleteRetIVA(double iva)
        {
            return userDao.deleteRetIVA(iva);
        }

        public bool insertIVA(string IVA)
        {
            return userDao.insertIVA(IVA);
        }

        public bool insertIVARetRenta(string IVA)
        {
            return userDao.insertIVARetRenta(IVA);
        }

        public bool insertIVARetIVA(string IVA)
        {
            return userDao.insertIVARetIVA(IVA);
        }

        public DataTable searchClients(string data)
        {
            return userDao.searchClients(data);
        }

        public DataTable searchProveedores(string data)
        {
            return userDao.searchProveedores(data);
        }

        public DataTable searchTramiteImport(string data)
        {
            return userDao.searchTramiteImport(data);
        }

        public DataTable seacrhComisiones(int idTramite)
        {
            return userDao.seacrhComisiones(idTramite);
        }


        public double saldoTramite(int nTramite)
        {
            return userDao.saldoTramite(nTramite);
        }


        public void searchRetenciones(string RUCEmpresa)
        {
            userDao.searchRetenciones(RUCEmpresa);
        }



        public DataTable readTramitesImport()
        {
            return userDao.readTramitesImport();
        }



        public DataTable readTramitesComision()
        {
            return userDao.readTramitesComision();
        }

        public DataTable readFacturasporClientes(string dateDesde, string dateHasta)
        {
            return userDao.readFacturasporClientes(dateDesde, dateHasta);
        }

        public DataTable readCartaCliente(string dateDesde, string dateHasta)
        {
            return userDao.readCartaCliente(dateDesde, dateHasta);
        }

        public DataTable readCartaClienteB(string dateDesde, string dateHasta, string Texto)
        {
            return userDao.readCartaClienteB(dateDesde, dateHasta, Texto);
        }


        public DataTable readDatosCarta(string ID_Tramite)
        {
            return userDao.readDatosCarta(ID_Tramite);
        }



        public DataTable readFacturasporClientesNombre(string dateDesde, string dateHasta, string texto)
        {
            return userDao.readFacturasporClientesNombre(dateDesde, dateHasta, texto);
        }

        public DataTable readFacturasTramite(string RUC, string dateDesde, string dateHasta)
        {
            return userDao.readFacturasTramite(RUC, dateDesde, dateHasta);
        }


        public DataTable readFacturasTramiteT(string dateDesde, string dateHasta)
        {
            return userDao.readFacturasTramiteT(dateDesde, dateHasta);
        }


        public DataTable readFacturasTramiteTB(string dateDesde, string dateHasta, string texto)
        {
            return userDao.readFacturasTramiteTB(dateDesde, dateHasta, texto);
        }

        public DataTable readFacturasTramiteB(string RUC, string dateDesde, string dateHasta, string Texto)
        {
            return userDao.readFacturasTramiteB(RUC, dateDesde, dateHasta, Texto);
        }

        public DataTable readInfoFacturas(string ID_Tramite)
        {
            return userDao.readInfoFacturas(ID_Tramite);
        }

        public DataTable readInfoFacturasT()
        {
            return userDao.readInfoFacturasT();
        }

        public DataTable readInfoFacturasTB(string texto)
        {
            return userDao.readInfoFacturasTB(texto);
        }

        public DataTable readFacturas(string nFactura)
        {
            return userDao.readFacturas(nFactura);
        }

        public void searchIDTramite(string nFactura)
        {
           userDao.searchIDTramite(nFactura);
        }

        public DataTable readAnticipo(int nTramite)
        {
            return userDao.readAnticipo(nTramite);
        }

        public DataTable readTramitesComisionFactura(string[] values)
        {
            return userDao.readTramitesComisionFactura(values);
        }

        public DataTable readTramitesComisionNotaVenta(string[] values)
        {
            return userDao.readTramitesComisionNotaVenta(values);
        }

        public string readNombreEmpresa(string RUC)
        {
            return userDao.readEmpresaTramite(RUC);
        }

        public string readRUCEmpresaTramite(string RUC)
        {
            return userDao.readRUCEmpresaTramite(RUC);
        }


        public bool InsertDataClient(string[] values)
        {
            return userDao.insertDataClient(values);
        }

        public bool InsertDataProveedor(string[] values)
        {
            return userDao.insertDataProveedor(values);
        }

        public bool InsertDataTramite(string[] values)
        {
            return userDao.insertDataTramite(values);
        }

        public bool InsertDataFactura(string[] values)
        {
            return userDao.insertDataFactura(values);
        }

        public bool InsertDataFacturaComision(string[] values)
        {
            return userDao.InsertDataFacturaComision(values);
        }

        public bool InsertDataNotaVentaComision(string[] values)
        {
            return userDao.InsertDataNotaVentaComision(values);
        }

        public bool InsertDataPago(string[] values)
        {
            return userDao.insertDataPago(values);
        }

        public bool InsertDataAnticipo(string[] values)
        {
            return userDao.insertDataAnticipo(values);
        }

        public bool InsertDataSaldo(string[] values)
        {
            return userDao.insertDataSaldo(values);
        }

        public bool InsertInforme(string[] values)
        {
            return userDao.insertInforme(values);
        }

        public bool searchRUC(string RUC)
        {
            return userDao.searchRUC(RUC);
        }

        public bool searchSecuencial(string secuencial)
        {
            return userDao.searchSecuencial(secuencial);
        }

        public bool searchRUCProveedor(string RUC)
        {
            return userDao.searchRUCProveedor(RUC);
        }

        public bool searchNFactura(string nfactura)
        {
            return userDao.searchNFactura(nfactura);
        }

        public bool searchFacturaComision(string nfactura)
        {
            return userDao.searchFacturaComision(nfactura);
        }

        public bool searchNotaVentaComision(string nfactura)
        {
            return userDao.searchNotaVentaComision(nfactura);
        }

        public bool searchIVA(string IVA)
        {
            return userDao.searchIVA(IVA);
        }

        public bool searchIVARetRenta(string IVA)
        {
            return userDao.searchIVARetRenta(IVA);
        }


        public bool searchIVARetIVA(string IVA)
        {
            return userDao.searchIVARetIVA(IVA);
        }

        public DataTable searchComisionCliente(string cliente)
        {
            return userDao.searchComisionesCliente(cliente);
        }


        public double searchValorFacturaLDM(int nTramite)
        {
            return userDao.searchValorFacturaLDM(nTramite);
        }


        public void metodo()
        {
            if (UserCache.Position == Positions.Administrador)
            {
                // Si el usuario es administrador 
            }
            else
            {

            }
        }
    }

}
