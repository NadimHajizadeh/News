using _3.NewsBlog.EntityMap.Citys.Contracts.Dto;

namespace _3.NewsBlog.EntityMap.Citys.Contracts;

public interface CityService
{
    void Add(AddCityDto dto);
    List<GetAllCitiesDto> GetAll();
    List<CityNewsIncludedDto> GetAllWithNews(string? newsTitle);
}