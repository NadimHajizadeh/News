using _3.News.Services.Tags.Contracts;
using _3.News.Services.Tags.Contracts.Dto;
using Microsoft.AspNetCore.Mvc;

namespace News.Controllers;

[Route("tags")]
public class TagController : Controller
{
    private readonly TagService _service;

    public TagController(TagService service)
    {
        _service = service;
    }

    [HttpPost]
    public void Add([FromBody] AddTagDto dto)
    {
        _service.Add(dto);
    }

    [HttpDelete("{id}")]
    public void Delete([FromRoute] int id)

    {
        _service.Delete(id);
    }
}