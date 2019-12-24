using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Enter your name")]
        [MinLength(2)]
        [Required(ErrorMessage = "Enter a valid name")]
        public string name { get; set; }

        [Display(Name = "Enter your surname")]
        [MinLength(2)]
        [Required(ErrorMessage = "Enter a valid surname")]
        public string surname { get; set; }

        [Display(Name = "Enter your address")]
        [MinLength(5)]
        [Required(ErrorMessage = "Enter a valid address")]
        public string address { get; set; }

        [Display(Name = "Enter your phone number")]
        [DataType(DataType.PhoneNumber)]
        [MinLength(10)]
        [Required(ErrorMessage = "Enter a valid number")]
        public string phone { get; set; }

        [Display(Name = "Enter your email address")]
        [DataType(DataType.EmailAddress)]
        [MinLength(8)]
        [Required(ErrorMessage = "Enter a valid email address")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
