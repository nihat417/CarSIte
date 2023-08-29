using AutoMapper;
using CarSite.Application.ViewModels;
using CarSite.Domain.Entities;
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

        public IActionResult DeleteCar(int id)
        {
            var car = context.cars.Find(id);
            if(car != null)
            {
                context.cars.Remove(car);
                context.SaveChanges();
                return RedirectToAction("AllCars");
            }
            return NotFound();
        }

        [HttpGet]
        public IActionResult AllCars()
        {
            return View(context.cars.ToList());
        }

        [HttpGet]
        public IActionResult GetCars(int id)
        {
            var car=context.cars.Find(id);
            if(car != null)
            {
                return View(car);
            }
            return NotFound();
        }

        public IActionResult SearchCars(string query)
        {
            if (!string.IsNullOrEmpty(query))
            {
                var cars=context.cars.ToList();
                var searchlist=cars.FindAll(c=>c.Make!.ToLower().Contains(query.ToLower()) ||
                                            c.Model!.ToLower().Contains(query.ToLower()));                
                return View(searchlist);
            }

            return RedirectToAction("AllCars");
        }


    }
}
