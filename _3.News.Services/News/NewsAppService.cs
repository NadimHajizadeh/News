using _3.News.Services.News.Contracts;
using _3.News.Services.News.Contracts.Dto;
using _3.News.Services.Tags.Contracts;
using _3.NewsBlog.EntityMap.Contracts;

namespace _3.News.Services.News;

public class NewsAppService : NewsService
{
    private readonly NewsRepasitory _repasitory;
    private readonly UnitOfWork _unitOfWork;
    private readonly TagRepasitory _tagRepasitory;

    public NewsAppService(NewsRepasitory repasitory,UnitOfWork unitOfWork,
        TagRepasitory tagRepasitory)
    {
        _repasitory = repasitory;
        _unitOfWork = unitOfWork;
        _tagRepasitory = tagRepasitory;
    }


    public void Add(AddNewsDto dto)
    {

        var oldTag = _tagRepasitory.GetTagsByName(dto.Tags);




    }
    
}