using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComputerShopSystem.Models;

namespace ComputerShopSystem.ViewModel
{
    public class DeviceViewModel
    {
        public Device Device { get; set; }
        public List<PropertyValues> PropertyValues { get; set; }
        public List<Category> Category { get; set; }

        public List<Property> Properties { get; set; }
        public List<CategoryProperties> CategoryProperties { get; set; }
    }
}