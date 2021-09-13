using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NerdStore.Catalog.Domain;

namespace NerdStore.Catalog.Data.Mappings
{
    class ProdutoMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(x => x.Description)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(x => x.ImageUrl)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.OwnsOne(x => x.Dimensions, xm =>
             {
                 xm.Property(p => p.Height).HasColumnName("Height").HasColumnType("int");

                 xm.Property(p => p.Width).HasColumnName("Width").HasColumnType("int");

                 xm.Property(p => p.Depth).HasColumnName("Depth").HasColumnType("int");
             });

            builder.ToTable("Produtos");
        }
    }
}
