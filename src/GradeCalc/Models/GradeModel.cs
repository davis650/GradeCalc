using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeCalc.Models
{
    public class GradeModel
    {
        public int id { get; set; }
        public string CurrentGrade { get; set; }
        public CategoryModel[] Categories { get; set; }
    }
}
