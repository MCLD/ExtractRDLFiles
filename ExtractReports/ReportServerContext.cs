namespace ExtractReports {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ReportServerContext : DbContext {
        public ReportServerContext()
            : base("name=ReportServerContext") {
        }

        public virtual DbSet<Catalog> Catalogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Catalog>()
                .HasMany(e => e.Catalog1)
                .WithOptional(e => e.Catalog2)
                .HasForeignKey(e => e.LinkSourceID);

            modelBuilder.Entity<Catalog>()
                .HasMany(e => e.Catalog11)
                .WithOptional(e => e.Catalog3)
                .HasForeignKey(e => e.ParentID);
        }
    }
}
