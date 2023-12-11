using CalibrationLab.Core.Abstract;
using CalibrationLab.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationLab.Core.Concrete
{
    public class Point:Base
    {
        public string? Description { get; set; }

        public double ReferenceValue { get; set; }

        public double? TestValue { get; set; }

        public double? Deviation { get; set; }

        public double? DeviationPercent { get; set;}

        public double? Uncertinity { get; set; }

        public double? UncertinityPercent { get; set;}

        public double? MaxDeviation { get; set; }

        public PointStatus? PointStatus { get; set; }

        //Navigation Props

        public virtual Parameter? Parameter { get; set; }

        public virtual int? ParameterId { get; set; }

    }
}
