using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace foy5
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<tBolum> tBolum { get; set; }
        public virtual DbSet<tDers> tDers { get; set; }
        public virtual DbSet<tFakulte> tFakulte { get; set; }
        public virtual DbSet<tOgrenci> tOgrenci { get; set; }
        public virtual DbSet<tOgrenciDers> tOgrenciDers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tBolum>()
                .Property(e => e.bolumAd)
                .IsUnicode(false);

            modelBuilder.Entity<tDers>()
                .Property(e => e.dersAd)
                .IsUnicode(false);

            modelBuilder.Entity<tFakulte>()
                .Property(e => e.fakulteAd)
                .IsUnicode(false);

            modelBuilder.Entity<tOgrenci>()
                .Property(e => e.ad)
                .IsUnicode(false);

            modelBuilder.Entity<tOgrenci>()
                .Property(e => e.soyad)
                .IsUnicode(false);

            modelBuilder.Entity<tOgrenci>()
                .HasMany(e => e.tOgrenciDers)
                .WithOptional(e => e.tOgrenci)
                .HasForeignKey(e => e.ogrenciID);

            modelBuilder.Entity<tOgrenciDers>()
                .Property(e => e.yariyil)
                .IsUnicode(false);
        }
    }
}
