using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestaurantOrderTaker
{
    public partial class TakeOrderForm : Form
    {
        public TakeOrderForm()
        {
            InitializeComponent();
        }

        private void TakeOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TableOrderForm.Instance.Show();
        }

        private void BtnCancelOrder_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            this.Close();
        }
    }
}
