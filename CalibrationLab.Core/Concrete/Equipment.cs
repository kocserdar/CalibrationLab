using CalibrationLab.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationLab.Core.Concrete
{
    public class Equipment:Base
    {
        
        public string? SerialNumber { get; set; }

        public string? Type { get; set; }

        public string? InventoryNo { get; set; }

        public string? Place { get; set; }

        public string? Description { get; set; }

        public string? AdditionalInfo { get; set; }

    }
}
