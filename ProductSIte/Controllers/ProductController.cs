using Microsoft.AspNetCore.Mvc;
using ProductSIte.Models;

namespace ProductSIte.Controllers
{
    public class ProductController : Controller
    {
        private List<Products> products = new()
        {
            new Products {Id = 1 , Name= "Alma" , Description = "Quba Almasi" , price =1.20f, quantity = 10},
            new Products {Id = 2 ,Name = "Bizon" , Description = "Enerji ickisi" , price = 1.50f , quantity = 200},
            new Products {Id = 3 ,Name = "Redbull" , Description = "Qanadlandirir" , price = 2.50f , quantity=200},
        };

        //[HttpGet]
        public IActionResult AllProducts()
        {
            return View(products);
        }
    }
}
