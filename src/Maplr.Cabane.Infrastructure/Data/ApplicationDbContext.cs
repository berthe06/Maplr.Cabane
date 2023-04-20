using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Maplr.Cabane.Core.Entities;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Maplr.Cabane.Core.ProjectAggregate;

namespace Maplr.Cabane.Infrastructure.Data;
public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext()
    {
    }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        Database.SetCommandTimeout(10000);
    }
    //public DbSet<log> Logs => Set<log>();
    public DbSet<ToDoItem> ToDoItems { get; set; }
    public DbSet<Project> Projects { get; set; }

    public DbSet<Panier> Paniers => Set<Panier>();
    public DbSet<LignePanier> LignePaniers => Set<LignePanier>();
    public DbSet<Sucre> Sucres => Set<Sucre>();
    public DbSet<Client> Users => Set<Client>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json")
           .Build();

        var connectionString = configuration.GetConnectionString("DefaultConnection");

        optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.DetachedLazyLoadingWarning))
                      .ConfigureWarnings(w => w.Ignore(CoreEventId.LazyLoadOnDisposedContextWarning))
                      .UseSqlServer(connectionString);
    }
    /*protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.Entity<LignePanier>().HasKey(e => new {e.panierId , e.sucreId});

        modelBuilder.Entity<Panier>().HasKey(e => e.clientId);

        modelBuilder.Entity<Sucre>().HasKey(e => e.typeSucreId);







    }*/

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

        return result;
    }

    public override int SaveChanges()
    {
        return SaveChangesAsync().GetAwaiter().GetResult();
    }
}
