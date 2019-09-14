using System;
using System.Collections.Generic;
using System.Text;

namespace Vendors_DAL.Models
{
    public class Contact : BaseModel
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string SalesPhone { get; set; }
        public string SalesFax { get; set; }
        public int VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
