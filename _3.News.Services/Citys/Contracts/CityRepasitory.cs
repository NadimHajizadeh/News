using _3.NewsBlog.EntityMap.Citys.Contracts.Dto;
using _4.News.Entities;


public interface CityRepasitory
{
    void Add(City city);
    bool IsExistByName(string dtoName);
    List<GetAllCitiesDto> Getall();
    List<CityNewsIncludedDto> getAllWithNews(string? newsTitle);
}