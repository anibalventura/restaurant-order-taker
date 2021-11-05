using BusinessLayer.Repository;
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

        public TableOrderForm()
        {
            InitializeComponent();

            // Update table selected.
            LblTableToOrder.Text = $"Table # {TableRepository.Instance.SelectedTable}";

            // Load ComboBox options.
            LoadPeopleOnTableOptions();
        }

        #region Events

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

        #endregion

        #region Methods

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

        #endregion
    }
}
