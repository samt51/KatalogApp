using KatalogApp.Domain.Entities;
using KatalogApp.Application.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KatalogApp.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasData(
                new Users 
                { 
                    Id = 1, 
                    Email = "kuyumhesap@gmail.com", 
                    Password = PasswordHash.HashPassword("123456"), 
                    PhoneNumber = "05363956979", 
                    FirstName = "Mahmut", 
                    LastName = "KavalcÄ±", 
                    CompanyName = "", 
                    Address = "", 
                    RoleId = 1, // SystemAdmin
                    CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), 
                    IsDeleted = false 
                },
                new Users 
                { 
                    Id = 2, 
                    Email = "admin@admin.com", 
                    Password = PasswordHash.HashPassword("123456"), 
                    PhoneNumber = "", 
                    FirstName = "Admin", 
                    LastName = "Admin", 
                    CompanyName = "", 
                    Address = "", 
                    RoleId = 2, // Admin
                    CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), 
                    IsDeleted = false 
                }
            );
        }
    }
}

