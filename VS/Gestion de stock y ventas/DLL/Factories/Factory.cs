using DLL.Contracts;
using DLL.Repositories.SqlServer;
using DLL.Repositories.SqlServer.Productos;
using DOMAIN;
using DOMAIN.Productos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Factories
{
    public sealed class Factory
    {
        #region Singleton
        private readonly static Factory _instance = new Factory();

        public static Factory Current
        {
            get
            {
                return _instance;
            }
        }

        private Factory()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        public IGenericRepository<Cliente> GetClienteRepository()
        {
            string backend = ConfigurationManager.AppSettings["backend"];
            if(backend == "DAL.Repositories.SqlServer")
            {
                return new ClienteRepository();
            }
            else
            {
                return null;
            }
        }
        public IGenericRepository<Empleado> GetEmpleadoRepository()
        {
            string backend = ConfigurationManager.AppSettings["backend"];
            if (backend == "DAL.Repositories.SqlServer")
            {
                return new EmpleadoRepository();
            }
            else
            {
                return null;
            }
        }
        public IGenericRepository<Servicio> GetServicioRepository()
        {
            string backend = ConfigurationManager.AppSettings["backend"];
            if (backend == "DAL.Repositories.SqlServer")
            {
                return new ServicioRepository();
            }
            else
            {
                return null;
            }
        }
        public IGenericRepository<Proveedor> GetProveedorRepository()
        {
            string backend = ConfigurationManager.AppSettings["backend"];
            if (backend == "DAL.Repositories.SqlServer")
            {
                return new ProveedorRepository();
            }
            else
            {
                return null;
            }
        }
        public IGenericRepository<Rubro> GetRubroRepository()
        {
            string backend = ConfigurationManager.AppSettings["backend"];
            if (backend == "DAL.Repositories.SqlServer")
            {
                return new RubroRepository();
            }
            else
            {
                return null;
            }
        }
        public IGenericRepository<MateriaPrima> GetMateriaPrimaRepository()
        {
            string backend = ConfigurationManager.AppSettings["backend"];
            if (backend == "DAL.Repositories.SqlServer")
            {
                return new MateriaPrimaRepository();
            }
            else
            {
                return null;
            }
        }
        public IGenericRepository<Producto> GetProductoRepository()
        {
            string backend = ConfigurationManager.AppSettings["backend"];
            if (backend == "DAL.Repositories.SqlServer")
            {
                return new ProductoRepository();
            }
            else
            {
                return null;
            }
        }
        public IGenericRepository<Unidad_De_Medida> GetUnidadDeMedidaRepository()
        {
            string backend = ConfigurationManager.AppSettings["backend"];
            if (backend == "DAL.Repositories.SqlServer")
            {
                return new Unidad_de_medidaRepository();
            }
            else
            {
                return null;
            }
        }
        public IOrden_de_CompraRepository<Orden_de_Compra> GetOrden_de_CompraRepository()
        {
            string backend = ConfigurationManager.AppSettings["backend"];
            if (backend == "DAL.Repositories.SqlServer")
            {
                return new Orden_de_compraRepository();
            }
            else
            {
                return null;
            }
        }
        public IOrden_de_ventaRepository<Orden_de_Venta> GetOrden_de_VentaRepository()
        {
            string backend = ConfigurationManager.AppSettings["backend"];
            if (backend == "DAL.Repositories.SqlServer")
            {
                return new Orden_de_ventaRepository();
            }
            else
            {
                return null;
            }
        }
        public IPagosRepository<Pago_Empleado> GetPago_empleadoRepository()
        {
            string backend = ConfigurationManager.AppSettings["backend"];
            if (backend == "DAL.Repositories.SqlServer")
            {
                return new Pago_empleadoRepository();
            }
            else
            {
                return null;
            }
        }
        public IPagoProveedorRepository<Pago_Proveedor> GetPago_proveedorRepository()
        {
            string backend = ConfigurationManager.AppSettings["backend"];
            if (backend == "DAL.Repositories.SqlServer")
            {
                return new Pago_proveedorRepository();
            }
            else
            {
                return null;
            }
        }
        public IPagosRepository<Pago_Servicio> GetPago_servicioRepository()
        {
            string backend = ConfigurationManager.AppSettings["backend"];
            if (backend == "DAL.Repositories.SqlServer")
            {
                return new Pago_servicioRepository();
            }
            else
            {
                return null;
            }
        }
        public IVentaRepository<Venta> GetVentaRepository()
        {
            string backend = ConfigurationManager.AppSettings["backend"];
            if (backend == "DAL.Repositories.SqlServer")
            {
                return new VentaRepository();
            }
            else
            {
                return null;
            }
        }
        public IGenericRepository<Tipo_de_pago> GetTipo_de_PagoRepository()
        {
            string backend = ConfigurationManager.AppSettings["backend"];
            if (backend == "DAL.Repositories.SqlServer")
            {
                return new Tipo_de_pagoRepository();
            }
            else
            {
                return null;
            }
        }
        public IGenericRelationship<MateriaPrima, Producto> GetMateriaPrimaProductoRelationship()
        {
            string backend = ConfigurationManager.AppSettings["backend"];
            if (backend == "DAL.Repositories.SqlServer")
            {
                return new MateriaPrimaProductoRelationship();
            }
            else
            {
                return null;
            }
        }
        public IGenericRepository<Inventario> GetInventarioRepository()
        {
            string backend = ConfigurationManager.AppSettings["backend"];
            if (backend == "DAL.Repositories.SqlServer")
            {
                return new InventarioRepository();
            }
            else
            {
                return null;
            }
        }
        public IGenericRepository<Movimiento_Caja> GetMovimiento_cajaRepository()
        {
            string backend = ConfigurationManager.AppSettings["backend"];
            if (backend == "DAL.Repositories.SqlServer")
            {
                return new Movimiento_cajaRepository();
            }
            else
            {
                return null;
            }
        }
        public IGenericRepository<Tipo_de_movimiento> GetTipo_de_movimientoRepository()
        {
            string backend = ConfigurationManager.AppSettings["backend"];
            if (backend == "DAL.Repositories.SqlServer")
            {
                return new Tipo_de_movimientoRepository();
            }
            else
            {
                return null;
            }
        }
        public ITurnoRepository<Turno> GetTurnoRepository()
        {
            string backend = ConfigurationManager.AppSettings["backend"];
            if (backend == "DAL.Repositories.SqlServer")
            {
                return new TurnoRepository();
            }
            else
            {
                return null;
            }
        }
    }

}
