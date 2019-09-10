using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendors_Web.ViewModels
{
    public class FilterVendorsViewModel
    {
        public int ItemsCount { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public int CityId { get; set; }
    }
}
