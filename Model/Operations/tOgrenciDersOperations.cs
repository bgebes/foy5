using Foy5.Model.Entity;
using Foy5.Model.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foy5.Model.Operations
{
    public class tOgrenciDersOperations : IEntityOperations<tOgrenciDers, string>
    {
        public tOgrenciDers create(tOgrenciDers entity)
        {
            var db = DBVariables.GetDBModel();

            var record = db.TOgrenciDersler.Add(entity);
            db.SaveChanges();

            return record;
        }

        public List<tOgrenciDers> list()
        {
            return DBVariables.GetDBModel().TOgrenciDersler.ToList();
        }

        public tOgrenciDers read(string ID)
        {
            return DBVariables.GetDBModel().TOgrenciDersler.SingleOrDefault(x => x.ogrenciDersID == ID);
        }

        public tOgrenciDers update(tOgrenciDers entity)
        {
            var db = DBVariables.GetDBModel();

            var record = db.TOgrenciDersler.SingleOrDefault(x => x.ogrenciDersID == entity.ogrenciDersID);
            if (record != null)
            {
                db.Entry(record).CurrentValues.SetValues(entity);
                db.SaveChanges();
            }

            return record;
        }

        public tOgrenciDers delete(string ID)
        {
            var db = DBVariables.GetDBModel();

            var record = db.TOgrenciDersler.Remove(
                read(ID)
            );
            db.SaveChanges();

            return record;
        }
    }
}
