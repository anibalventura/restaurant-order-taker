using BusinessLayer.Interface;
using BusinessLayer.Model;
using BusinessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Service
{
    public class OrderService
    {
        OrderRepository orderRepository = OrderRepository.Instance;

        public void Add(Order newOrder)
        {
            orderRepository.AllOrders.Add(newOrder);
        }

        public void Delete(int index)
        {
            orderRepository.AllOrders.RemoveAt(index);
        }

        public void Edit(int index, Order newOrder)
        {
            orderRepository.AllOrders[index] = newOrder;
        }

        public List<Order> GetAll()
        {
            return orderRepository.AllOrders;
        }

        public List<Order> GetAllByTable(int table)
        {
            List<Order> orders = GetAll();
            List<Order> ordersByTable = new List<Order>();

            foreach (Order order in orders)
            {
                if (order.Table == table)
                {
                    ordersByTable.Add(order);
                }
            }

            return ordersByTable;
        }
    }
}
