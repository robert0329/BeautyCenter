using BeautyCenterCore.Models;
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
    }
}
