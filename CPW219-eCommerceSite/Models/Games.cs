using System.ComponentModel.DataAnnotations;

namespace CPW219_eCommerceSite.Models
{
	public class Games
	{
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
