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
        [HttpGet]
        public ActionResult Index()
        {
            var device = _context.Devices
                .Include(c => c.Category)
                .ToList();
            return View(device);
        }

        [HttpGet]
        public ActionResult DeviceForm()
        {
            var categories = _context.Categories.ToList();
            var viewModel = new DeviceViewModel
            {
                Device = new Device(),
                Categories = categories
            };
            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var device = _context.Devices
                .SingleOrDefault(c => c.Id == Id);
            var category = _context.Categories
                .SingleOrDefault(c => c.Id == device.CategoryId);

            var viewModel = new EditViewModel
            {
                Device = device,
                Category = category
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult ProcessDevice(Device device)
        {
            if (device.Id == 0)
            {
                Save(device);
            }
            else
                _context.SaveChanges();

            var deviceProperties = _context.DeviceProperty
                .Where(c => c.Device.Id == device.Id)
                .Include(c => c.Property)
                .ToList();

            var devicePropertiesviewModel = new DevicePropertiesViewModel
            {
                DeviceProperties = deviceProperties
            };
            return View("Properties", devicePropertiesviewModel);
        }

        [HttpPost]
        public ActionResult SaveProperties(DevicePropertiesViewModel devicePropertiesViewModel)
        {
            foreach (var deviceProperty in devicePropertiesViewModel.DeviceProperties)
            {
                var propertyInDb = _context.DeviceProperty
                    .SingleOrDefault(c => c.Id == deviceProperty.Id);

                propertyInDb.Value = deviceProperty.Value;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Device");
        }

        private void Save(Device device)
        {
            _context.Devices.Add(device);
            _context.SaveChanges();

            var Properties = _context.CategoryProperties
                .Where(c => c.CategoryID == device.CategoryId)
                .Include(c => c.Property)
                .ToList();

            foreach (var deviceProperty in Properties)
            {
                var propertyValues = new DeviceProperty()
                {
                    DeviceID = device.Id,
                    PropertyID = deviceProperty.PropertyID
                };
                _context.DeviceProperty.Add(propertyValues);
            }
            _context.SaveChanges();
        }


    }
}