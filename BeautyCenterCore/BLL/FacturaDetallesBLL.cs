using BeautyCenterCore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyCenterCore.BLL
{
    public class FacturaDetallesBLL
    {
        public static bool Insertar(List<FacturaDetalles> detalles)
        {
            bool resultado = false;
            using (var db = new BeautyCoreDb())
            {
                try
                {
                    foreach (FacturaDetalles detail in detalles)
                    {
                        db.FacturaDetalles.Add(detail);
                        db.SaveChanges();
                        resultado = true;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return resultado;
        }
        
        public static bool Eliminar(FacturaDetalles nuevo)
        {
            bool resultado = false;
            using (var Conn = new BeautyCoreDb())
            {
                try
                {
                    Conn.Entry(nuevo).State = EntityState.Deleted;
                    Conn.SaveChanges();
                    resultado = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return resultado;
        }
        public static FacturaDetalles Buscar(int Id)
        {
            var c = new FacturaDetalles();
            using (var Conn = new BeautyCoreDb())
            {
                try
                {
                    c = Conn.FacturaDetalles.Find(Id);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return c;
        }
        public static List<FacturaDetalles> GetLista()
        {
            var lista = new List<FacturaDetalles>();
            using (var conexion = new BeautyCoreDb())
            {
                try
                {
                    lista = conexion.FacturaDetalles.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;

        }
        public static List<FacturaDetalles> GetListaId(int Id)
        {
            List<FacturaDetalles> list = new List<FacturaDetalles>();
            using (var db = new BeautyCoreDb())
            {
                try
                {
                    list = db.FacturaDetalles.Where(p => p.Id == Id).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return list;
        }
    }
}
