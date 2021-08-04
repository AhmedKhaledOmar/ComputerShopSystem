using ComputerShopSystem.Models;
using System.Collections.Generic;

namespace ComputerShopSystem.ViewModel
{
	public class DeviceViewModel
	{
		public Device Device { get; set; }

		public List<Category> Categories { get; set; }
	}
}