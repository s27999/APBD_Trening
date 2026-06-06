using APBD_Trening1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_Trening1.Configurations;

public class PcComponentConfiguration :  IEntityTypeConfiguration<PCComponent>
{
    
    public void Configure(EntityTypeBuilder<PCComponent> builder)
    {
        //Dodawanie dwóch kluczy głównych
        builder.HasKey(p => new { p.PCId, p.ComponentComponentCode });
            
        builder.Property(p => p.ComponentComponentCode).HasColumnType("char(10)");
            
        //Dodawanie Foreign Keys
            
        //Ma jeden (Obiekt - PcComponent)
        builder.HasOne(p => p.Pc)
            //Obiekt ma wiele this Obiektów (ICollection<PC>)
            .WithMany(p => p.PcComponents)
            //Ustalanie Foreign Key
            .HasForeignKey(p => p.PCId)
            //Usuwanie Kaskadowe
            .OnDelete(DeleteBehavior.Cascade);
            
        builder.HasOne(p => p.Component)
            .WithMany(c => c.PcComponents)
            .HasForeignKey(c => c.ComponentComponentCode)
            .OnDelete(DeleteBehavior.Cascade);

        builder.ToTable("PCComponents");
    }
}