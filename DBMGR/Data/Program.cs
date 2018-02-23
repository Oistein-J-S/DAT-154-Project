using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectContainerDLL;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.Extensions.Configuration;
using ContosoUniversity.Data;

namespace ObjectContainerDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelContext db = new HotelContext(new Microsoft.EntityFrameworkCore.DbContextOptions<HotelContext>());
            DbInitializer.Initialize(db);
        }
    }
}
