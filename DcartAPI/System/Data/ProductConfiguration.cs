using DCartAPI.Models.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text;

namespace DCartAPI.Data
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        //Populate a list of Products
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(

                   new Product
                   {
                       Id = 1,
                       ProductName = "Dell XPS",
                       ProductPrice = 17567M,
                       DateAdded = DateTime.UtcNow,
                       QuantityInStock = 23,
                       SubCategoryId = 1,
                       PosterImageUrl = "Images/Products/dellxps.png",
                       IsFeatured = true,
                   },
                    new Product
                    {
                        Id = 2,
                        ProductName = "Microsoft Surface",
                        ProductPrice = 23890M,
                        DateAdded = DateTime.UtcNow,
                        QuantityInStock = 12,
                        SubCategoryId = 1,
                        PosterImageUrl = "Images/Products/microsoft-surface.png",
                        IsFeatured= true,
                    },

                     new Product
                     {
                         Id = 3,
                         ProductName = "Panasonic 4k TV",
                         ProductPrice = 29349M,
                         DateAdded = DateTime.UtcNow,
                         QuantityInStock = 6,
                         SubCategoryId = 2,
                         PosterImageUrl = "Images/Products/panasonic-tv.png",
                         IsFeatured=true,
                     },

                      new Product
                      {
                          Id = 4,
                          ProductName = "Sony LCD TV",
                          ProductPrice = 18945M,
                          DateAdded = DateTime.UtcNow,
                          QuantityInStock = 13,
                          SubCategoryId = 2,
                          PosterImageUrl = "Images/Products/sony-lcd-tv.png",
                          IsFeatured = true,
                      },


                    new Product
                    {
                        Id = 5,
                        ProductName = "Ikea Chair",
                        ProductPrice = 129M,
                        DateAdded = DateTime.UtcNow,
                        QuantityInStock = 239,
                        SubCategoryId = 3,
                        PosterImageUrl = "Images/Products/ikea-chair.png"
                    },

                     new Product
                     {
                         Id = 6,
                         ProductName = "Ikea Soft Chair",
                         ProductPrice = 429M,
                         DateAdded = DateTime.UtcNow,
                         QuantityInStock = 64,
                         SubCategoryId = 3,
                         PosterImageUrl = "Images/Products/ikea-soft-chair.png"
                     },


                    new Product
                    {
                        Id = 7,
                        ProductName = "Ikea Table",
                        ProductPrice = 349M,
                        DateAdded = DateTime.UtcNow,
                        QuantityInStock = 123,
                        SubCategoryId = 4,
                        PosterImageUrl = "Images/Products/ikea-table.png",
                        IsFeatured = true,
                    },
                    new Product
                    {
                        Id = 8,
                        ProductName = "Ikea Glass Table",
                        ProductPrice = 439M,
                        DateAdded = DateTime.UtcNow,
                        QuantityInStock = 123,
                        SubCategoryId = 4,
                        PosterImageUrl = "Images/Products/ikea-glass-table.png"
                    },


                    new Product
                    {
                        Id = 9,
                        ProductName = "Action Figure",
                        ProductPrice = 599M,
                        DateAdded = DateTime.UtcNow,
                        QuantityInStock = 38,
                        SubCategoryId = 5,
                        PosterImageUrl = "Images/Products/action-figure.png"
                    },

                    new Product
                    {
                        Id = 10,
                        ProductName = "Ikea Table",
                        ProductPrice = 349M,
                        DateAdded = DateTime.UtcNow,
                        QuantityInStock = 12,
                        SubCategoryId = 5,
                        PosterImageUrl = "Images/Products/toy-story-collection.png"
                    },


                    new Product
                    {
                        Id = 11,
                        ProductName = "Dolly The Doll",
                        ProductPrice = 659M,
                        DateAdded = DateTime.UtcNow,
                        QuantityInStock = 457,
                        SubCategoryId = 6,
                        PosterImageUrl = "Images/Products/doll.png"
                    },

                    new Product
                    {
                        Id = 12,
                        ProductName = "Toy Story Doll",
                        ProductPrice = 189M,
                        DateAdded = DateTime.UtcNow,
                        QuantityInStock = 21,
                        SubCategoryId = 6,
                        PosterImageUrl = "Images/Products/toy-story-doll.png",
                        IsFeatured = true
                    }
                );
        }
    }
}
