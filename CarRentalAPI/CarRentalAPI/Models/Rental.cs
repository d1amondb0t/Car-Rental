using System;
using System.ComponentModel.DataAnnotations;

namespace CarRentalAPI.Models
{
	public class Rental
	{
        [Required]
        public int Id { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public Car Car { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public Availability Availability { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public  string Description { get; set; }
        [Required]
        public string Location { get; set; }

	}

	public enum Availability
	{
		Available, Rented

	}

}

