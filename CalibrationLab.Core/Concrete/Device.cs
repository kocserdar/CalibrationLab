using CalibrationLab.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationLab.Core.Concrete
{
    public class Device:Base
    {
        public string? SerialNumber { get; set; }

        public string? Type { get; set; }

        public string? InventoryNo { get; set; }

        public string? Place { get; set; }

        public double Resolution { get; set; }
        
        public double RangeLow { get; set; }

        public double RangeHigh { get; set; }
        
        public string? Description { get; set; }

        public string? AdditionalInfo { get; set; }

        public bool HasEquipment { get; set; }

        public DateTime? LastCalibrated { get; set; }

        public bool IsCalSuccess { get; set; }

        public double? CalFrequence { get; set;}

        public List<Parameter>? Parameters { get; set; }

        public Equipment? Equipment { get; set; }



    }
}
