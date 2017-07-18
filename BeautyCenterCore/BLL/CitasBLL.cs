using BeautyCenterCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyCenterCore.BLL
{
    public class CitasBLL
    {
        public static bool Insertar(Citas nuevo)
        {
            bool resultado = false;
            using (var Conn = new BeautyCoreDb())
            {
                try
                {
                    var p = Buscar(nuevo.CitaId);
                    if (p == null)
                        Conn.Citas.Add(nuevo);
                    else
                        Conn.Entry(nuevo).State = EntityState.Modified;
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
        public static bool Eliminar(Citas nuevo)
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
        public static Citas Buscar(int Id)
        {
            var c = new Citas();
            using (var Conn = new BeautyCoreDb())
            {
                try
                {
                    c = Conn.Citas.Find(Id);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return c;
        }
        public static List<Citas> GetLista()
        {
            var lista = new List<Citas>();
            using (var conexion = new BeautyCoreDb())
            {
                try
                {
                    lista = conexion.Citas.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;

        }
        public static List<Citas> GetListaId(int Id)
        {
            List<Citas> list = new List<Citas>();
            using (var db = new BeautyCoreDb())
            {
                try
                {
                    list = db.Citas.Where(p => p.ClienteId == Id).ToList();
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
