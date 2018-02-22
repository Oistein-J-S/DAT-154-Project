using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions;
using Microsoft.Extensions.DependencyInjection;
using ObjectContainerDLL;

namespace ObjectContainerDLL
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Standard> StandardRooms { get; set; }
        public DbSet<Suite> SuiteRooms { get; set; }
        public DbSet<Superior> SuperiorRooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().ToTable("Room");
            modelBuilder.Entity<Booking>().ToTable("Booking");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Hotel>().ToTable("Hotel");
            modelBuilder.Entity<Issue>().ToTable("Issue");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Standard>().ToTable("Standard");
            modelBuilder.Entity<Suite>().ToTable("Suite");
            modelBuilder.Entity<Superior>().ToTable("Superior");
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<HotelContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("dat154vaar18")));

            services.AddMvc();
        }
    }
}