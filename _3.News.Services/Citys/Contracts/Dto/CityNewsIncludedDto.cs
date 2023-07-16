namespace _3.NewsBlog.EntityMap.Citys.Contracts.Dto
{
    public class CityNewsIncludedDto
    {
        public string CityName { get; set; }
        public List<NewsDto> NewsDtos { get; set; } = new();
    }
    public class NewsDto
    {
        public int NewsIdDto { get; set; }
        public string NewsTitleDto { get; set; }
    }

}
