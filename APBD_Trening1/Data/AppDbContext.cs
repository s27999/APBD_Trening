using APBD_Trening1.Entities;
using Microsoft.EntityFrameworkCore;

namespace APBD_Trening1.Data;

public class AppDbContext : DbContext
{
    protected AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Component> Components { get; set; }
    public DbSet<ComponentType> ComponentTypes { get; set; }
    public DbSet<PCComponent> PCComponents { get; set; }
    public DbSet<ComponentManufacturer> ComponentManufacturers { get; set; }
    public DbSet<PC> PCs { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Dodawanie konfiguracji - automatycznie bierze wszystkie konfiguracje
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly); 
        
        base.OnModelCreating(modelBuilder);
    }
}