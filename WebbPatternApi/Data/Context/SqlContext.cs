using Microsoft.EntityFrameworkCore;
using WebbPatternApi.Entities;

namespace CodePatternApi.Data.Context;

public class SqlContext : DbContext
{
    public SqlContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<ShoeProductEntity> Shoes { get; set; }
    public DbSet<TshirtProductEntity> Tshirts { get; set; }
    public DbSet<WatchProductEntity> Watches { get; set; }
}
