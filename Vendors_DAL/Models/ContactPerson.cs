using System;
using System.Collections.Generic;
using System.Text;

namespace Vendors_DAL.Models
{
    public class ContactPerson : BaseModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public int VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
