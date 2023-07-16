using _4.News.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _2.News.Persistance.EF.Tags;
public class TagEntityMap : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> _)
    {
        _.ToTable("Tags");
        _.HasKey("Id");
        _.Property(_ => _.Id)
            .ValueGeneratedOnAdd();
        _.Property(_ => _.Name)
            .IsRequired(true)
            .HasMaxLength(30);

    }
}