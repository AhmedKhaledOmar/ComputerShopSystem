using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace ComputerShopSystem.Models
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public DbSet<Category> Categories { get; set; }

		public DbSet<Device> Devices { get; set; }

		public DbSet<Property> Properties { get; set; }

		public DbSet<DeviceProperty> DeviceProperty { get; set; }

		public DbSet<CategoryProperties> CategoryProperties { get; set; }

		public ApplicationDbContext()
			: base("DefaultConnection", throwIfV1Schema: false)
		{
		}

		public static ApplicationDbContext Create()
		{
			return new ApplicationDbContext();
		}
	}
}