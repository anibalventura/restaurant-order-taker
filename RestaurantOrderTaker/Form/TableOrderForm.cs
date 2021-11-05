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

        public TableOrderForm()
        {
            InitializeComponent();
        }

        private void TableOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TablesForm.Instance.Show();
        }

        private void BtnTakeOrder_Click(object sender, EventArgs e)
        {
            TakeOrderForm newTakeOrderForm = new TakeOrderForm();
            newTakeOrderForm.Show();
            this.Hide();
        }

        private void BtnCancelOrders_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            this.Close();
        }
    }
}
