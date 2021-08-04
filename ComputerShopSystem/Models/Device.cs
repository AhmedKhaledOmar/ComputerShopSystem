using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComputerShopSystem.Models;
namespace ComputerShopSystem.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public int SerialNo { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}