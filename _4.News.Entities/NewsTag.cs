﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.News.Entities
{
    public class NewsTag
    {
        public int NewsId { get; set; }
        public int TagId { get; set; }
        public News News { get; set; }
        public Tag Tag { get; set; }
    }
}
