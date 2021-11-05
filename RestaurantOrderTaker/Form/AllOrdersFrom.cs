using BusinessLayer.Model;
using BusinessLayer.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestaurantOrderTaker
{
    public partial class AllOrdersFrom : Form
    {
        private readonly OrderService orderService;

        public AllOrdersFrom()
        {
            InitializeComponent();

            orderService = new OrderService();
        }

        #region Events

        private void AllOrdersFrom_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void AllOrdersFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            TablesForm.Instance.Show();
        }

        private void BtnBackToTables_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void CloseForm()
        {
            this.Close();
        }

        private void LoadOrders()
        {
            LboxAllOrders.BeginUpdate();

            LboxAllOrders.Items.Clear();

            List<Order> orders = orderService.GetAll();

            foreach (Order order in orders)
            {
                LboxAllOrders.Items.Add(order.Name);
            }

            LboxAllOrders.EndUpdate();
        }

        #endregion
    }
}
