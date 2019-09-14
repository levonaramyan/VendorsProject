using System;
using System.Collections.Generic;
using System.Text;

namespace Vendors_DAL.Models
{
    public class City : BaseModel
    {
        public string Name { get; set; }
        public virtual Country Country { get; set; }
        public int CountryId { get; set; }
    }
}
