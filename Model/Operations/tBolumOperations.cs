using Foy5.Model.Entity;
using Foy5.Model.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foy5.Model.Operations
{
    public class tBolumOperations : IEntityOperations<tBolum, string>
    {
        public tBolum create(tBolum entity)
        {
            var db = DBVariables.GetDBModel();

            var record = db.TBolumler.Add(entity);
            db.SaveChanges();

            return record;
        }

        public List<tBolum> list()
        {
            return DBVariables.GetDBModel().TBolumler.ToList();
        }

        public tBolum read(string ID)
        {
            return DBVariables.GetDBModel().TBolumler.SingleOrDefault(x => x.bolumID == ID);
        }

        public tBolum update(tBolum entity)
        {
            var db = DBVariables.GetDBModel();

            var record = db.TBolumler.SingleOrDefault(x => x.bolumID == entity.bolumID);
            if (record != null)
            {
                db.Entry(record).CurrentValues.SetValues(entity);
                db.SaveChanges();
            }

            return record;
        }

        public tBolum delete(string ID)
        {
            var db = DBVariables.GetDBModel();

            var record = db.TBolumler.Remove(
                read(ID)
            );
            db.SaveChanges();

            return record;
        }
    }
}
