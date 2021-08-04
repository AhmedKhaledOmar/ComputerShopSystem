namespace ComputerShopSystem.Models
{
	public class CategoryProperties
	{
		public int Id { get; set; }

		public Property Property { get; set; }

		public int PropertyID { get; set; }

		public Category Category { get; set; }

		public int CategoryID { get; set; }
	}
}