using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplicationProject.Model
{
    public class ArticleGroup
    {
        public string Name { get; set; }
        public ArticleGroup? Parent { get; set; }
    }
}
