using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ObjectContainerDLL;

namespace ObjectContainerDLL
{
    public partial class HotelContext : DbContext
    {
        private IConfigurationRoot configuration;
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {

        }

        public HotelContext()
        {
            var builder = new ConfigurationBuilder().SetBasePath(System.AppContext.BaseDirectory).AddJsonFile("appsettings.json", false, true);
            configuration = builder.Build();
        }

        public HotelContext Create(DbContextFactoryOptions options)
        {
            var optionsBuilder = new DbContextOptionsBuilder<HotelContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("hoteldb"), m => { m.EnableRetryOnFailure(); });

            return new HotelContext(optionsBuilder.Options);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:dat154.database.windows.net,1433;Initial Catalog=dat154hotel;Persist Security Info=False;User ID=dat154vaar18;Password=TheCakeIsALie1337;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
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
        public DbSet<Item> Items { get; set; }
    }
}