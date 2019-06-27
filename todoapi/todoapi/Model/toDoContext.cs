using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace todoapi.Model
{
    public partial class toDoContext : DbContext
    {
        public toDoContext()
        {
        }

        public toDoContext(DbContextOptions<toDoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Task> Task { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:nzmsatodo.database.windows.net,1433;Initial Catalog=todoDb;Persist Security Info=False;User ID=atea;Password=Master123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Task>(entity =>
            {
                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.TaskName).IsUnicode(false);
            });
        }
    }
}
