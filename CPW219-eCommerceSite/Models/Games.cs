using System.ComponentModel.DataAnnotations;

namespace CPW219_eCommerceSite.Models
{
	public class Games
	{
		public string Title { get; set; }
		[Required]
		public double Price { get; set; }

		public int Quantity { get; set; }
	}
}
