using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                ProductName = "Kalem1",
                CategoryId = 1,
                Price =100,
                Stock=20,
                CreatedDate = DateTime.Now,

            },
            new Product
            {
                Id = 2,
                ProductName = "Kalem2",
                CategoryId = 1,
                Price = 300,
                Stock = 60,
                CreatedDate = DateTime.Now,

            },
            new Product
            {
                Id = 3,
                ProductName = "Kalem3",
                CategoryId = 1,
                Price = 700,
                Stock = 56,
                CreatedDate = DateTime.Now,

            },
            new Product
            {
                Id = 4,
                ProductName = "Kitap1",
                CategoryId = 2,
                Price = 160,
                Stock = 27,
                CreatedDate = DateTime.Now,

            },
            new Product
            {
                Id = 5,
                ProductName = "Kitap2",
                CategoryId = 2,
                Price = 450,
                Stock = 55,
                CreatedDate = DateTime.Now,

            });
        }
    }
}
