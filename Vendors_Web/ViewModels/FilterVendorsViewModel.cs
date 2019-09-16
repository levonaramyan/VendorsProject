using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vendors_Web.ViewModels
{
    public class FilterVendorsViewModel
    {
        public int ItemsCount { get; set; }
        [Display(Name = "Vendor Name")]
        public string Name { get; set; }
        [Display(Name = "Vendor Type")]
        public int TypeId { get; set; }
        [Display(Name = "City")]
        public int CityId { get; set; }
        public int Page { get; set; }
    }
}
