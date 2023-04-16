using ConsoleDataBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ConsoleDataBase.Configurations
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder
                .ToTable("EmployeeProject")
                .HasKey(p => p.Id);
            builder
                .Property(p => p.Id)
                .HasColumnName("EmployeeProjectId")
                .ValueGeneratedNever();
            builder
                .Property(p => p.Rate)
               .HasColumnType("money");
            builder
                .HasData(new[]
                {
                    new
                    {
                        Id = 1,
                        Rate = 1200m,
                        EmployeeId = 1,
                        ProjectId = 1,
                        StartedDate = DateTime.Parse("02.04.2023")
                    },
                    new
                    {
                        Id = 2,
                        Rate = 2000m,
                        EmployeeId = 2,
                        ProjectId = 1,
                        StartedDate = DateTime.Parse("02.04.2023")
                    },
                    new
                    {
                        Id = 3,
                        Rate = 2200m,
                        EmployeeId = 3,
                        ProjectId = 2,
                        StartedDate = DateTime.Parse("15.03.2023")
                    },
                    new
                    {
                        Id = 4,
                        Rate = 3000m,
                        EmployeeId = 4,
                        ProjectId = 2,
                        StartedDate = DateTime.Parse("15.03.2023")
                    },
                    new
                    {
                        Id = 5,
                        Rate = 3500m,
                        EmployeeId = 5,
                        ProjectId = 3,
                        StartedDate = DateTime.Parse("21.02.2023")
                    },
                    new
                    {
                        Id = 6,
                        Rate = 3500m,
                        EmployeeId = 1,
                        ProjectId = 4,
                        StartedDate = DateTime.Parse("10.04.2023")
                    },
                    new
                    {
                        Id = 7,
                        Rate = 3500m,
                        EmployeeId = 2,
                        ProjectId = 4,
                        StartedDate = DateTime.Parse("10.04.2023")
                    },
                    new
                    {
                        Id = 8,
                        Rate = 3500m,
                        EmployeeId = 3,
                        ProjectId = 5,
                        StartedDate = DateTime.Parse("14.04.2023")
                    },
                    new
                    {
                        Id = 9,
                        Rate = 3500m,
                        EmployeeId = 4,
                        ProjectId = 5,
                        StartedDate = DateTime.Parse("14.04.2023")
                    }
                });
        }
    }
}
