using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComputerShopSystem.Models;
namespace ComputerShopSystem.Models
{
    public class PropertyValues
    {
        public int Id { get; set; }
        public Property Property { get; set; }
        public int PropertyID { get; set; }
        public Device Device{ get; set; }
        public int DeviceID { get; set; }
        public string Values { get; set; }
    }
}