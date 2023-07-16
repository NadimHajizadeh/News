using System.ComponentModel.DataAnnotations;

namespace _3.NewsBlog.EntityMap.Categorys.Contracts.Dto
{
    public class AddCategoryDto
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
