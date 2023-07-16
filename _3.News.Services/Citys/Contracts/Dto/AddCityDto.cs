using System.ComponentModel.DataAnnotations;

namespace _3.NewsBlog.EntityMap.Citys.Contracts.Dto
{
    public class AddCityDto
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
