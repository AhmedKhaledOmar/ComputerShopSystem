using ComputerShopSystem.Models;
using ComputerShopSystem.ViewModel;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace ComputerShopSystem.Controllers
{
    public class DeviceController : Controller
    {
        private ApplicationDbContext _context;

        public DeviceController()
        {
            _context = new ApplicationDbContext();
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Device
        public ActionResult Index()
        {
            var device = _context.Devices.Include(c => c.Category).ToList();
            return View(device);
        }

        public ActionResult DeviceForm()
        {
            var category = _context.Categories.ToList();
            var viewModel = new DeviceViewModel
            {
                Device = new Device(),
                Category = category
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Next(Device device)
        {
            
            _context.Devices.Add(device);
            _context.SaveChanges();

            var Properties = _context.CategoryProperties
                .Where(c => c.CategoryID == device.CategoryId)
                .Include(c => c.Property)
                .ToList();

            foreach (var deviceProperty in Properties)
            {
                var propertyValues = new PropertyValues()
                {
                    DeviceID = device.Id,
                    PropertyID = deviceProperty.PropertyID
                };
                _context.PropertyValues.Add(propertyValues);
            }
            _context.SaveChanges();
            var values = new DeviceViewModel
            {
                PropertyValues = _context.PropertyValues.
                Where(c => c.Device.Id == device.Id)
                .Include(c => c.Device)
                .ToList()
            };

            return View("Properties", values);
        }

        [HttpPost]
        public ActionResult SaveProperty(DeviceViewModel deviceViewModel)
        {
            foreach (var value in deviceViewModel.PropertyValues)
            {
                var property = _context.PropertyValues
                    .SingleOrDefault(c => c.Id == value.Id);

                property.Values = value.Values;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Device");
        }
        
        public ActionResult Edit(int Id)
        {
            var device = _context.Devices.SingleOrDefault(c => c.Id == Id);
            
            return View(device);
        }

    }
}