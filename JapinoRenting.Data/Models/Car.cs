using System.ComponentModel.DataAnnotations;

namespace JapinoRenting.Data;

public class Car
{
    [Key]
    public int Id { get; set; }
    
    
    //Car brand, for example: Toyota, Honda, etc.
    [Required]
    public string Brand { get; set; }
    
    //Car model, for example: Corolla, Civic, etc.
    [Required]
    public string Model { get; set; }
    
    //Car year of production
    [Required]
    public int Year { get; set; }
    
    //Registration number of the car
    [Required]
    public string RegistrationNumber { get; set; }
    
    //Chassis number of the car
    [Required]
    public string ChassisNumber { get; set; }
    
    //Car description
    [Required]
    public string Description { get; set; }
    
    //Engine for the car
    [Required]
    public Engine Engine { get; set; }
    
    //Price per day for renting the car
    [Required]
    [DataType(DataType.Currency)]
    public decimal PricePerDay { get; set; }
    
    //Car image 
    [Required]
    public string ImageUrl { get; set; }
}