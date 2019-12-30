using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;

        private readonly ShopCart shopCart;

        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }

        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;

            var items = shopCart.listShopItems;

            var orderDetail = new OrderDetail();

            order.detail = orderDetail;

            

            foreach (var car in items)
            {
                orderDetail.carId = car.car.id;
                orderDetail.price = car.car.price;
            }

            appDBContent.Order.Add(order);
            appDBContent.OrderDetail.Add(orderDetail);
            appDBContent.SaveChanges();
        }
    }
}

