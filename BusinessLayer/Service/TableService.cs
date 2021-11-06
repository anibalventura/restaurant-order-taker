using BusinessLayer.Model;
using BusinessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Service
{
    public class TableService
    {
        TableRepository orderRepository = TableRepository.Instance;

        public void Add(Order newOrder)
        {
            orderRepository.Orders.Add(newOrder);
        }

        public void Delete(int index)
        {
            orderRepository.Orders.RemoveAt(index);
        }

        public void Edit(int index, Order newOrder)
        {
            orderRepository.Orders[index] = newOrder;
        }

        public List<Order> GetAll()
        {
            return orderRepository.Orders;
        }
    }
}
