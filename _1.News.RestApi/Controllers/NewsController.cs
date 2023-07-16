using _3.News.Services.News.Contracts;
using _3.News.Services.News.Contracts.Dto;
using Microsoft.AspNetCore.Mvc;

namespace News.Controllers;
[Route("news")]
public class NewsController : Controller
{
    private readonly NewsService _service;

    public NewsController(NewsService service)
    {
        _service = service;
    }


    [HttpPost]
    public void Add(AddNewsDto dto)
    {
        _service.Add(dto);
    }
    
    
}