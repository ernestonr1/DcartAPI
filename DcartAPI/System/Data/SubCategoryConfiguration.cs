using DCartAPI.Models.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCartAPI.Data
{
    public class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategory>
    {
        //Populate a list of SubCategory
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasData(
                    new SubCategory
                    {
                        Id = 1,
                        Name = "Computers",
                        DateAdded = DateTime.UtcNow,
                        MainCategoryId = 1,
                        PosterImageUrl = "/Images/SubCategories/computers.png"
                    },

                    new SubCategory
                    {
                        Id = 2,
                        Name = "Tvs",
                        DateAdded = DateTime.UtcNow,
                        MainCategoryId = 1,
                        PosterImageUrl = "/Images/SubCategories/tv.png"
                    },

                    new SubCategory
                    {
                        Id = 3,
                        Name = "Chairs",
                        DateAdded = DateTime.UtcNow,
                        MainCategoryId = 2,
                        PosterImageUrl = "/Images/SubCategories/chair.png"
                    },

                     new SubCategory
                     {
                         Id = 4,
                         Name = "Tables",
                         DateAdded = DateTime.UtcNow,
                         MainCategoryId = 2,
                         PosterImageUrl = "/Images/SubCategories/table.png"
                     },

                      new SubCategory
                      {
                          Id = 5,
                          Name = "Action Figures",
                          DateAdded = DateTime.UtcNow,
                          MainCategoryId = 3,
                          PosterImageUrl = "/Images/SubCategories/toys.png"
                      },

                       new SubCategory
                       {
                           Id = 6,
                           Name = "Dolls",
                           DateAdded = DateTime.UtcNow,
                           MainCategoryId = 3,
                           PosterImageUrl = "/Images/SubCategories/dolls.png"
                       }
                );
        }
    }
}
