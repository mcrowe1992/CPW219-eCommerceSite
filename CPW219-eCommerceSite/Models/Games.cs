using System.ComponentModel.DataAnnotations;

namespace CPW219_eCommerceSite.Models
{
	public class Games
	{
		[Key]
		public int GamesId { get; set; }

		[Required]
		[Display (Name = "Title")]
		public string Title { get; set; }

		[Range(0, double.MaxValue)]
		[DataType(DataType.Currency)]
		public double Price { get; set; }

		[Range(0,double.MaxValue)]
		[Display (Name = "Qty")]
		public int Quantity { get; set; }
	}
}
