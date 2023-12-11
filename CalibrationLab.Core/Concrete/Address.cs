using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationLab.Core.Concrete
{
    public class Address
    {
        public int Id {  get; set; }

        public int CustomerId { get; set; }

        public int ContactId { get; set; }

        public string Description { get; set; }

        public List<Country> Countries { get; set; }

        public int CountryId { get; set; }

        public List<City> Cities { get; set; }
        
        public int CityId { get; set; }

        public string PostalCode { get; set; }

        public string Details { get; set; }

        public string Phone { get; set; }
        
        public string Email { get; set; }

        
        

    }
}
