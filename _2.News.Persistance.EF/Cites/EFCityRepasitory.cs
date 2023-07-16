using _2.NewsBlog.Persistanse.Ef;
using _3.NewsBlog.EntityMap.Citys.Contracts.Dto;
using _4.News.Entities;
using Microsoft.EntityFrameworkCore;

namespace _2.News.Persistance.EF;

public class EFCityRepasitory : CityRepasitory
{
    private readonly EFDataContext _context;
    private readonly DbSet<City> _cities;
    private readonly DbSet<_4.News.Entities.News> _news;

    public EFCityRepasitory(EFDataContext context)
    {
        _context = context;
        _cities = context.Set<City>();
        _news = context.Set<_4.News.Entities.News>();
    }

    public void Add(City city)
    {
        _cities.Add(city);
    }

    public bool IsExistByName(string dtoName)
    {
        return
            _cities.Any(_ => _.Name == dtoName);
    }

    public List<GetAllCitiesDto> Getall()
    {
        return
            _cities.Select(_ => new GetAllCitiesDto
            {
                Id = _.Id,
                Name = _.Name
            }).ToList();
    }

    public List<CityNewsIncludedDto> getAllWithNews(string? newsTitle)
    {
        var result = (from c in _cities
            join n in _news on c.Id equals n.CityId
                into a
            from aa in a.DefaultIfEmpty()
            select new CityNewsIncludedDto
            {
                CityName = c.Name,
                NewsDtos = _news.Where(_ => _.CityId == c.Id).Select(_ => new
                    NewsDto
                    {
                        NewsIdDto = aa.Id,
                        NewsTitleDto = aa.Title,
                    }).ToList()
            }).ToList();

        if (newsTitle != null)
        {
            result = result
                .Where(_ => _.NewsDtos.Any(n => n.NewsTitleDto == newsTitle))
                .ToList();
        }

        return result.ToList();
    }
}