using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationLab.Core.Concrete
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual int CountryId { get; set; }
        
        public virtual Country Country { get; set; }

    }
}
