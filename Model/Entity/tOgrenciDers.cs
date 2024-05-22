using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foy5.Model.Entity
{
    [Table("OgrenciDers")]
    public class tOgrenciDers
    {
        [Key]
        public string ogrenciDersID { get; set; }
        [ForeignKey("ogrenciID")]
        public virtual tOgrenci ogrenci { get; set; }
        public string ogrenciID { get; set; }

        [ForeignKey("dersID")]
        public virtual tDers ders { get; set; }
        public string dersID { get; set; }
        public string yil { get; set; }     
        public string yariyil { get; set; }
        public double vize { get; set; }
        public double final { get; set; }    
    }
}
