using _3.News.Services.Categorys.Contracts;
using _3.News.Services.Categorys.Exeptions;
using _3.NewsBlog.EntityMap.Categorys;
using _3.NewsBlog.EntityMap.Categorys.Contracts.Dto;
using _3.NewsBlog.EntityMap.Contracts;
using _4.News.Entities;

namespace _3.News.Services.Categorys;

public class CategoryAppService : CategoryService
{
    private readonly UnitOfWork _unitOfWork;
    private readonly CategoryRepasitory _repasitory;

    public CategoryAppService(UnitOfWork unitOfWork , CategoryRepasitory repasitory
        )
    {
        _unitOfWork = unitOfWork;
        _repasitory = repasitory;
    }
    public void Add(AddCategoryDto dto)
    {

        var IsExisted = _repasitory.IsExist(dto.Name);
        if (IsExisted)
        {
            throw new CategoryAlredyExistedExeption();
        }
        
        var category = new Category()
        {
            Name = dto.Name,

        };
        _repasitory.Add(category);
        _unitOfWork.Complete();
        
    }

    public List<GetAllCategoriesDto> GetAll()
    {
        return
            _repasitory.GetAll();
    }
}