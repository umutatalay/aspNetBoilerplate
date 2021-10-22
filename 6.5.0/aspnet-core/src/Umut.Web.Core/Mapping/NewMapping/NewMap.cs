using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umut.News;

namespace Umut.Mapping.NewMapping
{
    public class NewMap : IEntityTypeConfiguration<New>
    {
        public void Configure(EntityTypeBuilder<New> builder)
        {
            builder.ToTable("News");
            builder.Property(map => map.Title).HasColumnName("HaberBaslik");
            builder.Property(map => map.Summary).HasColumnName("HaberKisaIcerik");
            builder.Property(map => map.Content).HasColumnName("HaberIcerik");
            
            
            builder.Property(map => map.InNewImage).HasColumnName("HaberResim");
            builder.Property(map => map.InNewContentHtml).HasColumnName("HaberIcerikHtml");
            builder.Property(map => map.InNewContentQuill).HasColumnName("HaberIcerikQuill");
            
        }
    }
}
