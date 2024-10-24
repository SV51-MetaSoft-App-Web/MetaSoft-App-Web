using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using MetaSoftAppWeb.API.ClientManagement.Domain.Model.Commands;
using MetaSoftAppWeb.API.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions.Extensions;
using Microsoft.EntityFrameworkCore;

namespace MetaSoftAppWeb.API.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.AddCreatedUpdatedInterceptor();
        base.OnConfiguring(builder);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Clients>().ToTable("Clients");
        builder.Entity<Clients>().HasKey(f => f.Id);
        builder.Entity<Clients>().Property(f => f.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Clients>().Property(f => f.PersonName).IsRequired().HasMaxLength(100);
        builder.Entity<Clients>().Property(f => f.Dni).IsRequired().HasMaxLength(20);
        builder.Entity<Clients>().Property(f => f.Email).IsRequired().HasMaxLength(100);
        builder.Entity<Clients>().Property(f => f.BusinessName).IsRequired().HasMaxLength(100);
        builder.Entity<Clients>().Property(f => f.Phone).IsRequired().HasMaxLength(20);
        builder.Entity<Clients>().Property(f => f.Address).IsRequired().HasMaxLength(100);
        builder.Entity<Clients>().Property(f => f.Country).IsRequired().HasMaxLength(100);
        builder.Entity<Clients>().Property(f => f.City).IsRequired().HasMaxLength(100);
        builder.Entity<Clients>().Property(f => f.Ruc).IsRequired().HasMaxLength(20);

        builder.UseSnakeCaseNamingConvention();
    }
}