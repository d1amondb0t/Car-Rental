using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalAPI.Models
{
	public class User
	{
		[Required]
		[Key]
		public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
		[Required]
		public string Password { get; set; }
		[NotMapped]
		public string Password2 { get; set; }
		public ICollection<Rental>? Rentals { get; set; }
	}
}

