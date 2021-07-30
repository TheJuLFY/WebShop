using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data.Models;

namespace WebShop.Data
{
    public class DBObjects
    {
         public static void Initial(AppDBContent content)
         {
            if(!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        CarName = "Ford Focus II",
                        CarShortDesc = "Best for beginners",
                        CarLongDesc = "Built by FoMoCo in 2004 Focus II was friendly accepted by drivers. " +
                                      "Comfortable, not expensive, pretty reliable and 5 stars safety make it the best first car",
                        Img = "/img/ford_focus.jpg",
                        Price = 400000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Passenger Cars"]
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
                        Category = Categories["Passenger Cars"]
                    },
                    new Car
                    {
                        CarName = "Mitsubishi Lancer Evo VIII",
                        CarShortDesc = "Fucking fast",
                        CarLongDesc = "300+ horsepower engine, sports suspension, loud exhaust. No one will overtake you",
                        Img = "/img/mitsubishi_lancer_evo_viii.jpg",
                        Price = 1500000,
                        IsFavorite = false,
                        Available = true,
                        Category = Categories["Passenger Cars"]
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
                        Category = Categories["Passenger Cars"]
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
                        Category = Categories["Cargo Trucks"]
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
                        Category = Categories["Cargo Trucks"]
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
                        Category = Categories["Cargo Trucks"]
                    },
                    new Car
                    {
                        CarName = "BMW M4",
                        CarShortDesc = "M Power",
                        CarLongDesc = "",
                        Img = "/img/bmw_m4.jpg",
                        Price = 4000000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Sport Cars"]
                    },
                    new Car
                    {
                        CarName = "Mersedes E-class AMG",
                        CarShortDesc = "Legendary AMG",
                        CarLongDesc = "",
                        Img = "/img/e_class_amg.jpg",
                        Price = 5000000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Sport Cars"]
                    },
                    new Car
                    {
                        CarName = "Toyota Supra Mk3",
                        CarShortDesc = "2JZ - that's enough",
                        CarLongDesc = "",
                        Img = "/img/toyota_supra.jpg",
                        Price = 3000000,
                        IsFavorite = false,
                        Available = true,
                        Category = Categories["Sport Cars"]
                    }
                );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category
                        {
                            CategoryName = "Passenger Cars",
                            CatDesc = "Comfortable little cars"
                        },
                        new Category
                        {
                            CategoryName = "Cargo Trucks",
                            CatDesc = "Heavy n' usefull for work"
                        },
                        new Category
                        {
                            CategoryName = "Sport Cars",
                            CatDesc = "Fast and furious"
                        }
                    };
                    
                    category = new Dictionary<string, Category>();
                    
                    foreach(Category element in list)
                    {
                        category.Add(element.CategoryName, element);
                    }
                }

                return category;
            }
        }
    }
}
