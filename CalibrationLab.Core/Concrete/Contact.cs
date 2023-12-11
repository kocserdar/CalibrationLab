using CalibrationLab.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationLab.Core.Concrete
{
    public class Contact:Base
    {
        public int CustomerId { get; set; }
        
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public List<Address> Address { get; set; }

        public int AddressId { get; set; }


    }
}
