using APBD_Trening1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_Trening1.Configurations;

public class PcConfiguration : IEntityTypeConfiguration<PC>
{
    public void Configure(EntityTypeBuilder<PC> builder)
    {
        //Definiowanie właściwości encji

        //Klucz główny
        builder.HasKey(pc => pc.Id);
        
        //Properties
        builder.Property(p => p.Name).HasMaxLength(50);
        builder.Property(p => p.Weight).HasColumnType("float(5)");
        
        //Nazywamy tabelę
        builder.ToTable("PCs");

        //Dodajemy dane do tabeli
        builder.HasData(
            new PC { 
                Id = 1, 
                Name = "PC", 
                Weight = 15.5f, 
                Warranty = 24, 
                CreatedAt = new DateTime(2026, 5, 20, 10, 0, 0), 
                Stock = 2 
            },
            new PC { 
                Id = 2, 
                Name = "PC Pro", 
                Weight = 18.2f, 
                Warranty = 36, 
                CreatedAt = new DateTime(2026, 5, 18, 14, 30, 0), 
                Stock = 1 
            },
            new PC { 
                Id = 3, 
                Name = "PC Pro Max", 
                Weight = 12.0f, 
                Warranty = 12, 
                CreatedAt = new DateTime(2026, 4, 10, 9, 15, 0), 
                Stock = 5 
            }
        );
    }
}