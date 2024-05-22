using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foy5.Model.Entity
{
    [Table("Fakulte")]
    public class tFakulte
    {
        [Key]
        public string fakulteID { get; set; }
        public string fakulteAd { get; set; }
    }
}
