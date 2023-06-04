using CurdProject.DAL;
using CurdProject.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace CurdProject.Controllers
{
    public class ProductController : Controller
    {
        Repository repository = new Repository();
        public IActionResult Read()
        {

            var Products = repository.Read();

            return View(Products);
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var products = repository.GetId(Id);

            return View(products);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            repository.Update(product);
            return RedirectToAction("Read");
        }
        public IActionResult Delete(int Id)
        {
            repository.Delete(Id);


            return RedirectToAction("Read");
        }
        [HttpPost]
        public IActionResult Insert(Product products)
        {
            repository.Insert(products);


            return RedirectToAction("Read");
        }
        public IActionResult Insert()
        {
           
            return View();
        }
      
    }
}
