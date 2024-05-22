using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foy5.Model.Entity
{
    [Table("Ders")]
    public class tDers
    {
        [Key]
        public string dersID { get; set; }
        public string dersAd { get; set; }
    }
}
