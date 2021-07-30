using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data.Interfaces;
using WebShop.Data.Models;

namespace WebShop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory WitchCategory = new MockCategory(); 
        
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        CarName = "Ford Focus II",
                        CarShortDesc = "Best for beginners",
                        CarLongDesc = "Built by FoMoCo in 2004 Focus II was friendly accepted by drivers. Comfortable, not expensive, pretty reliable and 5 stars safety make it the best first car",
                        Img = "/img/ford_focus.jpg",
                        Price = 400000,
                        IsFavorite = true,
                        Available = true,
                        Category = WitchCategory.AllCategories.First()
                    },
                    new Car
                    {
                        CarName = "Kia K5",
                        CarShortDesc = "Luxury sedan",
                        CarLongDesc = "Powerful engine, plenty of space, stylish body lines and devilish attractiveness",
                        Img = "/img/kia_k5.jpg",
                        Price = 2500000,
                        IsFavorite = true,
                        Available = true,
                        Category = WitchCategory.AllCategories.First()
                    },
                    new Car
                    {
                        CarName = "Mitsubishi Lancer Evo VIII",
                        CarShortDesc = "Fucking fast!",
                        CarLongDesc = "300+ horsepower engine, sports suspension, loud exhaust. No one will overtake you",
                        Img = "/img/mitsubishi_lancer_evo_viii.jpg",
                        Price = 1500000,
                        IsFavorite = false,
                        Available = true,
                        Category = WitchCategory.AllCategories.First()
                    },
                    new Car
                    {
                        CarName = "Tesla Model S Plaid",
                        CarShortDesc = "Modern and eco-friendly",
                        CarLongDesc = "The future has already arrived. Quiet, fast, clean",
                        Img = "/img/tesla_model_s_plaid.jpg",
                        Price = 5000000,
                        IsFavorite = false,
                        Available = true,
                        Category = WitchCategory.AllCategories.First()
                    },
                    new Car
                    {
                        CarName = "Scania S500",
                        CarShortDesc = "Swedish practicality",
                        CarLongDesc = "Provide delivery to us",
                        Img = "/img/scania_s500.jpg",
                        Price = 4000000,
                        IsFavorite = true,
                        Available = true,
                        Category = WitchCategory.AllCategories.Last()
                    },
                    new Car
                    {
                        CarName = "Man TGX",
                        CarShortDesc = "German quality",
                        CarLongDesc = "The first million mileage is just the beginning of the road",
                        Img = "/img/man_tgx.jpg",
                        Price = 5000000,
                        IsFavorite = false,
                        Available = true,
                        Category = WitchCategory.AllCategories.Last()
                    },
                     new Car
                    {
                        CarName = "KAMAZ 6460",
                        CarShortDesc = "Simple as a stick",
                        CarLongDesc = "The end of the road is not a reason to stop",
                        Img = "/img/kamaz_6460.jpg",
                        Price = 1000000,
                        IsFavorite = false,
                        Available = true,
                        Category = WitchCategory.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get ; set ; }

        public Car GetObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
