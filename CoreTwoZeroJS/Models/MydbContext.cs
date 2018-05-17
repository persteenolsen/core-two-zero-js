using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreTwoZeroJS.Models
{
    public partial class MydbContext : DbContext
    {


        public MydbContext(DbContextOptions<MydbContext> options) :
            base(options)
        {
        }

        public virtual DbSet<PersonTableCoreTwoJS> PersonTableCoreTwoJS { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                   // Here was conntectionstring info
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonTableCoreTwoJS>(entity =>
            {
                entity.Property(e => e.Age).HasMaxLength(50);

                entity.Property(e => e.Editable).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);


                // Add this to match the new Column in the MS SQL BD and the Model
                entity.Property(e => e.Profession).HasMaxLength(50);
            });
        }
    }
}
