using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Enter your fullname")]
        [StringLength(30)]
        [Required(ErrorMessage = "Fullname length must be at least 2 symbols")]
        public string FullName { get; set; }
       
        [Display(Name = "Enter your adress")]
        [StringLength(50)]
        [Required(ErrorMessage = "Adress length must be at least 10 symbols")]
        public string Adress { get; set; }

        [Display(Name = "Enter your phone number")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(11)]
        [Required(ErrorMessage = "Phone number length must be at least 11 symbols (use adding code)")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Enter your e-mail")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30)]
        [Required(ErrorMessage = "E-mail length must be at least 7 symbols (use full adress with @)")]
        public string EMail { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
