using CalibrationLab.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationLab.Core.Concrete
{
    public class Parameter:Base
    {
        public string? Description { get; set; }
        
        public string? ReferenceDocument { get; set; }

        public string? AdditionalInfo { get; set; }

        public List<Point>? Points { get; set; }

        public int? PointCount { get; set; }

        //Navigation
        public int? ScopeId { get; set;}

        public Scope? Scope { get; set; }

        public virtual int? DeviceId { get; set; }

        public virtual Device? Device { get; set; }
    }
}
