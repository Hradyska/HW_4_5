using ConsoleDataBase.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ConsoleDataBase.Configurations
{
    internal class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder
                .ToTable("Client")
                .HasKey(p => p.Id);
            builder
                .Property(p => p.Id)
                .HasColumnName("ClientId")
                .ValueGeneratedNever();
            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(p => p.Address)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(p => p.EMail)
                .IsRequired()
                .HasMaxLength(20);
            builder
                .Property(p => p.PhoneNumber)
                .IsRequired()
                .HasMaxLength(20);
            builder
                .HasData(new[]
                {
                    new
                    {
                        Id = 1,
                        Name = "Aurora",
                        Address = "NY",
                        EMail = "aurora@gmail.com",
                        PhoneNumber = "+1-555-33-22"
                    },
                    new
                    {
                        Id = 2,
                        Name = "Ocean LTD",
                        Address = "Florida",
                        EMail = "oltd@gmail.com",
                        PhoneNumber = "+1-777-33-22"
                    },
                    new
                    {
                        Id = 3,
                        Name = "Artemida",
                        Address = "LA",
                        EMail = "artemida@gmail.com",
                        PhoneNumber = "+1-333-33-11"
                    },
                    new
                    {
                        Id = 4,
                        Name = "Unicorn",
                        Address = "NY",
                        EMail = "unicorn@gmail.com",
                        PhoneNumber = "+1-444-33-11"
                    },
                    new
                    {
                        Id = 5,
                        Name = "Pleiades",
                        Address = "LA",
                        EMail = "Pleiades@gmail.com",
                        PhoneNumber = "+1-888-33-11"
                    }
                });
        }
    }
}