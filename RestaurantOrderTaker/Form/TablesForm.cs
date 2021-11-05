using BusinessLayer.Enum;
using BusinessLayer.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderTaker
{
    public sealed partial class TablesForm : Form
    {

        public static TablesForm Instance { get; } = new TablesForm();

        public TablesForm()
        {
            InitializeComponent();
        }

        #region Events

        private void BtnTableOne_Click(object sender, EventArgs e)
        {
            SelectTable((int)TableOptions.ONE);
        }

        private void BtnTableTwo_Click(object sender, EventArgs e)
        {
            SelectTable((int)TableOptions.TWO);
        }

        private void BtnTableThree_Click(object sender, EventArgs e)
        {
            SelectTable((int)TableOptions.THREE);
        }

        private void BtnTableFour_Click(object sender, EventArgs e)
        {
            SelectTable((int)TableOptions.FOUR);
        }

        private void BtnTableFive_Click(object sender, EventArgs e)
        {
            SelectTable((int)TableOptions.FIVE);
        }

        private void BtnViewOrders_Click(object sender, EventArgs e)
        {
            AllOrdersFrom newAllOrdersFrom = new AllOrdersFrom();
            newAllOrdersFrom.Show();
            this.Hide();
        }

        #endregion

        #region Methods

        private void SelectTable(int tableNumber)
        {
            TableRepository.Instance.SelectedTable = tableNumber;
            TableOrderForm newTableOrderForm = new TableOrderForm();
            newTableOrderForm.Show();
            this.Hide();
        }

        #endregion
    }
}
