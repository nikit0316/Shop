using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Users
    {
        public int id { get; set; }
        public string login { get; set; }
        public string psswrd { get; set; }
        public int orderId { get; set; }

    }
}
