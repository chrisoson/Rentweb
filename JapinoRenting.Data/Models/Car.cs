using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace JapinoRenting.Data;

public class Car
{
    [Key]
    public int Id { get; set; }
    
    //Car brand, for example: Toyota, Honda, etc.
    [Required]
    public int BrandId { get; set; }
    [ForeignKey("BrandId")]
    [ValidateNever]
    public Brand Brand { get; set; }
    
    //Car model, for example: Corolla, Civic, etc.
    [Required]
    [MaxLength(50)]
    public string Model { get; set; }
    
    //Car year of production
    [Required]
    [Range(1900, 2021, ErrorMessage = "Year must be between 1900 and 2021")]
    public int Year { get; set; }
    
    //Registration number of the car
    [Required]
    [MaxLength(10)]
    public string RegistrationNumber { get; set; }
    
    //Chassis number of the car
    [Required]
    [MaxLength(20)]
    public string ChassisNumber { get; set; }
    
    //Car description
    [Required]
    [MaxLength(2000)]
    public string Description { get; set; }
    
    //Engine for the car
    [Required]
    public int EngineId { get; set; }
    [ForeignKey("EngineId")]
    [ValidateNever]
    public Engine Engine { get; set; }
    
    //Price per day for renting the car
    [Required]
    [DataType(DataType.Currency)]
    [Range(0, 10000, ErrorMessage = "Price per day must be between 0 and 10000")]
    public double PricePerDay { get; set; }
    
    //Car image 
    [Required]
    public string ImageUrl { get; set; }
}