using _3.News.Services.Categorys.Contracts;
using _3.NewsBlog.EntityMap.Categorys;
using _3.NewsBlog.EntityMap.Categorys.Contracts.Dto;
using Microsoft.AspNetCore.Mvc;

namespace News.Controllers;


[Route("categories")]
public class CategoryController : Controller
{
    private readonly CategoryService _service;

    public CategoryController([FromBody]CategoryService service)
    {
        _service = service;
    }

    [HttpPost]
    public void Add(AddCategoryDto dto)
    {
        _service.Add(dto);
    }
    
    [HttpGet]
    public List<GetAllCategoriesDto> GetAll()
    {
        return

            _service.GetAll();

    }
    
}

