using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        public CartsTab()
        {
            InitializeComponent();

            UpdateUI();
        }

        /// <summary>
        /// Обновление графического интерфейса.
        /// </summary>
        public void UpdateUI()
        {
            ItemsListBox.Items.Clear();
            AppData.Items.ForEach(x => ItemsListBox.Items.Add(x));

            CustomersComboBox.Items.Clear();
            AppData.Customers.ForEach(x => CustomersComboBox.Items.Add(x));
        }

        /// <summary>
        /// Обновление данных о покупателе.
        /// </summary>
        private void UpdateCustomer()
        {
            if (_currentCustomer != null)
            {
                CustomersComboBox.SelectedItem = _currentCustomer;
                CartListBox.Items.Clear();
                _currentCustomer.Cart.Items.ForEach(x => CartListBox.Items.Add(x));

                UpdateAmount();
            }
        }

        /// <summary>
        /// Выбор покупателя
        /// </summary>
        private void CustomersComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            _currentCustomer = CustomersComboBox.SelectedItem as Customer;
            UpdateCustomer();
        }

        /// <summary>
        /// Добавление предмета в корзину.
        /// </summary>
        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.Items != null && ItemsListBox.SelectedItem != null && _currentCustomer != null)
            {
                _currentCustomer.Cart.Items.Add(ItemsListBox.SelectedItem as Item);
                UpdateCustomer();
            }
        }

        /// <summary>
        /// Удалить предмет из корзины.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemBtn_Click(object sender, EventArgs e)
        {
            if (CartListBox.Items != null && _currentCustomer != null)
            {
                if (MessageBox.Show("Вы уверены что хотите удалить данный предмет из корзины?","Предупреждение",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _currentCustomer.Cart.Items.Remove(CartListBox.SelectedItem as Item);
                    UpdateCustomer();
                }
            }
        }

        /// <summary>
        /// Отчистить корзину.
        /// </summary>
        private void ClearCartBtn_Click(object sender, EventArgs e)
        {
            if (CartListBox.Items != null && _currentCustomer != null)
            {
                if (MessageBox.Show("Вы уверены что хотите очистить корзину?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _currentCustomer.Cart.Items.Clear();
                    UpdateCustomer();
                }
            }
        }

        /// <summary>
        /// Обновление стоимости корзины.
        /// </summary>
        private void UpdateAmount()
        {
            AmountLabel.Text = _currentCustomer.Cart.Amount.ToString("C2");
        }

        /// <summary>
        /// Создание заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateOrderBtn_Click(object sender, EventArgs e)
        {
            if (_currentCustomer != null && _currentCustomer.Cart.Items.Count > 0)
            {
                if (_currentCustomer.IsPriority)
                {
                    _currentCustomer.Orders.Add(new PriorityOrder(_currentCustomer.Address, _currentCustomer.Cart.Items));
                }
                else
                {
                    _currentCustomer.Orders.Add(new Order(_currentCustomer.Address, _currentCustomer.Cart.Items));
                }
                _currentCustomer.Cart.Items.Clear();
                UpdateCustomer();
            }
            else
            {
                MessageBox.Show("Добавьте предметы в корзину для формирования заказа!","Предупреждение",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}