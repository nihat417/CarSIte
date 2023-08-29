using AutoMapper;
using CarSite.Domain.Entities;
using CarSite.Models.ViewModels;
using CarSite.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace ProductSIte.Controllers
{
    public class CarController : Controller
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext context;

        public CarController(IMapper mapper,AppDbContext context)
        {
            _mapper = mapper;
            this.context = context;
        }

        [HttpGet]
        public IActionResult AddCar()=>View();
        

        [HttpPost]
        public IActionResult AddCar(AddCarVM vm)
        {
            if(ModelState.IsValid)
            {
                Car car=_mapper.Map<Car>(vm);
                context.cars.Add(car);
                context.SaveChanges();
                return RedirectToAction("AllCars");
            }
            return View("Addcar");
        }

        //public IActionResult DeleteCar(int id)
        //{
        //    //cars.Remove(cars.FirstOrDefault(car=>car.Id == id));
        //    return RedirectToAction("AllCars");
        //}

        //[HttpGet]
        public IActionResult AllCars()
        {
            return View(context.cars.ToList());
        }

        //[HttpGet]
        //public IActionResult GetCars(int id)
        //{
        //    return View();
        //}

        public IActionResult SearchCars(string query)
        {
            if (!string.IsNullOrEmpty(query))
            {
                //List<Car> searchResults = cars.FindAll(car => car.Make == query);
                return View();
            }

            return RedirectToAction("AllCars");
        }


    }
}
