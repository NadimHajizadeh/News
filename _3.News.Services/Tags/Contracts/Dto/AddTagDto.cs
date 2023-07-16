using System.ComponentModel.DataAnnotations;

namespace _3.News.Services.Tags.Contracts.Dto
{
    public class AddTagDto
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
