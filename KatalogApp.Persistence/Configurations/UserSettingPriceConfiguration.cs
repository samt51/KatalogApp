using KatalogApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KatalogApp.Persistence.Configurations
{
    public class UserSettingPriceConfiguration : IEntityTypeConfiguration<UserSettingPrice>
    {
        public void Configure(EntityTypeBuilder<UserSettingPrice> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User).WithMany(x => x.UserSettingPrices).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.StoneSetting).WithMany().HasForeignKey(x => x.StoneSettingId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}