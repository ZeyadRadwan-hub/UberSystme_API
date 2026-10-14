using Microsoft.EntityFrameworkCore;
using UberSystem.Models;

namespace UberSystem.Data
{
    public class App_Database_Context:DbContext
    {
        public App_Database_Context(DbContextOptions<App_Database_Context> options) : base(options) { }

        public DbSet<Ride> Rides { get; set; }
        public DbSet<Userr> Userrs { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Ride>()
                .HasOne(x=>x.UserRider)
                .WithMany(x=>x.RiderRides)
                .HasForeignKey(x=>x.RiderId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Ride>()
                .HasOne(x => x.UserDriver)
                .WithMany(x => x.DriverRides)
                .HasForeignKey(x => x.DriverId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Userr>()
                .HasOne(x => x.Vehicle)
                .WithOne(x => x.Driver)
                .HasForeignKey<Vehicle>(x => x.DriverId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Ride>()
                .HasOne(x=>x.Payment)
                .WithOne(x=>x.Ride)
                .HasForeignKey<Payment>(x=>x.RideId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Ride>()
               .HasOne(x => x.Rating)
               .WithOne(x => x.Ride)
               .HasForeignKey<Rating>(x => x.RideId)
               .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
