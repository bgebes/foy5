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
    [Table("Ogrenci")]
    public class tOgrenci
    {
        [Key]
        public string ogrenciID { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        [ForeignKey("bolumID")]
        public virtual tBolum bolum { get; set; }
        public string bolumID { get; set; }
    }
}
