using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);
            if(orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year,
                    4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;
        }
        public List<Order> Retrieve()
        {
            return new List<Order>();
        }
        public bool Save(Order order)
        {
            var success = true;
            if (order.HasChanges)
            {
                if (order.IsValid)
                {
                    if (order.IsNew)
                    {
                        //Вставка в память
                    }
                    else
                    {
                        //Обновить данные
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
