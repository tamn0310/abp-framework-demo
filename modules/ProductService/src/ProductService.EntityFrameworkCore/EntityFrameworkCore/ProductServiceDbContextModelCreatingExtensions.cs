using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ProductService.EntityFrameworkCore;

public static class ProductServiceDbContextModelCreatingExtensions
{
    public static void ConfigureProductService(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.Entity<Product>(b =>
        {
            b.ToTable(ProductServiceDbProperties.DbTablePrefix + "Products", ProductServiceDbProperties.DbSchema);

            b.ConfigureByConvention();
        });
    }
}
