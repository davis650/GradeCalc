using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeCalc.Models
{
    public class ClassModel
    {
        public int id { get; set; }
        public string Title { get; set; }
        public GradeModel OverallGrade { get; set; }
    }
}
