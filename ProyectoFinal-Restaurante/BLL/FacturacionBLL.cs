using ProyectoFinal_Restaurante.Entidades;
//using ProyectoFinal_Restaurante.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ProyectoFinal_Restaurante.BLL
{
    public class FacturacionBLL
    {
        private static Usuario usuario = new Usuario();
        public static bool Guardar(Factura factura)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.factura.Add(factura) != null)
                {
                    db.SaveChanges();
                    db.Dispose();
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static bool GuardarDetalle(FacturaDetalle factura)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Facturas.Add(factura) != null)
                {
                    db.SaveChanges();
                    db.Dispose();
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.factura.Find(Id);
                if (eliminar != null)
                {
                    db.Facturas.RemoveRange(db.Facturas.Where(x => x.FacturaId == eliminar.FacturaId));
                    db.Entry(eliminar).State = EntityState.Deleted;
                    if (db.SaveChanges() > 0)
                    {
                        db.Dispose();
                        paso = true;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static bool Modificar(Factura factura)
        {
            bool paso = false;
            bool paso1 = false;
            Contexto db = new Contexto();
            try
            {
                var facturas = Buscar(factura.FacturaId);
                db.Entry(facturas).State = EntityState.Modified;
                ArreglarProducto(facturas);
                foreach (var item in facturas.Detalle)
                {
                    if (item.Id == 0)
                    {
                        GuardarDetalle(item);
                    }
                    else
                    {                    
                        db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                        if (db.SaveChanges() > 0)
                        {
                            paso1 = true;
                            paso = true;
                        }
                    }
                }
                if (paso1 == false)
                {
                    if (db.SaveChanges() > 0)
                    {

                        paso = true;
                    }
                }
                DescontarProductos(Buscar(facturas.FacturaId).Detalle);
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static Factura Buscar(int id)
        {
            Factura factura = new Factura();
            Contexto db = new Contexto();
            try
            {
                factura = db.factura.Find(id);
                if (factura != null)
                {
                    factura.Detalle.Count();
                }
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return factura;
        }
        public static List<Factura> GetList(Expression<Func<Factura, bool>> factura)
        {
            List<Factura> facturas = new List<Factura>();
            Contexto db = new Contexto();
            try
            {
                facturas = db.factura.Where(factura).ToList();
                foreach (var item in facturas)
                {
                    item.Detalle.Count();
                }
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return facturas;
        }
        public static decimal devuelta(decimal monto, decimal efectivo)
        {
            decimal devuelta = 0;
            devuelta = efectivo - monto;
            return devuelta;
        }
        public static decimal CalcularMonto(decimal importe)
        {
            decimal monto = 0;
            monto += importe;
            return monto;
        }
        public static decimal Importe(decimal cantidadDefecto, decimal cantidad, decimal precio, int id, int ID)
        {
            decimal importe = 0;
            if (ID == id)
            {
                importe = cantidad * precio;
            }
            else
            {
                importe = cantidadDefecto * precio;
            }
            return importe;
        }
        public static decimal Importedemas(decimal cantidad, decimal precio)
        {
            decimal importe = 0;
            importe = cantidad * precio;
            return importe;
        }
        public static void DescontarProductos(List<FacturaDetalle> factura)
        {
            // Descontar cantidad a productos
            RepositoryBase<Producto> repositoryBase = new RepositoryBase<Producto>();
            foreach (var item in factura) 
            {
                var producto = repositoryBase.Buscar(item.ProductoId);
                producto.Cantidad -= item.Cantidad;
                repositoryBase.Modificar(producto);
            }
        }
        public static void ArreglarProducto(Factura factura)
        {
            RepositoryBase<Producto> repositoryBase = new RepositoryBase<Producto>();
            foreach (var item in factura.Detalle)
            {
                var producto = repositoryBase.Buscar(item.ProductoId);
                producto.Cantidad += item.Cantidad;
                repositoryBase.Modificar(producto);
            }
        }
        public static void ArreglarProductoList(List<FacturaDetalle> factura)
        {
            RepositoryBase<Producto> repositoryBase = new RepositoryBase<Producto>();
            foreach (var item in factura)
            {
                var producto = repositoryBase.Buscar(item.ProductoId);
                producto.Cantidad += item.Cantidad;
                repositoryBase.Modificar(producto);
            }
        }
        public static List<FacturaDetalle> Editar(List<FacturaDetalle> list, FacturaDetalle factura)
        {
            foreach (var item in list)
            {
                if (item.Id == factura.Id)
                {
                    item.Cantidad = factura.Cantidad;
                }
            }
            return list;
        }
        public static decimal DescontarImporte(List<FacturaDetalle> list, int id)
        {
            decimal monto = 0;
            foreach (var item in list)
            {
                if (item.Id == id)
                {
                  item.Importe = item.Cantidad * item.Precio;
                  monto = item.Importe;
                }
            }
            return monto;
        }
        public static decimal RecalcularImporte(List<FacturaDetalle> list, int row)
        {
            decimal monto = 0;
            FacturaDetalle factura = list.ElementAt(row);
            factura.Importe = factura.Cantidad * factura.Precio;
            monto = factura.Importe;
            return monto;
        }
        public static decimal CalcularDevuelta(decimal efectivo, decimal monto)
        {
            decimal devuelta = 0;
            devuelta = efectivo - monto;
            return devuelta;
        }
        public static int Mayor(List<Factura> factura)
        {
            int mayor = 0;
            foreach (var item in factura)
            {
                if (mayor == 0)
                {
                  mayor = item.FacturaId;
                }
                else
                {
                  if (mayor < item.FacturaId)
                  {
                    mayor = item.FacturaId;
                  }
                }
            }
            return mayor;
        }
        public static void NombreLogin(string nombre, int id)
        {
           usuario.Nombre = nombre;
           usuario.UsuarioID = id;
        }
        public static Usuario returnUsuario()
        {
          return usuario;
        }
        public static decimal RetornarDevuelta(decimal efectivo, decimal monto)
        {
          decimal devuelta = CalcularDevuelta(efectivo, monto);
          return devuelta;
        }
    }
}
