using _4.News.Entities;

namespace _3.News.Services.Tags.Contracts;

public interface TagRepasitory
{
    void Add(Tag tag);
    bool IsExistByName(string dtoName);
    void DeleteById(int id);
    bool IsExistById(int id);
    List<Tag> GetTagsByName(List<string> tagNames);
}