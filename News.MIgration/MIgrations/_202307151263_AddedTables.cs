using FluentMigrator;
namespace News.MIgration.MIgrations;



[Migration(202307151455)]
public class _202307151455_AddedTables : Migration
{
    
    public override void Up()
    {
        AddCitiesTable();
        
        AddCategoriesTable();
        
        AddTagsTable();
        
        AddNewsTable();
        
        AddNewsTagTable();
        
        AddNewsCommentTable();
    }

   

    public override void Down()
    {
        Delete.Table("NewsComments");
        Delete.Table("NewsTags");
        Delete.Table("News");
        Delete.Table("Tags");
        Delete.Table("Categories");
        Delete.Table("Cities");
        
    }
     private void AddNewsCommentTable()
    {
        Create.Table("NewsComments")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("UserName").AsString(30).NotNullable()
            .WithColumn("IsAprroved").AsBoolean().NotNullable()
            .WithColumn("Text").AsString(999).NotNullable()
            .WithColumn("Date").AsDateTime().NotNullable()
            .WithColumn("NewsId").AsInt32().NotNullable()
            .ForeignKey("NewsComment", "News", "Id");
    }

    private void AddNewsTagTable()
    {
        Create.Table("NewsTags")
            .WithColumn("NewsId").AsInt32().PrimaryKey()
            .ForeignKey("FK_NewsTags_News", "News", "Id")
            .WithColumn("TagId").AsInt32().PrimaryKey()
            .ForeignKey("FK_NewsTags_Tags", "Tags", "Id");
    }

    private void AddNewsTable()
    {
        Create.Table("News")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("Title").AsString(30).NotNullable()
            .WithColumn("Text").AsString(1999).NotNullable()
            .WithColumn("Date").AsDateTime().NotNullable()
            .WithColumn("IsSlider").AsBoolean().NotNullable()
            .WithColumn("View").AsInt32().NotNullable()
            .WithColumn("CityId").AsInt32().NotNullable()
            .ForeignKey("FK_News_Cities", "Cities", "Id")
            .WithColumn("CategoryId").AsInt32().NotNullable()
            .ForeignKey("FK_News_Categories", "Categories", "Id");
    }

    private void AddTagsTable()
    {
        Create.Table("Tags")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("Name").AsString(30).NotNullable();
    }

    private void AddCategoriesTable()
    {
        Create.Table("Categories")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("Name").AsString(30).NotNullable();
    }

    private void AddCitiesTable()
    {
        Create.Table("Cities")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("Name").AsString(30).NotNullable();
    }
}