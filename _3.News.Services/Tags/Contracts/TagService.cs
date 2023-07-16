using _3.News.Services.Tags.Contracts.Dto;

namespace _3.News.Services.Tags.Contracts;

public interface TagService
{
    void Add(AddTagDto dto);
    void Delete(int id);
}