using APBD_Trening1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_Trening1.Configurations;

public class ComponentTypeConfiguration : IEntityTypeConfiguration<ComponentType>
{
    public void Configure(EntityTypeBuilder<ComponentType> builder)
    {
        builder.ToTable("ComponentTypes");
        builder.HasKey(x => x.Id);
        builder.Property(c => c.Abbreviation).HasMaxLength(30);
        builder.Property(c => c.Name).HasMaxLength(150);
    }
}