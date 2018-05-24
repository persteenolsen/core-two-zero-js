using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreTwoZeroJS.Models
{

    // This Model are mapping the database columns into the model "PersonTableCoreTwoJS" to be used by controllers
    public partial class MydbContext : DbContext
    {

        // Contructor wich take an argument from the Startup file where an instance of "MydbContext" are made
        public MydbContext(DbContextOptions<MydbContext> options) :
            base(options)
        {
        }

        // Mapping the MS SQL Database to corresponding Model "PersonTableCoreTwoJS" using get and set methods
        public virtual DbSet<PersonTableCoreTwoJS> PersonTableCoreTwoJS { get; set; }


        // This method are called by configuration and had the SQL connection String but I moved that to the Startup
        // file wich I did not include in the repo using gitignore
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                   // Here was conntectionstring info
            }
        }

        // The model "PersonTableCoreTwo" are mapped with entities representing the columns in the database
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
