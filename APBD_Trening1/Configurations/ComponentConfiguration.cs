
using APBD_Trening1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_Trening1.Configurations;

//Musi dziedziczyć po IEntityTypeConfiguration
public class ComponentConfiguration : IEntityTypeConfiguration<Component>
{
    public void Configure(EntityTypeBuilder<Component> builder)
    {
        builder.ToTable("Components");
        builder.HasKey(c => c.Code);
        builder.Property(c => c.Code).HasColumnType("char(10)");
        builder.Property(c => c.Name).HasColumnType("varchar(300)");
        
        
        //Mamy w naszej klasie jeden ComponentType, który w swojej klasie ma wiele component types
        builder.HasOne(c => c.ComponentType)
            .WithMany(t => t.Components)
            .HasForeignKey(t => t.ComponentTypeId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasOne(c => c.ComponentManufacturer)
            .WithMany(t => t.Components)
            .HasForeignKey(t => t.ComponentManufacturerId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}