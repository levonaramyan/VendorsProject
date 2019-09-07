using System;
using System.Collections.Generic;
using System.Text;

namespace Vendors_DAL.Models
{
    public class Address : BaseModel
    {
        public string Street { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public Vendor Vendor { get; set; }
        public int VendorId { get; set; }
    }
}
