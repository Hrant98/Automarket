using System.ComponentModel.DataAnnotations;

namespace Automarket.Domain.Enum
{
    public enum TypeCar
    {
        [Display(Name = "Passenger car")]
        PassengerCar = 0,
        [Display(Name = "Sedan")]
        Sedan = 1,
        [Display(Name = "Hatchback")]
        HatchBack = 2,
        [Display(Name = "Minivan")]
        Minivan = 3,
        [Display(Name = "Sports car")]
        SportsCar = 4,
        [Display(Name = "SUV")]
        Suv = 5,
    }
}