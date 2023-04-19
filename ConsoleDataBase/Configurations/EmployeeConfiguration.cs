using ConsoleDataBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ConsoleDataBase.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .ToTable("Employee")
                .HasKey(p => p.Id);
            builder
                .Property(p => p.Id)
                .HasColumnName("EmployeeId")
                .ValueGeneratedNever();
            builder
                .Property(p => p.DateOfBirth)
                .HasColumnType("date")
                .IsRequired(false);
            builder.Property(p => p.FirstName)
               .IsRequired()
               .HasMaxLength(50);
            builder.Property(p => p.LastName)
               .IsRequired()
               .HasMaxLength(50);
            builder
                .HasData(new[]
                {
                    new
                    {
                        Id = 1,
                        FirstName = "Neil",
                        LastName = "Armstrong",
                        DateOfBirth = DateTime.Parse("12.11.1989"),
                        HiredDate = DateTime.Parse("13.04.2023"),
                        OfficeId = 1,
                        TitleId = 4
                    },
                    new
                    {
                        Id = 2,
                        FirstName = "Buzz",
                        LastName = "Aldrin",
                        DateOfBirth = DateTime.Parse("09.03.1998"),
                        HiredDate = DateTime.Parse("13.04.2023"),
                        OfficeId = 1,
                        TitleId = 4
                    },
                    new
                    {
                        Id = 3,
                        FirstName = "Catherine",
                        LastName = "Coleman",
                        DateOfBirth = DateTime.Parse("07.02.1996"),
                        HiredDate = DateTime.Parse("12.03.2023"),
                        OfficeId = 2,
                        TitleId = 3
                    },
                    new
                    {
                        Id = 4,
                        FirstName = "Michael",
                        LastName = "Collins",
                        DateOfBirth = DateTime.Parse("07.02.1996"),
                        HiredDate = DateTime.Parse("23.01.2023"),
                        OfficeId = 1,
                        TitleId = 1
                    },
                    new
                    {
                        Id = 5,
                        FirstName = "Ellen",
                        LastName = "Baker",
                        DateOfBirth = DateTime.Parse("07.02.1996"),
                        HiredDate = DateTime.Parse("12.03.2023"),
                        OfficeId = 2,
                        TitleId = 5
                    },
                });
        }
    }
}
