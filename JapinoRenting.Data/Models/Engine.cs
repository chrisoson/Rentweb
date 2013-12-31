using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace JapinoRenting.Data;

public class Engine
{
    [Key]
    public int Id { get; set; }
    
    //Engine name, for example: Ls1, 2JZ, etc.
    [Required]
    [Display(Name = "Engine Name")]
    public string Name { get; set; }
    
    //Engine horse power
    [Range(1, 2000, ErrorMessage = "Horse power must be between 1 and 2000")]
    public int HorsePower { get; set; }
    
    //Engine torque
    [Range(1, 10000, ErrorMessage = "Torque must be between 1 and 2000, in Nm")]
    public int Torque { get; set; }
    
    //Engine displacement, for example: 1.6L, 2.0L, etc.
    public double Displacement { get; set; }
    
    //Number of cylinders
    [Range(1, 16, ErrorMessage = "Number of cylinders must be between 1 and 16")]
    public int Cylinders { get; set; }
    
    //Engine type, for example: Gasoline, Diesel, etc.
    [Required]
    public EngineType EngineType { get; set; }
}