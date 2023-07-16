using _2.NewsBlog.Persistanse.Ef;
using _3.News.Services.NewsTags.Contracts;
using _4.News.Entities;
using Microsoft.EntityFrameworkCore;

namespace _2.News.Persistance.EF.NewsTags;

public class EFNewsTagsRepasitory : NewsTagsRepasitory
{
    private readonly DbSet<NewsTag> _newsTags;

    public EFNewsTagsRepasitory(EFDataContext context)
    {
        _newsTags = context.Set<NewsTag>();
    }
    public bool HasTagById(int id)
    {
        return 
        _newsTags.Any(_ => _.TagId == id);
    }
}