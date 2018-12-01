//using ProyectoFinal_Restaurante.DAL;
using ProyectoFinal_Restaurante.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ProyectoFinal_Restaurante.BLL
{
    public class FacturaDetalleBLL
    {
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Facturas.Find(id);
                if (eliminar != null)
                {
                    db.Entry(eliminar).State = EntityState.Deleted;
                    if (db.SaveChanges() > 0)
                    {
                        paso = true;
                        db.Dispose();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static List<FacturaDetalle> GetList(Expression<Func<FacturaDetalle, bool>> bill)
        {
            List<FacturaDetalle> factura = new List<FacturaDetalle>();
            Contexto db = new Contexto();
            try
            {
                factura = db.Facturas.Where(bill).ToList();
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return factura;
        }
        public static FacturaDetalle Buscar(int id)
        {
            FacturaDetalle factura = new FacturaDetalle();
            Contexto db = new Contexto();
            try
            {
                factura = db.Facturas.Find(id);
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return factura;
        }
    }
}
