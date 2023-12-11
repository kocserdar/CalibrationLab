using CalibrationLab.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationLab.Core.Abstract
{
    public abstract class Base
    {
        public int Id { get; set; }
        
        public DateTime CreatedAt { get; set; } 
        
        public DateTime LastUpdatedAt { get; set; }
        
        public DateTime PassivatedAt { get; set; }

        public Status Status { get; set; }
    }
}
