using DCartAPI.Models.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCartAPI.Data
{
    public class MainCategoryConfiguration : IEntityTypeConfiguration<MainCategory>
    {
        //Populate a list of mainCategory
        public void Configure(EntityTypeBuilder<MainCategory> builder)
        {
            builder.HasData(
                    new MainCategory
                    {
                        Id = 1,
                        Name = "Electronics",
                        DateAdded = DateTime.UtcNow,
                        PosterImageUrl = "Images/Categories/electronics.jpg"
                    },

                    new MainCategory
                    {
                        Id = 2,
                        Name = "Furnitures",
                        DateAdded = DateTime.UtcNow,
                        PosterImageUrl = "Images/Categories/furniture.jpg"
                    },

                    new MainCategory
                    {
                        Id = 3,
                        Name = "Toys",
                        DateAdded = DateTime.UtcNow,
                        PosterImageUrl = "Images/Categories/toys.jpg"
                    }
                );
        }
    }
}
