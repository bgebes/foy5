using Foy5.Model.Entity;
using Foy5.Model.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foy5.Model.Operations
{
    public class tDersOperations : IEntityOperations<tDers, string>
    {
        public tDers create(tDers entity)
        {
            var db = DBVariables.GetDBModel();

            var record = db.TDersler.Add(entity);
            db.SaveChanges();

            return record;
        }

        public List<tDers> list()
        {
            return DBVariables.GetDBModel().TDersler.ToList();
        }

        public tDers read(string ID)
        {
            return DBVariables.GetDBModel().TDersler.SingleOrDefault(x => x.dersID == ID);
        }

        public tDers update(tDers entity)
        {
            var db = DBVariables.GetDBModel();

            var record = db.TDersler.SingleOrDefault(x => x.dersID == entity.dersID);
            if (record != null)
            {
                db.Entry(record).CurrentValues.SetValues(entity);
                db.SaveChanges();
            }

            return record;
        }

        public tDers delete(string ID)
        {
            var db = DBVariables.GetDBModel();

            var record = db.TDersler.Remove(
                read(ID)
            );
            db.SaveChanges();

            return record;
        }       
    }
}
