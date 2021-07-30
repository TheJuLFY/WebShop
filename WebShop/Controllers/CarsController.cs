using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Data.Interfaces;
using WebShop.Data.Models;
using WebShop.ViewModels;

namespace WebShop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars ALLCARS, ICarsCategory ALLCATEGORIES)
        {
            _allCars = ALLCARS;
            _allCategories = ALLCATEGORIES;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("Passenger", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.CategoryName.Equals("Passenger Cars")).OrderBy(i => i.Id);
                    currCategory = "Passenger Cars";
                }
                else if (string.Equals("Trucks", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.CategoryName.Equals("Cargo Trucks")).OrderBy(i => i.Id);
                    currCategory = "Cargo Trucks";
                }
                else if (string.Equals("Sport", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.CategoryName.Equals("Sport Cars")).OrderBy(i => i.Id);
                    currCategory = "Sport Cars";
                }
            }

            var carObject = new CarsListViewModel 
            {
                AllCars = cars,
                CarCategory = currCategory
            };

            ViewBag.Title = "Page with cars";
            return View(carObject);
        }
    }
}
