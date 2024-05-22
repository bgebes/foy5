using Foy5.Model.Entity;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Foy5
{
    public partial class DBModel : DbContext
    {
        public DbSet<tOgrenci> TOgrenciler { get; set; }
        public DbSet<tDers> TDersler { get; set; }
        public DbSet<tBolum> TBolumler { get; set; }
        public DbSet<tFakulte> TFakulteler { get; set; }
        public DbSet<tOgrenciDers> TOgrenciDersler { get; set; }

        public DBModel()
            : base("name=DBModel")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
