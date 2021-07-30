using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data.Interfaces;
using WebShop.Data.Models;

namespace WebShop.Data.Repository
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
        
        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            appDBContent.Order.Add(order);

            var items = shopCart.ListShopItems;

            foreach(var element in items)
            {
                var orderDetail = new OrderDetail()
                {
                    CarId = element.Car.Id,
                    OrderId = order.Id,
                    Price = element.Car.Price
                };

                appDBContent.OrderDetail.Add(orderDetail);
            }

            //appDBContent.SaveChanges();
        }
    }
}
