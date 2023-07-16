using _3.News.Services.NewsTags.Contracts;
using _3.NewsBlog.EntityMap.Contracts;

namespace _3.News.Services.NewsTags;

public class NewTagAppService : NewsTagsService
{
    private readonly NewsTagsRepasitory _repasitory;
    private readonly UnitOfWork _unitOfWork;

    public NewTagAppService(NewsTagsRepasitory repasitory,
        UnitOfWork unitOfWork)
    {
        _repasitory = repasitory;
        _unitOfWork = unitOfWork;
    }
    public bool HasTagById(int id)
    {
        return
        _repasitory.HasTagById(id);
    }
}