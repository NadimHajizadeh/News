using _2.NewsBlog.Persistanse.Ef;
using _3.News.Services.Tags.Contracts;
using _4.News.Entities;
using Microsoft.EntityFrameworkCore;

namespace _2.News.Persistance.EF.Tags;

public class EFTagRepasitory : TagRepasitory
{
    private readonly EFDataContext _context;
    private readonly DbSet<Tag> _tags;

    public EFTagRepasitory(EFDataContext context)
    {
        _context = context;
        _tags = context.Set<Tag>();
    }
    public void Add(Tag tag)
    {
        _tags.Add(tag);
    }

    public bool IsExistByName(string dtoName)
    {
        return
            _tags.Any(_ => _.Name == dtoName);
    }

    public void DeleteById(int id)
    {
        var tag = _tags.First(_ => _.Id == id);
        _tags.Remove(tag);

    }

    public bool IsExistById(int id)
    {
        return 
        _tags.Any(_ => _.Id == id);
    }

    public List<Tag> GetTagsByName(List<string> tagNames)
    {
        return
            _tags.Where(_ => tagNames.Any(t => t == _.Name)).ToList();
    }
}