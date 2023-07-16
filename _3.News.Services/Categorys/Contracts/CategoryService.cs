using _3.NewsBlog.EntityMap.Categorys.Contracts.Dto;

namespace _3.News.Services.Categorys.Contracts;

public interface CategoryService
{
    void Add(AddCategoryDto dto);
    List<GetAllCategoriesDto> GetAll();
}