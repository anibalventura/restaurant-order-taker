using BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Repository
{
    public sealed class OrderRepository
    {
        public static OrderRepository Instance { get; } = new OrderRepository();

        public List<Order> AllOrders = new List<Order>();

        private OrderRepository() { }
    }
}
