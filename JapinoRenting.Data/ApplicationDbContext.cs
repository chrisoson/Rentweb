using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JapinoRenting.Data;
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Car> Cars { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Engine> Engines { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Engine>().HasData(
            new Engine
            {
                Id = 1,
                Name = "2JZ",
                HorsePower = 280,
                Torque = 320,
                Displacement = 3,
                Cylinders = 6,
                EngineType = EngineType.Gasoline
            },
            new Engine
            {
                Id = 2,
                Name = "RB26",
                HorsePower = 280,
                Torque = 320,
                Displacement = 2.6,
                Cylinders = 6,
                EngineType = EngineType.Gasoline
            },
            new Engine
            {
                Id = 3,
                Name = "SR20",
                HorsePower = 200,
                Torque = 250,
                Displacement = 2,
                Cylinders = 4,
                EngineType = EngineType.Gasoline
            });
        builder.Entity<Brand>().HasData(
            new Brand
            {
                Id = 1,
                Name = "Toyota"
            },
            new Brand
            {
                Id = 2,
                Name = "Nissan"
            },
            new Brand
            {
                Id = 3,
                Name = "Mitsubishi"
            },
            new Brand
            {
                Id = 4,
                Name = "Mazda"
            },
            new Brand
            {
                Id = 5,
                Name = "Subaru"
            },
            new Brand
            {
                Id = 6,
                Name = "Honda"
            },
            new Brand
            {
                Id = 7,
                Name = "Suzuki"
            },
            new Brand
            {
                Id = 8,
                Name = "Daihatsu"
            },
            new Brand
            {
                Id = 9,
                Name = "Isuzu"
            },
            new Brand
            {
                Id = 10,
                Name = "Lexus"
            },
            new Brand
            {
                Id = 11,
                Name = "Acura"
            });
        builder.Entity<Car>().HasData(
            new Car
            {
                Id = 1,
                BrandId = 1,
                Model = "Supra",
                Year = 1993,
                RegistrationNumber = "KEI575",
                ChassisNumber = "1687-8489-8868-8488",
                Description =
                    "The Toyota Supra is a sports car and grand tourer manufactured by Toyota Motor Corporation beginning in 1978. The initial four generations of the Supra were produced from 1978 to 2002. The fifth generation has been produced since March 2019 and went on sale in May 2019. The styling of the Supra was derived from the Toyota Celica, but it was both longer and wider. Starting in mid-1986, the A70 Supra became a separate model from the Celica. In turn, Toyota also stopped using the prefix Celica and began just calling the car Supra. Owing to the similarity and past of the Celica's name, it is frequently mistaken for the Supra, and vice versa. First, second, and third generation Supras were assembled at Tahara plant in Tahara, Aichi while the fourth generation Supra was assembled at the Motomachi plant in Toyota City.",
                EngineId = 1,
                PricePerDay = 1000,
                ImageUrl = "null"
            });
    }
}
