using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Vendors_BLL.Interfaces;
using Vendors_DAL;
using Vendors_DAL.Models;
using Vendors_Web.ViewModels;

namespace Vendors_Web.Controllers
{
    public class VendorsController : Controller
    {
        private IEntityService<Vendor> _vendorService;
        private IEntityService<VendorType> _vendorTypeService;
        private IEntityService<Address> _addressService;
        private ICityService _cityService;
        private IEntityService<Country> _countryService;
        private IEntityService<Contact> _contactService;
        private IEntityService<ContactPerson> _contactPersonService;


        public VendorsController(IEntityService<Vendor> vendorService, IEntityService<Address> addressService,
                                 IEntityService<Contact> contactService, IEntityService<ContactPerson> contactPersonService,
                                 IEntityService<VendorType> vendorTypeService, IEntityService<Country> countryService,
                                 ICityService cityService) 
        {
            _vendorService = vendorService;
            _addressService = addressService;
            _contactService = contactService;
            _contactPersonService = contactPersonService;
            _vendorTypeService = vendorTypeService;
            _countryService = countryService;
            _cityService = cityService;
        }

        public async Task<IActionResult> Index()
        {
            List<Vendor> vendors = await _vendorService.GetAllAsync();

            return View(vendors);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            await LoadData();

            return PartialView("_Create");
        }

        [NonAction]
        public async Task LoadData()
        {
            ViewBag.VendorTypes = await _vendorTypeService.GetAllAsync();
            ViewBag.Countries = await _countryService.GetAllAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateVendorViewModel model)
        {
            if(ModelState.IsValid)
            {
                // Add Vendor To DB
                Vendor vendor = new Vendor
                {
                    Name = model.VendorName,
                    VendorTypeId = model.VendorTypeId,
                };

                await _vendorService.CreateAsync(vendor);

                // Add Address
                Address address = new Address
                {
                    Street = model.Street,
                    Vendor = vendor,
                    CityId = model.CityId
                };

                await _addressService.CreateAsync(address);

                // Add Contacts
                Contact contact = new Contact
                {
                    Email = model.Email,
                    Fax = model.Fax,
                    Phone = model.Phone,
                    SalesPhone = model.SalesPhone,
                    SalesFax = model.SalesFax,
                    Vendor = vendor
                };

                await _contactService.CreateAsync(contact);

                // Add Contact Persons
                ContactPerson contactPerson = new ContactPerson
                {
                    Name = model.ContactPerson,
                    Title = model.ContactTitle,
                    Vendor = vendor
                };

                await _contactPersonService.CreateAsync(contactPerson);

                await _vendorService.SaveAsync();

                return PartialView("_CreationSuccess");
            }

            await LoadData();

            return PartialView("_Create",model);
        }

        public async Task<List<City>> GetCities(int id)
        {
            //Country country = await _countryService.GetByIdAsync(id);

            //return country.Cities.ToList();

            return await _cityService.GetCitiesByCountryId(id);
        }
    }
}