using CalibrationLab.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationLab.Core.Concrete
{
    public class Customer:Base
    {
        public string? Name { get; set; }

        public string? Email { get; set; }

        public int AddressId { get; set; }

        public List<Address> Address { get; set; }

        public int DeviceId { get; set; }
        
        public List<Device> Devices { get; set; }

        public int EquipmentId { get; set; }
        
        public List<Equipment> Equipment { get; set; }

        public int OfferId { get; set; }

        public List<Offer> Offers { get; set; }

        public int SaleId { get; set; }
       
        public List<Sale> Sales { get; set; }

        public int ContactId { get; set; }
        
        public List<Contact> Contacts { get; set; }
    }
}
