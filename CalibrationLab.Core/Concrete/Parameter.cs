using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationLab.Core.Concrete
{
    public class Parameter
    {
        public int? No {  get; set; }
        
        public string? Description { get; set; }
        
        public string? ReferenceDocument { get; set; }

        public string? AdditionalInfo { get; set; }

        public List<Point>? Points { get; set; }

        public int? PointCount { get; set; }

    }
}
