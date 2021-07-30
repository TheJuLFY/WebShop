using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data.Interfaces;
using WebShop.Data.Models;

namespace WebShop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
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
                    }
                };
            }
        }
    }
}
