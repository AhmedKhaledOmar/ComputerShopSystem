using System;
using System.ComponentModel.DataAnnotations;

namespace ComputerShopSystem.Models
{
    public class Device
    {
        public Device()
        {
            AcquisitionDate = DateTime.Now;
        }

        public int Id { get; set; }
        
        [Display(Name = "Device Name")]
        public string Name { get; set; }
        
        [Display(Name = "Serial Number")]
        public int SerialNo { get; set; }
        
        [Display(Name = "Acquisition Date")]
        public DateTime AcquisitionDate { get; set; }
        
        public Category Category { get; set; }
        
        [Display(Name = "Device Category")]
        public int CategoryId { get; set; }
    }
}