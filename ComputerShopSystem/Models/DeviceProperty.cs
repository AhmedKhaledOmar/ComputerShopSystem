using System.ComponentModel.DataAnnotations;

namespace ComputerShopSystem.Models
{
    public class DeviceProperty
    {
        public int Id { get; set; }
        public Property Property { get; set; }
        public int PropertyID { get; set; }
        public Device Device{ get; set; }
        public int DeviceID { get; set; }
        public string Value { get; set; }
    }
}