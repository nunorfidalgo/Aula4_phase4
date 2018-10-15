namespace Aula4_phase4.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BDPiratas2 : DbContext
    {
        public BDPiratas2()
            : base("name=BDPiratas2")
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
