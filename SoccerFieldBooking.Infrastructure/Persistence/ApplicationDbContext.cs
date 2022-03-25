using Microsoft.EntityFrameworkCore;
using SoccerFieldBooking.Domain.Model;
using SoccerFieldBooking.Domain.Model.ScheduleAggregate;
using SoccerFieldBooking.Infrastructure.Persistence.EntityConfigurations;

namespace InventoryManagement.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<ContactPerson> Contacts { get; set; }
        public DbSet<Customer> Users { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public ApplicationDbContext()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //UseLazyLoadingProxies()  requires only the navigation properties be virtual
            //optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = SoccerFieldBooking; Trusted_Connection = True; ",options => options.MaxBatchSize(100));

            var connectionString = "Server = (localdb)\\mssqllocaldb; Database = SoccerFieldBooking; Trusted_Connection = True; ";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new ContactPersonConfiguration());
            modelBuilder.ApplyConfiguration(new FieldConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());
            modelBuilder.ApplyConfiguration(new ScheduleConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            //modelBuilder.ApplyConfiguration(new FieldSizeConfiguration());
        }
    }
}
