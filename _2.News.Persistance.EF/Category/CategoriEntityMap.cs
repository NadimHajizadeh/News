using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _2.News.Persistance.EF.Category;

public class CategoryEntityMap : IEntityTypeConfiguration<_4.News.Entities.Category>
{
    public void Configure(EntityTypeBuilder<_4.News.Entities.Category> _)
    {
        _.ToTable("Categories");
        _.HasKey("Id");
        _.Property(_ => _.Id)
            .ValueGeneratedOnAdd();
        _.Property(_ => _.Name)
            .IsRequired(true)
            .HasMaxLength(30);
        
    }
}