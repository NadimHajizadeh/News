using _3.News.Services.NewsTags.Contracts;
using _3.News.Services.Tags.Contracts;
using _3.News.Services.Tags.Contracts.Dto;
using _3.NewsBlog.EntityMap.Contracts;
using _4.News.Entities;

namespace _3.News.Services.Tags;

public class TagAppService : TagService
{
    private readonly UnitOfWork _unitOfWork;
    private readonly TagRepasitory _repasitory;
    private readonly NewsTagsRepasitory _newsTagsRepasitory;

    public TagAppService(UnitOfWork unitOfWork,TagRepasitory repasitory,
        NewsTagsRepasitory newsTagsRepasitory )
    {
        _unitOfWork = unitOfWork;
        _repasitory = repasitory;
        _newsTagsRepasitory = newsTagsRepasitory;
    }
    
    
    
    
    public void Add(AddTagDto dto)
    {


        var IsExisted = _repasitory.IsExistByName(dto.Name);
        if (IsExisted)
        {
            throw new TagAlredyExistedException();
        }
        
        var tag = new Tag()
        {
            Name = dto.Name,
        };
        _repasitory.Add(tag);
        _unitOfWork.Complete();
    }

    public void Delete(int id)
    {
        var isExist =_repasitory.IsExistById(id);
        if (!isExist)
        {
            throw new InvalidTagIdExeptions();
        }

        var isInUse = _newsTagsRepasitory.HasTagById(id);
        
        if (isInUse)
        {
            throw new TagInUseExeption();
        }
        
        
        _repasitory.DeleteById(id);
        _unitOfWork.Complete();
    }
}