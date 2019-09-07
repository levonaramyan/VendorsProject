using System;
using System.Collections.Generic;
using System.Text;

namespace Vendors_DAL.Models
{
    public class Vendor : BaseModel
    {
        public string Name { get; set; }
        public int VendorTypeId { get; set; }
        public VendorType VendorType { get; set; }
        public ContactPerson ContactPerson { get; set; }
        public Contact Contacts { get; set; }
        public Address Address { get; set; }
    }
}
