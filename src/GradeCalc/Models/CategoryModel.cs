using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeCalc.Models
{
    public class CategoryModel
    {
        public int id { get; set; }
        public string CategoryName { get; set; }
        public int Weight { get; set; }
        public int PointsPossible { get; set; }
        public int PointsTotal { get; set; }
    }
}
