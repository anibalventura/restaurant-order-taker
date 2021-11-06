using BusinessLayer.Enum;
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
    public partial class TakeOrderForm : Form
    {
        public TakeOrderForm()
        {
            InitializeComponent();
        }

        #region Events
        
        private void TakeOrderForm_Load(object sender, EventArgs e)
        {
            // Load ComboBox options.
            LoadStarterOptions();
            LoadMainPlateOptions();
            LoadDrinkOptions();
            LoadDessertOptions();
        }

        private void TakeOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TableOrderForm.Instance.Show();
        }

        private void BtnSaveOrder_Click(object sender, EventArgs e)
        {
            SaveOrder();
        }

        private void BtnCancelOrder_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void SaveOrder()
        {
            string name = TxbName.Text;
            ComboBoxItem starter = CmbxStarter.SelectedItem as ComboBoxItem;
            ComboBoxItem mainPlate = CmbxMainPlate.SelectedItem as ComboBoxItem;
            ComboBoxItem drink = CmbxDrink.SelectedItem as ComboBoxItem;
            ComboBoxItem dessert = CmbxDessert.SelectedItem as ComboBoxItem;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name.", "Warning!");
            }
            else if (starter.Text == null)
            {
                MessageBox.Show("Please select a starter.", "Warning!");
            }
            else if (mainPlate.Text == null)
            {
                MessageBox.Show("Please select a main plate.", "Warning!");
            }
            else if (drink.Text == null)
            {
                MessageBox.Show("Please select a drink.", "Warning!");
            }
            else if (dessert.Text == null)
            {
                MessageBox.Show("Please select a dessert.", "Warning!");
            }
            else
            {
                TableService tableService = new TableService();

                Order newOrder = new Order
                {
                    Table = TableRepository.Instance.SelectedTable,
                    Name = name,
                    Starter = starter.Text,
                    MainPlate = mainPlate.Text,
                    Drink = drink.Text,
                };

                tableService.Add(newOrder);
                CloseForm();
            }
        }

        private void CloseForm()
        {
            this.Close();
        }

        private void LoadStarterOptions()
        {
            List<ComboBoxItem> starters = new List<ComboBoxItem>()
            {
                new ComboBoxItem
                {
                    Text = "Select an option",
                    Value = null
                },
                new ComboBoxItem
                {
                    Text = "Garlic Bread",
                    Value = (int)MenuStarterOptions.GARLIC_BREAD
                },
                new ComboBoxItem
                {
                    Text = "Onion Rings",
                    Value = (int)MenuStarterOptions.ONION_RINGS
                },
                new ComboBoxItem
                {
                    Text = "Mozzarella Sticks",
                    Value = (int)MenuStarterOptions.MOZZARELLA_STICKS
                },
                new ComboBoxItem
                {
                    Text = "Hot Wings",
                    Value = (int)MenuStarterOptions.HOT_WINGS
                },
                new ComboBoxItem
                {
                    Text = "French Fries",
                    Value = (int)MenuStarterOptions.FRENCH_FRIES
                },
            };

            foreach (ComboBoxItem starter in starters)
            {
                ComboBoxItem newItem = new ComboBoxItem
                {
                    Text = starter.Text,
                    Value = starter.Value
                };

                CmbxStarter.Items.Add(newItem);
            }

            CmbxStarter.SelectedItem = CmbxStarter.Items[0];
        }

        private void LoadMainPlateOptions()
        {
            List<ComboBoxItem> mainPlates = new List<ComboBoxItem>()
            {
                new ComboBoxItem
                {
                    Text = "Select an option",
                    Value = null
                },
                new ComboBoxItem
                {
                    Text = "Mixed Salad",
                    Value = (int)MenuMainPlateOptions.MIXED_SALAD
                },
                new ComboBoxItem
                {
                    Text = "Chicken Soup",
                    Value = (int)MenuMainPlateOptions.CHICKEN_SOUP
                },
                new ComboBoxItem
                {
                    Text = "Ravioli",
                    Value = (int)MenuMainPlateOptions.RAVIOLI
                },
                new ComboBoxItem
                {
                    Text = "Lasagna",
                    Value = (int)MenuMainPlateOptions.LASAGNA
                },
                new ComboBoxItem
                {
                    Text = "Meatbals",
                    Value = (int)MenuMainPlateOptions.MEATBALS
                },
                new ComboBoxItem
                {
                    Text = "Pasta Carbonara",
                    Value = (int)MenuMainPlateOptions.PASTA_CARBONARA
                },
                new ComboBoxItem
                {
                    Text = "Shrimp Marinara",
                    Value = (int)MenuMainPlateOptions.SHRIMP_MARINARA
                },
                new ComboBoxItem
                {
                    Text = "Hamburger",
                    Value = (int)MenuMainPlateOptions.HAMBURGER
                },
                new ComboBoxItem
                {
                    Text = "Pizza",
                    Value = (int)MenuMainPlateOptions.PIZZA
                },
                new ComboBoxItem
                {
                    Text = "Chicken Francese",
                    Value = (int)MenuMainPlateOptions.CHICKEN_FRANCESE
                },
            };

            foreach (ComboBoxItem mainPlate in mainPlates)
            {
                ComboBoxItem newItem = new ComboBoxItem
                {
                    Text = mainPlate.Text,
                    Value = mainPlate.Value
                };

                CmbxMainPlate.Items.Add(newItem);
            }

            CmbxMainPlate.SelectedItem = CmbxMainPlate.Items[0];
        }

        private void LoadDrinkOptions()
        {
            List<ComboBoxItem> drinks = new List<ComboBoxItem>()
            {
                new ComboBoxItem
                {
                    Text = "Select an option",
                    Value = null
                },
                new ComboBoxItem
                {
                    Text = "Water",
                    Value = (int)MenuDrinkOptions.WATER
                },
                new ComboBoxItem
                {
                    Text = "Juice",
                    Value = (int)MenuDrinkOptions.JUICE
                },
                new ComboBoxItem
                {
                    Text = "Ice Tea",
                    Value = (int)MenuDrinkOptions.ICE_TEA
                },
                new ComboBoxItem
                {
                    Text = "Beer",
                    Value = (int)MenuDrinkOptions.BEER
                },
                new ComboBoxItem
                {
                    Text = "Wine",
                    Value = (int)MenuDrinkOptions.WINE
                },
            };

            foreach (ComboBoxItem drink in drinks)
            {
                ComboBoxItem newItem = new ComboBoxItem
                {
                    Text = drink.Text,
                    Value = drink.Value
                };

                CmbxDrink.Items.Add(newItem);
            }

            CmbxDrink.SelectedItem = CmbxDrink.Items[0];
        }

        private void LoadDessertOptions()
        {
            List<ComboBoxItem> desserts = new List<ComboBoxItem>()
            {
                new ComboBoxItem
                {
                    Text = "Select an option",
                    Value = null
                },
                new ComboBoxItem
                {
                    Text = "Apple Cake",
                    Value = (int)MenuDessertOptions.APPLE_CAKE
                },
                new ComboBoxItem
                {
                    Text = "Blondie",
                    Value = (int)MenuDessertOptions.BLONDIE
                },
                new ComboBoxItem
                {
                    Text = "Brownie",
                    Value = (int)MenuDessertOptions.BROWNIE
                },
                new ComboBoxItem
                {
                    Text = "Cheesecake",
                    Value = (int)MenuDessertOptions.CHEESECAKE
                },
                new ComboBoxItem
                {
                    Text = "Gelato",
                    Value = (int)MenuDessertOptions.GELATO
                },
            };

            foreach (ComboBoxItem dessert in desserts)
            {
                ComboBoxItem newItem = new ComboBoxItem
                {
                    Text = dessert.Text,
                    Value = dessert.Value
                };

                CmbxDessert.Items.Add(newItem);
            }

            CmbxDessert.SelectedItem = CmbxDessert.Items[0];
        }

        #endregion
    }
}
