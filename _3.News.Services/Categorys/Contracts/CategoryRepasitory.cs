using _3.NewsBlog.EntityMap.Categorys.Contracts.Dto;
using _4.News.Entities;

namespace _3.News.Services.Categorys.Contracts;

public interface CategoryRepasitory
{
    public void Add(Category categor);
    bool IsExist(string dtoName);
    List<GetAllCategoriesDto> GetAll();
}