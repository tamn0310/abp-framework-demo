using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.EntityFrameworkCore
{
    public class ProductServiceDbContextFactory : IDesignTimeDbContextFactory<ProductServiceDbContext>
    {
        public ProductServiceDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ProductServiceDbContext>()
                .UseSqlServer(GetConnectionStringFromConfiguration());
            return new ProductServiceDbContext(builder.Options);
        }

        private static string GetConnectionStringFromConfiguration()
        {
            return BuildConfiguration()
                .GetConnectionString(ProductServiceDbProperties.ConnectionStringName);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(
                    Path.Combine(
                        Directory.GetCurrentDirectory(),
                        $"..{Path.DirectorySeparatorChar}ProductService.HttpApi.Host"
                    )
                )
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
