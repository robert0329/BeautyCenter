using BeautyCenterCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyCenterCore.BLL
{
    public class FacturasBLL
    {
        public static bool Guardar(Facturas nueva)
        {
            bool resultado = false;
            using (var db = new BeautyCoreDb())
            {
                db.Facturas.Add(nueva);
                db.SaveChanges();
                resultado = true;
            }

            return resultado;
        }
        public static List<Facturas> GetLista()
        {
            var lista = new List<Facturas>();
            using (var conexion = new BeautyCoreDb())
            {
                try
                {
                    lista = conexion.Facturas.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;

        }
        public static bool Eliminar(Facturas nuevo)
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
        public static Facturas Buscar(int Id)
        {
            var c = new Facturas();
            using (var Conn = new BeautyCoreDb())
            {
                try
                {
                    c = Conn.Facturas.Find(Id);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return c;
        }
    }
}
