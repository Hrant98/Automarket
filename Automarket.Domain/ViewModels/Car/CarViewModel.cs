using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;


namespace Automarket.Domain.ViewModels.Car
{
    public class CarViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Enter car name")]
        [MinLength(2, ErrorMessage = "The minimum length must be more than two characters")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [MinLength(50, ErrorMessage = "The minimum length must be greater than 50 characters")]
        public string Description { get; set; }

        [Display(Name = "Model")]
        [Required(ErrorMessage = "Specify Model")]
        [MinLength(2, ErrorMessage = "The minimum length must be more than two characters")]
        public string Model { get; set; }

        [Display(Name = "Speed")]
        [Required(ErrorMessage = "Specify speed")]
        [Range(0, 600, ErrorMessage = "Length must be between 0 and 600")]
        public double Speed { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Specify the cost")]
        public decimal Price { get; set; }

        public string DateCreate { get; set; }

        [Display(Name = "Vehicle type")]
        [Required(ErrorMessage = "Select type")]
        public string TypeCar { get; set; }

        public IFormFile Avatar { get; set; }

        public byte[]? Image { get; set; }
    }
}