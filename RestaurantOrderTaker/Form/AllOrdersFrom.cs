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
        public AllOrdersFrom()
        {
            InitializeComponent();
        }

        #region Events

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

        #endregion
    }
}
