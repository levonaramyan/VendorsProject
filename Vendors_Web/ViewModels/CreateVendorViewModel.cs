using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vendors_Web.ViewModels
{
    public class CreateVendorViewModel
    {
        [Required]
        [Display(Name = "Vendor Name")]
        public string VendorName { get; set; }

        [Required]
        [Display(Name = "Contact Name")]
        public string ContactPerson { get; set; }

        [Required]
        [Display(Name = "Contact Title")]
        public string ContactTitle { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Street { get; set; }

        [Required]
        [Display(Name = "Country")]
        public int CountryId { get; set; }

        [Required]
        [Display(Name = "City")]
        public int CityId { get; set; }

        [Required]
        [Display(Name = "Vendor Type")]
        public int VendorTypeId { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Phone]
        [Display(Name = "Fax Number")]
        public string Fax { get; set; }

        [EmailAddress]
        [Display(Name = "Sales Email")]
        public string SalesEmail { get; set; }

        [Phone]
        [Display(Name = "Sales Phone Number")]
        public string SalesPhone { get; set; }

        [Phone]
        [Display(Name = "Sales Fax Number")]
        public string SalesFax { get; set; }
    }
}
