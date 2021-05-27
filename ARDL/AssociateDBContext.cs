using Microsoft.EntityFrameworkCore;
using ARModels;
namespace ARDL
{
    public class AssociateDBContext : DbContext
    {
        // constructor needed to pass in connection string 
        public AssociateDBContext() : base()
        {

        }
        public AssociateDBContext(DbContextOptions options) : base(options)
        {

        }


        //Declaring entities 
        public DbSet<Associate> Associates { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Associate>()
            .Property(Associate => Associate.Id)
            .ValueGeneratedOnAdd();
            modelBuilder.Entity<Review>()
            .Property(review => review.Id)
            .ValueGeneratedOnAdd();
        }

    }
}