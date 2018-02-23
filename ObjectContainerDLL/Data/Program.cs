using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectContainerDLL;
//using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.Extensions.Configuration;
using ContosoUniversity.Data;

namespace ObjectContainerDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new HotelContext();
            DbInitializer.Initialize(db);
        }
    }
}
