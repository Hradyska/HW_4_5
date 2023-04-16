using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ConsoleDataBase.Models;

namespace ConsoleDataBase.Configurations
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder
                .ToTable("Office")
                .HasKey(p => p.Id);
            builder
                .Property(p => p.Id)
                .HasColumnName("OfficeId")
                .ValueGeneratedNever();
            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(p => p.Location)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .HasData(new[]
                {
                    new
                    {
                        Id = 1,
                        Title = "Main",
                        Location = "NY"
                    },
                    new
                    {
                        Id = 2,
                        Title = "Office1",
                        Location = "LA"
                    },
                    new
                    {
                        Id = 3,
                        Title = "Office2",
                        Location = "Boston"
                    },
                    new
                    {
                        Id = 4,
                        Title = "Office3",
                        Location = "Ostin"
                    },
                    new
                    {
                        Id = 5,
                        Title = "Office4",
                        Location = "Portland"
                    },
                });
        }
    }
}