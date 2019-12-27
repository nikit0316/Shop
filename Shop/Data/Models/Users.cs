using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Users : IdentityUser
    {
        public int id { get; set; }
        public int OrderId { get; set; }
        public int Year { get; set; }
    }
}
