using _3.News.Services.Citys.Exeptions;
using _3.NewsBlog.EntityMap.Citys.Contracts;
using _3.NewsBlog.EntityMap.Citys.Contracts.Dto;
using _3.NewsBlog.EntityMap.Contracts;
using _4.News.Entities;


public class CityAppService : CityService
{
    private readonly CityRepasitory _repasitory;
    private readonly UnitOfWork _unitOfWork;

    public CityAppService(CityRepasitory repasitory, UnitOfWork unitOfWork)
    {
        _repasitory = repasitory;
        _unitOfWork = unitOfWork;
    }


    public void Add(AddCityDto dto)
    {

        var IsExisted = _repasitory.IsExistByName(dto.Name);
        if (IsExisted)
        {
            throw new CityAlredyExistedExeption();
        }
        
        
        
        var city = new City()
        {
            Name = dto.Name
        };
        _repasitory.Add(city);
        _unitOfWork.Complete();
    }

    public List<GetAllCitiesDto> GetAll()
    {
        return 
        _repasitory.Getall();
    }

    public List<CityNewsIncludedDto> GetAllWithNews(string? newsTitle)
    {
        return
            _repasitory.getAllWithNews(newsTitle);
    }
}