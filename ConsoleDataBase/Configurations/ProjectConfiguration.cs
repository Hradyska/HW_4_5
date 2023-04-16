using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ConsoleDataBase.Models;

namespace ConsoleDataBase.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder
                .ToTable("Project")
                .HasKey(p => p.Id);
            builder
                .Property(p => p.Id)
                .HasColumnName("ProjectId")
                .ValueGeneratedNever();
            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(p => p.Budget)
                .HasColumnType("money");
            builder
                .HasData(new[]
                {
                    new
                    {
                        Id = 1,
                        Name = "Project1",
                        Budget = 100000m,
                        StartedDate = DateTime.Parse("02.04.2023"),
                        ClientId = 1
                    },
                    new
                    {
                        Id = 2,
                        Name = "Project2",
                        Budget = 200000m,
                        StartedDate = DateTime.Parse("15.03.2023"),
                        ClientId = 2
                    },
                    new
                    {
                        Id = 3,
                        Name = "Project3",
                        Budget = 105000m,
                        StartedDate = DateTime.Parse("21.02.2023"),
                        ClientId = 3
                    },
                    new
                    {
                        Id = 4,
                        Name = "Project4",
                        Budget = 300000m,
                        StartedDate = DateTime.Parse("10.04.2023"),
                        ClientId = 4
                    },
                    new
                    {
                        Id = 5,
                        Name = "Project5",
                        Budget = 400000m,
                        StartedDate = DateTime.Parse("14.04.2023"),
                        ClientId = 5
                    }
                });
        }
    }
}
