using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace ObjectContainerDLL
{
    public partial class HotelContext : DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:dat154.database.windows.net,1433;Initial Catalog=dat154vaar18;Persist Security Info=False;User ID=dat154vaar18;Password=TheCakeIsALie1337;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }


        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Hotel> Hotel { get; set; }
        public virtual DbSet<Issue> Issues { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Standard> StandardRooms { get; set; }
        public virtual DbSet<Suite> SuiteRooms { get; set; }
        public virtual DbSet<Superior> SuperiorRooms { get; set; }
        public virtual DbSet<Item> Items { get; set; }
    }
}