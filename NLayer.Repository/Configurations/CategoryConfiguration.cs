using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x =>x.Id).UseIdentityColumn(); // otomatik olarak artan şekilde oluştur demek (içersine nasıl artmasını istediğimizi yazabiliriz. defoult olarak 1er artr.)
            builder.Property(x => x.CategoryName).IsRequired().HasMaxLength(50); // doldurulması zorunlu ve max 50 karakter.

        }
    }
}
