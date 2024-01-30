using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplicationProject.Model
{
    public class Article
    {
        public string ArticleNumber { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public ArticleGroup Group { get; set; }
    }
}
