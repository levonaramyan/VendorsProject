using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vendors_BLL.Interfaces;
using Vendors_DAL.Models;
using Vendors_Web.ViewModels;

namespace Vendors_Web.Controllers
{
    public class VendorsController : Controller
    {
        private IVendorService _vendorService;

        public VendorsController(IVendorService vendorService)
        {
            _vendorService = vendorService;
        }

        public IActionResult Index()
        {
            List<Vendor> vendors = _vendorService.GetVendors();

            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult Create(CreateVendorViewModel model)
        {
            if(ModelState.IsValid)
            {
                Vendor vendor = new Vendor
                {
                    Name = model.VendorName,
                    VendorType = model.VendorType
                };

                ContactPerson contactPerson = new ContactPerson
                {
                    Name = model.ContactPerson,
                    Title = model.ContactTitle
                };
            }

            return PartialView(model);
        }
    }
}