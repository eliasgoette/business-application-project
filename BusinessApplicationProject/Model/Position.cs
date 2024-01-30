using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplicationProject.Model
{
    public class Position
    {
        public required string PositionNumber { get; set; }
        public required Article ArticleDetails { get; set; }
        public int Quantity { get; set; }
        public double PurchasePrice { get; set; }
    }
}
