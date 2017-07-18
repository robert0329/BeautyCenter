using BeautyCenterCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyCenterCore.BLL
{
    public class ServiciosBLL
    {
        public static bool Insertar(Servicios nuevo)
        {
            bool resultado = false;
            using (var Conn = new BeautyCoreDb())
            {
                try
                {
                    var p = Buscar(nuevo.ServicioId);
                    if (p == null)
                        Conn.Servicios.Add(nuevo);
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
        public static bool Eliminar(Servicios nuevo)
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
        public static Servicios Buscar(int Id)
        {
            var c = new Servicios();
            using (var Conn = new BeautyCoreDb())
            {
                try
                {
                    c = Conn.Servicios.Find(Id);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return c;
        }
        public static List<Servicios> GetLista()
        {
            var lista = new List<Servicios>();
            using (var conexion = new BeautyCoreDb())
            {
                try
                {
                    lista = conexion.Servicios.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;

        }
        public static List<Servicios> GetListaId(int Id)
        {
            List<Servicios> list = new List<Servicios>();
            using (var db = new BeautyCoreDb())
            {
                try
                {
                    list = db.Servicios.Where(p => p.ServicioId == Id).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return list;
        }
        public static List<Servicios> ListarServicios()
        {
            List<Servicios> listado = null;
            using (var conexion = new BeautyCoreDb())
            {
                try
                {
                    listado = conexion.Servicios.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return listado;
        }
    }
}
