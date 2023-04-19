using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ConsoleDataBase.Models;

namespace ConsoleDataBase.Configurations
{
    internal class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder
                .ToTable("Title")
                .HasKey(p => p.Id);
            builder
                .Property(p => p.Id)
                .HasColumnName("TitleId")
                .ValueGeneratedNever();
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .HasData(new[]
                {
                    new
                    {
                        Id = 1,
                        Name = "Mr."
                    },
                    new
                    {
                        Id = 2,
                        Name = "Ms."
                    },
                    new
                    {
                        Id = 3,
                        Name = "Mrs."
                    },
                    new
                    {
                        Id = 4,
                        Name = "Sr."
                    },
                    new
                    {
                        Id = 5,
                        Name = "Sra."
                    }
                });
        }
    }
}