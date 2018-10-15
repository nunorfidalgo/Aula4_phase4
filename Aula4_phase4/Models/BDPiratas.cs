namespace Aula4_phase4.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BDPiratas : DbContext
    {
        public BDPiratas()
            : base("name=BDPiratas")
        {
        }

        public virtual DbSet<Table> Table { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>()
                .Property(e => e.UserName)
                .IsFixedLength();
        }
    }
}
