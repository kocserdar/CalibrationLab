using CalibrationLab.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationLab.Core.Concrete
{
    public class Scope:Base
    {
        public string? Description { get; set; }

        public string? AdditionalInfo { get; set; }

        public List<Parameter>? Parameters { get; set; }

    }
}
