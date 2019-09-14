using System;
using System.Collections.Generic;
using System.Text;

namespace Vendors_DAL.Models
{
    public class Vendor : BaseModel
    {
        public string Name { get; set; }
        public int VendorTypeId { get; set; }
        public virtual VendorType VendorType { get; set; }
        public virtual ContactPerson ContactPerson { get; set; }
        public virtual Contact Contacts { get; set; }
        public virtual Address Address { get; set; }
    }
}
