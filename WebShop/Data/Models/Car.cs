using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Data.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string CarShortDesc { get; set; }
        public string CarLongDesc { get; set; }
        public string Img { get; set; }
        public int Price { get; set; }
        public bool IsFavorite { get; set; }
        public bool Available { get; set; }
        public int CatId { get; set; }
        public virtual Category Category { get; set; }
    }
}
