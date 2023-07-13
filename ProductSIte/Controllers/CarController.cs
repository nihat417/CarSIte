using AutoMapper;
using CarSite.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using ProductSIte.Models;

namespace ProductSIte.Controllers
{
    public class CarController : Controller
    {
        private static int _Id = 10;
        private readonly IMapper _mapper;

        public CarController(IMapper mapper)
        {
            _mapper = mapper;
        }

        private static List<Car> cars = new()
        {
            new Car { Id = 0,Make = "Hyundai",Model = "Elantra",Price = 28000,Year = 2020,Color = "Silver",EngineSize = 1600,FuelEfficiency = 34.2,photos = "/Images/elantra.jpg"},
            new Car { Id = 1,Make = "Ford",Model = "Mustang",Price = 45000,Year = 2023,Color = "Black",EngineSize = 2500,FuelEfficiency = 25.8, photos = "/Images/mustang.jpg"},
            new Car { Id = 2,Make = "Chevrolet",Model = "Camaro",Price = 42000,Year = 2022,Color = "Yellow",EngineSize = 3000,FuelEfficiency = 24.6, photos = "/Images/camaro.jpg"},
            new Car { Id = 3,Make = "BMW",Model = "3 Series",Price = 40000,Year = 2021,Color = "Blue",EngineSize = 2000,FuelEfficiency = 28.5,photos = "/Images/bmw3ser.jpg"},
            new Car { Id = 4,Make = "Toyota",Model = "Supra",Price = 45000,Year = 2012,Color = "Dark",EngineSize = 10000,FuelEfficiency = 90.5 ,photos = "/Images/supra.jpg"},
            new Car { Id = 5,Make = "Toyota",Model = "Camry",Price = 25000,Year = 2022,Color = "Silver",EngineSize = 2000,FuelEfficiency = 30.5 ,photos = ""},
            new Car { Id = 6,Make = "BMW",Model = "X5",Price = 65000,Year = 2023,Color = "White",EngineSize = 3500,FuelEfficiency = 22.3, photos = "/Images/bmwx5jpg.jpg"},
            new Car { Id = 7,Make = "Honda",Model = "Accord",Price = 28000,Year = 2021,Color = "Red",EngineSize = 1800,FuelEfficiency = 32.1,photos = "/Images/HondaAccord.jpg"},
            new Car { Id = 8,Make = "Ford",Model = "Mustang GT",Price = 50000,Year = 2022,Color = "Red",EngineSize = 5000,FuelEfficiency = 20.1,photos = ""},
            new Car { Id = 9,Make = "Mercedes-Benz",Model = "C-Class",Price = 45000,Year = 2020,Color = "White",EngineSize = 2500,FuelEfficiency = 26.8,photos = "/Images/mers.jpg"},
        };

        

        [HttpGet]
        public IActionResult AddCar()
        {
            return View();
        }

        //[Route("Addcar")]
        [HttpPost]
        public IActionResult AddCar(AddCarVM vm)
        {
            if(ModelState.IsValid)
            {
                Car car=_mapper.Map<Car>(vm);
                car.Id = _Id++;
                cars.Add(car);
                return RedirectToAction("AllCars");
            }
            return View("Addcar");
        }

        public IActionResult DeleteCar(int id)
        {
            cars.Remove(cars.FirstOrDefault(car=>car.Id == id));
            return RedirectToAction("AllCars");
        }

        //[HttpGet]
        public IActionResult AllCars()
        {
            return View(cars);
        }

        [HttpGet]
        public IActionResult GetCars(int id)
        {
            return View(cars[id]);
        }

        public IActionResult SearchCars(string query)
        {
            if (!string.IsNullOrEmpty(query))
            {
                List<Car> searchResults = cars.FindAll(car => car.Make == query);
                return View(searchResults);
            }

            return RedirectToAction("AllCars");
        }


    }
}
