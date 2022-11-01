using System;
namespace CarRentalAPI.Model
{
	public class Rental
	{
		public int Id { get; set; }

		public User User { get; set; }
		public Car Car { get; set; }
		public float Price { get; set; }
		public  string Description { get; set; }
		public string Location { get; set; }
		public DateTime Availability { get; set; }

	}
}

