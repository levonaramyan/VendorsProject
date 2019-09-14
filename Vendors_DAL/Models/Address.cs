using System;
using System.Collections.Generic;
using System.Text;

namespace Vendors_DAL.Models
{
    public class Address : BaseModel
    {
        public string Street { get; set; }
        public virtual City City { get; set; }
        public int CityId { get; set; }
        public virtual Vendor Vendor { get; set; }
        public int VendorId { get; set; }
    }
}
