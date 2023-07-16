using _4.News.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _2.News.Persistance.EF.NewsTags;

public class NewsTagsEntityMap : IEntityTypeConfiguration<NewsTag>
{
    public void Configure(EntityTypeBuilder<NewsTag> _)
    {
        _.ToTable("NewsTags");
        _.HasKey(_ => new
        {
            _.NewsId,
            _.TagId
        });


        _.HasOne(_ => _.News)
            .WithMany(_ => _.NewsTags)
            .HasForeignKey(_ => _.NewsId);
        _.HasOne(_=>_.Tag)
            .WithMany(_=>_.NewsTags)
            .HasForeignKey(_ => _.TagId);

    }
}