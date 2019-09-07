﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vendors_DAL.Models
{
    public class Country : BaseModel
    {
        public string Name { get; set; }
        public List<City> Cities { get; set; }
    }
}
