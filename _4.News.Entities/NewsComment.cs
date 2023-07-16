using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.News.Entities
{
    public class NewsComment
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public Boolean IsAprroved { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int NewsId { get; set; }
        public News News { get; set; }
    }
}
