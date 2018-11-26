﻿using ProyectoFinal_Restaurante.DAL;
using ProyectoFinal_Restaurante.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Restaurante.BLL
{
    public class FacturacionBLL
    {
        public static bool Guardar(Facturacion factura)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            Usuario usuario = new Usuario();
            try
            {
                if (contexto.Factura.Add(factura) != null)
                {
                    foreach (var item in factura.Detalle)
                    {
                        contexto.Producto.Find(item.ProductoID).Cantidad -= item.Cantidad;
                    }
                    contexto.Usario.Find(factura.UsuarioID).TotalVendido += factura.ToTal;
                    contexto.SaveChanges();
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }




        public static bool Modificar(Facturacion factura)
        {
            RepositoryBase<Usuario> repository = new RepositoryBase<Usuario>();
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var facturas = Buscar(factura.FactutaID);
                var usuario = contexto.Usario.Find(factura.UsuarioID);
                var usuarioAnterior = contexto.Usario.Find(factura.UsuarioID);

                if (factura.UsuarioID != factura.UsuarioID)
                {
                    usuario.TotalVendido += factura.ToTal;
                    usuario.TotalVendido -= factura.ToTal;
                    repository.Modificar(usuario);
                    repository.Modificar(usuarioAnterior);

                }
                if (factura != null)
                {
                    foreach (var item in factura.Detalle)
                    {
                        contexto.Producto.Find(item.ProductoID).Cantidad += item.Cantidad;
                        if (!factura.Detalle.ToList().Exists(x => x.FacturaDetalleID == item.FacturaDetalleID))
                        {
                            item.Productos = null;
                            contexto.Entry(item).State = EntityState.Deleted;

                        }

                    }
                    foreach (var item in factura.Detalle)
                    {
                        contexto.Producto.Find(item.Productos).Cantidad -= item.Cantidad;
                        var estado = item.FacturaDetalleID > 0 ? EntityState.Modified : EntityState.Added;
                        contexto.Entry(item).State = estado;
                    }
                    Facturacion entradaAnt = Buscar(factura.FactutaID);

                    decimal diferencia;

                    diferencia = factura.ToTal - entradaAnt.ToTal;
                    RepositoryBase<Usuario> repositoryb = new RepositoryBase<Usuario>();
                    Usuario usuarios = repositoryb.Buscar(factura.UsuarioID);

                    usuario.TotalVendido += diferencia;

                    repositoryb.Modificar(usuario);

                    contexto.Entry(factura).State = EntityState.Modified;
                    if (contexto.SaveChanges() > 0)
                    {
                        paso = true;

                    }
                    contexto.Dispose();


                }

            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }




        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Facturacion factura = new Facturacion();
                if (factura != null)
                {
                    foreach (var item in factura.Detalle)
                    {
                        contexto.Producto.Find(item.ProductoID).Cantidad += item.Cantidad;
                    }
                    contexto.Usario.Find(factura.UsuarioID).TotalVendido -= factura.Cantidad;
                    factura.Detalle.Count();
                    contexto.Factura.Remove(factura);
                }
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }





        public static Facturacion Buscar(int id)
        {
            Facturacion factura = new Facturacion();
            Contexto contexto = new Contexto();
            try
            {
                factura = contexto.Factura.Find(id);
                if (factura != null)
                {
                    factura.Detalle.Count();
                    foreach (var item in factura.Detalle)
                    {
                        string des = item.Producto.Descripcion;
                    }
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return factura;
        }




        public static List<Facturacion> GetList(Expression<Func<Facturacion, bool>> expression)
        {
            List<Facturacion> facturas = new List<Facturacion>();
            Contexto contexto = new Contexto();

            try
            {
                facturas = contexto.Factura.Where(expression).ToList();
                foreach (var item in facturas)
                {
                    item.Detalle.Count();

                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return facturas;
        }



        public static int CacularImporte(int precio, int cantidad)
        {
            return precio = cantidad;
        }



        public static decimal CacularItebis(decimal subTotal)
        {

            return Convert.ToDecimal(subTotal) + Convert.ToDecimal(0.18);

        }



        public static decimal CarcularTotal(decimal subTotal, decimal itebis)
        {
            return Convert.ToDecimal(subTotal) + Convert.ToDecimal(itebis);
        }

    }
}
