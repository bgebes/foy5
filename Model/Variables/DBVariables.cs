using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foy5.Model.Variables
{
    class DBVariables
    {
        public static DBModel dBModel {  get; set; }

        public static DBModel GetDBModel() { 
            if(dBModel == null)
            {
                dBModel = new DBModel();
            }

            return dBModel;
        }
    }
}
