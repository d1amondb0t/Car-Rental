using System;
namespace CarRentalAPI.Model
{
	public class User
	{
		public User()
		{
		}

		public int Id { get; set; }

		public string Username { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public string Password2 { get; set; }

		public List<Car> Cars = new();

		public List<Rental> Rentals = new();
	}
}

