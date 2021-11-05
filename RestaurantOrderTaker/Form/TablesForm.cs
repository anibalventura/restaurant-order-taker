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
            TableOrderForm newTableOrderForm = new TableOrderForm();
            newTableOrderForm.Show();
            this.Hide();
        }

        private void BtnTableTwo_Click(object sender, EventArgs e)
        {
            TableOrderForm newTableOrderForm = new TableOrderForm();
            newTableOrderForm.Show();
            this.Hide();
        }

        private void BtnTableThree_Click(object sender, EventArgs e)
        {
            TableOrderForm newTableOrderForm = new TableOrderForm();
            newTableOrderForm.Show();
            this.Hide();
        }

        private void BtnTableFour_Click(object sender, EventArgs e)
        {
            TableOrderForm newTableOrderForm = new TableOrderForm();
            newTableOrderForm.Show();
            this.Hide();
        }

        private void BtnTableFive_Click(object sender, EventArgs e)
        {
            TableOrderForm newTableOrderForm = new TableOrderForm();
            newTableOrderForm.Show();
            this.Hide();
        }

        #endregion

        #region Methods



        #endregion
    }
}
