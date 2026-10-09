using Microsoft.EntityFrameworkCore;
using LennujaamDBTask.Models;

namespace LennujaamDBTask.Data
{
    public class AirportDbContext : DbContext
    {
        public AirportDbContext()
        {
        }

        public AirportDbContext(DbContextOptions<AirportDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AirportDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        public DbSet<Airline> Airlines { get; set; }
        public DbSet<AircraftSize> AircraftSizes { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<Terminal> Terminals { get; set; }
        public DbSet<Gate> Gates { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<FlightStatus> FlightStatuses { get; set; }
        public DbSet<FlightStatusChange> FlightStatusChanges { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<FlightRegistration> FlightRegistrations { get; set; }
        public DbSet<BaggageType> BaggageTypes { get; set; }
        public DbSet<Baggage> Baggages { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Flight>()
                .HasOne(f => f.OriginAirport)
                .WithMany(a => a.OriginFlights)
                .HasForeignKey(f => f.OriginAirportId);

            modelBuilder.Entity<Flight>()
                .HasOne(f => f.DestinationAirport)
                .WithMany(a => a.DestinationFlights)
                .HasForeignKey(f => f.DestinationAirportId);

            foreach (var fk in modelBuilder.Model.GetEntityTypes().SelectMany(t => t.GetForeignKeys()))
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}