using SegundoParcial.DAL;
using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.BLL
{
    public class MetaBll
    {

        public static Meta Buscar(int id)
        {
            Contexto db = new Contexto();
            Meta meta = new Meta();
            try
            {
                meta = db.Meta.Find(id);
                meta.Metas.Count();
            }
            catch (Exception)
            { throw; }
            finally
            { db.Dispose(); }
            return meta;
        }
        public static bool Modificar(Meta meta)
        {

            bool paso = false;
            var Anterior = MetaBll.Buscar(meta.MetaId);
            Contexto db = new Contexto();
            try
            {
                foreach (var item in Anterior.Metas)
                {
                    if (!meta.Metas.Exists(d => d.MetaId == item.MetaId))
                        db.Entry(item).State = EntityState.Deleted;
                }
                foreach (var item in meta.Metas)
                {
                    var estado = (item.MetaId == 0) ? EntityState.Added : EntityState.Modified;
                    db.Entry(item).State = estado;
                }
                db.Entry(meta).State = EntityState.Modified;
                if (db.SaveChanges() > 0)
                {
                    paso = true;
                }
            }
            catch (Exception)
            { throw; }
            finally
            { db.Dispose(); }
            return paso;
        }
    }
}
