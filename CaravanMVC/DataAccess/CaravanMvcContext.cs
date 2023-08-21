using CaravanMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CaravanMVC.DataAccess
{
    public class CaravanMvcContext : DbContext
    {
		public DbSet<Wagon> Wagons { get; set; }
        public DbSet<Passenger> Passengers { get; set; }

        public CaravanMvcContext(DbContextOptions<CaravanMvcContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			Wagon oldFaithful = new Wagon { Id = 1, Name = "Old Faithful", NumWheels = 4, Covered = true };
			Wagon newModelWagon = new Wagon { Id = 2, Name = "New Model Wagon", NumWheels = 2, Covered = false };

			modelBuilder.Entity<Wagon>().HasData(
				oldFaithful,
				newModelWagon
			);

			modelBuilder.Entity<Passenger>().HasData(
				new Passenger { Id = 1, Name = "Prudence", Age = 34, Destination = "Oregon", WagonId = 1 },
				new Passenger { Id = 2, Name = "John", Age = 36, Destination = "Oregon", WagonId = 1 },
				new Passenger { Id = 3, Name = "Abigail", Age = 15, Destination = "Oregon", WagonId = 1 },
				new Passenger { Id = 4, Name = "John jr", Age = 6, Destination = "Oregon", WagonId = 1 },
				new Passenger { Id = 5, Name = "Seth", Age = 24, Destination = "Canada", WagonId = 2 },
				new Passenger { Id = 6, Name = "Joe", Age = 24, Destination = "Canada", WagonId = 2 }
			);
		}
	}
}
