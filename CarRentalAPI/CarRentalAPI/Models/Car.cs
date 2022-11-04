using System;
using System.ComponentModel.DataAnnotations;

namespace CarRentalAPI.Models
{
	public class Car
	{
		[Required]
		public int Id { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Year { get; set; }
	}
}

