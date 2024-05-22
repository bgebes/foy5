using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foy5.Model.Entity
{
    [Table("Bolum")]
    public class tBolum
    {
        [Key]
        public string bolumID {  get; set; }
        public string bolumAd {  get; set; }
        [ForeignKey("fakulteID")]
        public virtual tFakulte fakulte { get; set; }
        public string fakulteID { get; set; }
    }
}
