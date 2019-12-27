using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }

        //public Order order { get; set; }

        public int carId { get; set; }

        public int price { get; set; }

        public virtual Car car { get; set; }

        //public virtual Order order { get; set; }
    }
}
