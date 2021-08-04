using ComputerShopSystem.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Data.Entity;

namespace ComputerShopSystem.Controllers.APIController
{
    public class DeviceController : ApiController
    {
        private ApplicationDbContext _context;
        public DeviceController()
        {
            _context = new ApplicationDbContext();
        }
        //GET/api/Device
        public List<Device> GetDevices()
        {
            return _context.Devices
                .Include(c => c.Category)
                .ToList();
        }
    }
}
