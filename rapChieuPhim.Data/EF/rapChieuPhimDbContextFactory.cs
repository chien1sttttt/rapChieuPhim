using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace rapChieuPhim.Data.EF
{
    public class rapChieuPhimDbContextFactory : IDesignTimeDbContextFactory<rapChieuPhimDbContext>
    {
        public rapChieuPhimDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("rapChieuPhimDb");

            var optionsBuilder = new DbContextOptionsBuilder<rapChieuPhimDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new rapChieuPhimDbContext(optionsBuilder.Options);
        }
    }
}
