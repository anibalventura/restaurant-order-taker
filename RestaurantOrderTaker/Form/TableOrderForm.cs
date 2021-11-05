using BusinessLayer.Model;
using BusinessLayer.Repository;
using BusinessLayer.Service;
using RestaurantOrderTaker.CustomControlItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestaurantOrderTaker
{
    public sealed partial class TableOrderForm : Form
    {
        public static TableOrderForm Instance { get; } = new TableOrderForm();

        private readonly OrderService orderService;

        public TableOrderForm()
        {
            InitializeComponent();

            orderService = new OrderService();
        }

        #region Events

        private void TableOrderForm_Load(object sender, EventArgs e)
        {
            // Update table selected.
            LblTableToOrder.Text = $"Table # {TableRepository.Instance.SelectedTable}";

            // Load ComboBox options.
            LoadPeopleOnTableOptions();

            // Load all orders in table.
            LoadOrders();
        }

        private void TableOrderForm_VisibleChanged(object sender, EventArgs e)
        {
            // Load all orders in table.
            LoadOrders();
        }

        private void TableOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TablesForm.Instance.Show();
        }

        private void BtnTakeOrder_Click(object sender, EventArgs e)
        {
            TakeOrder();
        }

        private void BtnSaveOrders_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void BtnCancelOrders_Click(object sender, EventArgs e)
        {
            List<Order> orders = orderService.GetAll();

            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].Table == TableRepository.Instance.SelectedTable)
                {
                    LbxOrders.Items.RemoveAt(i);
                }
            }

            CloseForm();
        }

        private void CloseForm()
        {
            TablesForm.Instance.Show();
            this.Hide();
        }

        #endregion

        #region Methods

        private void TakeOrder()
        {
            List<Order> orders = orderService.GetAllByTable(TableRepository.Instance.SelectedTable);
            ComboBoxItem peopleOnTable = CmbxPeopleOntable.SelectedItem as ComboBoxItem;

            if (int.Parse(peopleOnTable.Text) > orders.Count)
            {
                TakeOrderForm newTakeOrderForm = new TakeOrderForm();
                newTakeOrderForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Orders for all people in the table have been taken.", "Warning!");
            }
        }

        private void LoadPeopleOnTableOptions()
        {
            for (int i = 1; i <= 4; i++)
            {
                ComboBoxItem newItem = new ComboBoxItem
                {
                    Text = i.ToString(),
                    Value = i
                };

                CmbxPeopleOntable.Items.Add(newItem);
            }

            CmbxPeopleOntable.SelectedItem = CmbxPeopleOntable.Items[0];
        }

        private void LoadOrders()
        {
            LbxOrders.BeginUpdate();

            LbxOrders.Items.Clear();

            List<Order> orders = orderService.GetAllByTable(TableRepository.Instance.SelectedTable);
            
            foreach (Order order in orders)
            {
                LbxOrders.Items.Add(order.Name);
            }

            LbxOrders.EndUpdate();
        }

        #endregion
    }
}
