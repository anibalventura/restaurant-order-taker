using BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Repository
{
    public sealed class TableRepository
    {
        public static TableRepository Instance { get; } = new TableRepository();

        public int SelectedTable { get; set; } = 0;

        public List<Order> Orders = new List<Order>();

        private TableRepository() { }
    }
}
