using _3.NewsBlog.EntityMap.Citys.Contracts;
using _3.NewsBlog.EntityMap.Citys.Contracts.Dto;
using Microsoft.AspNetCore.Mvc;

namespace News.Controllers;

[Route("cities")]
public class CityController : Controller
{
    private readonly CityService _service;

    public CityController(CityService service)
    {
        _service = service;
    }

    [HttpPost]
    public void Add([FromBody] AddCityDto dto)
    {
        _service.Add(dto);
    }

    [HttpGet]
    public List<GetAllCitiesDto> GetAll()
    {
        return
            _service.GetAll();
    }

    [HttpGet("news-included")]
    public List<CityNewsIncludedDto> GetAllWithNews(string? newsTitle)
    {
        return _service.GetAllWithNews(newsTitle);
    }
}