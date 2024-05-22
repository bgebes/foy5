using Foy5.Model.Entity;
using Foy5.Model.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foy5.Model.Operations
{
    public class tOgrenciOperations : IEntityOperations<tOgrenci, string>
    {
        public tOgrenci create(tOgrenci entity)
        {
            var db = DBVariables.GetDBModel();

            var record = db.TOgrenciler.Add(entity);
            db.SaveChanges();
            
            return record;    
        }

        public List<tOgrenci> list()
        { 
            return DBVariables.GetDBModel().TOgrenciler.ToList();
        }

        public tOgrenci read(string ID)
        {
            return DBVariables.GetDBModel().TOgrenciler.SingleOrDefault(x => x.ogrenciID == ID);
        }

        public tOgrenci update(tOgrenci entity)
        {
            var db = DBVariables.GetDBModel();

            var record = db.TOgrenciler.SingleOrDefault(x => x.ogrenciID == entity.ogrenciID);
            if (record != null)
            {
                db.Entry(record).CurrentValues.SetValues(entity);
                db.SaveChanges();
            }

            return record;
        }

        public tOgrenci delete(string ID)
        {
            var db = DBVariables.GetDBModel();

            var record = db.TOgrenciler.Remove(
                read(ID)
            );
            db.SaveChanges();

            return record;
        }     
    }
}
