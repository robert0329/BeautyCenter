using BeautyCenterCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyCenterCore.BLL
{
    public class DetalleCitasBLL
    {
        public static bool Insertar(List<DetalleCitas> detalles)
        {
            bool resultado = false;
            using (var db = new BeautyCoreDb())
            {
                try
                {
                    foreach (DetalleCitas detail in detalles)
                    {
                        db.DetalleCitas.Add(detail);
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
        public static List<DetalleCitas> GetLista()
        {
            var lista = new List<DetalleCitas>();
            using (var conexion = new BeautyCoreDb())
            {
                try
                {
                    lista = conexion.DetalleCitas.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;

        }
        public static List<DetalleCitas> GetListaId(int Id)
        {
            List<DetalleCitas> list = new List<DetalleCitas>();
            using (var db = new BeautyCoreDb())
            {
                try
                {
                    list = db.DetalleCitas.Where(p => p.ClienteId == Id).ToList();
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
