using APBD_Trening1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_Trening1.Configurations;

public class ComponentManufacturersConfiguration : IEntityTypeConfiguration<ComponentManufacturer>
{
    public void Configure(EntityTypeBuilder<ComponentManufacturer> builder)
    {
        builder.ToTable("ComponentManufacturers");
        builder.HasKey(x => x.Id);
        builder.Property(c => c.Abbreviation).HasMaxLength(30);
        builder.Property(c => c.FullName).HasMaxLength(300);
        builder.Property(c => c.FoundationDate).HasColumnType("date");
    }
}