using Foy5.Model.Entity;
using Foy5.Model.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foy5.Model.Operations
{
    public class tFakulteOperations : IEntityOperations<tFakulte, string>
    {
        public tFakulte create(tFakulte entity)
        {
            var db = DBVariables.GetDBModel();

            var record = db.TFakulteler.Add(entity);
            db.SaveChanges();

            return record;
        }

        public List<tFakulte> list()
        {
            return DBVariables.GetDBModel().TFakulteler.ToList();
        }

        public tFakulte read(string ID)
        {
            return DBVariables.GetDBModel().TFakulteler.SingleOrDefault(x => x.fakulteID == ID);
        }

        public tFakulte update(tFakulte entity)
        {
            var db = DBVariables.GetDBModel();

            var record = db.TFakulteler.SingleOrDefault(x => x.fakulteID == entity.fakulteID);
            if (record != null)
            {
                db.Entry(record).CurrentValues.SetValues(entity);
                db.SaveChanges();
            }

            return record;
        }

        public tFakulte delete(string ID)
        {
            var db = DBVariables.GetDBModel();

            var record = db.TFakulteler.Remove(
                read(ID)
            );
            db.SaveChanges();

            return record;
        }     
    }
}
