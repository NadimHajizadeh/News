using _2.NewsBlog.Persistanse.Ef;
using _3.News.Services.Categorys.Contracts;
using _3.NewsBlog.EntityMap.Categorys.Contracts.Dto;
using Microsoft.EntityFrameworkCore;
namespace _2.News.Persistance.EF.Category;






public class EFCategoryRepasitory : CategoryRepasitory
{
    private readonly DbSet<_4.News.Entities.Category> _categories;

    public EFCategoryRepasitory(EFDataContext context)
    {
        _categories = context.Set<_4.News.Entities.Category>();
    }
    public void Add(_4.News.Entities.Category categor)
    {
        _categories.Add(categor);
    }

    public bool IsExist(string dtoName)
    {
        return 
        _categories.Any(_ => _.Name == dtoName);
    }

    public List<GetAllCategoriesDto> GetAll()
    {
        return

            _categories.Select(_ => new GetAllCategoriesDto
            {
                Id = _.Id,
                Name = _.Name
            }).ToList();
    }
}