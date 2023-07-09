using Microsoft.AspNetCore.Mvc;
using ProductSIte.Models;

namespace ProductSIte.Controllers
{
    public class CarController : Controller
    {
        private List<Car> cars = new()
        {
            new Car { Id = 0,Make = "Toyota",Model = "Camry",Price = 25000,Year = 2022,Color = "Silver",EngineSize = 2000,FuelEfficiency = 30.5 ,photos = "/Images/camry.jpg"},
            new Car { Id = 1,Make = "Honda",Model = "Accord",Price = 28000,Year = 2021,Color = "Red",EngineSize = 1800,FuelEfficiency = 32.1,photos = "/Images/HondaAccord.jpg"},
            new Car { Id = 2,Make = "Ford",Model = "Mustang",Price = 45000,Year = 2023,Color = "Black",EngineSize = 2500,FuelEfficiency = 25.8, photos = "/Images/mustang.jpg"},
            new Car { Id = 3,Make = "Chevrolet",Model = "Camaro",Price = 42000,Year = 2022,Color = "Yellow",EngineSize = 3000,FuelEfficiency = 24.6, photos = "/Images/camaro.jpg"},
            new Car { Id = 4,Make = "BMW",Model = "X5",Price = 65000,Year = 2023,Color = "White",EngineSize = 3500,FuelEfficiency = 22.3, photos = "/Images/bmwx5jpg.jpg"},
        };

        [HttpGet]
        public IActionResult AddCar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            cars.Add(car);
            return RedirectToAction("AllCars");
        }

        //[HttpGet]
        public IActionResult AllCars()
        {
            return View(cars);
        }

        public IActionResult GetCars(int id)
        {
            return View(cars[id]);
        }

    }
}
