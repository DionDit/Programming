using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Interfaces;
using ObjectOrientedPractics.Model.Orders;
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
            DiscountCheckedListBox.ItemCheck += DiscountCheckedListBox_ItemCheck;
            UpdateUI();
        }

        private void DiscountCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e) => BeginInvoke(new Action(UpdateDiscountAndTotal));

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

                DiscountCheckedListBox.Items.Clear();
                _currentCustomer.Discounts.ForEach(x => DiscountCheckedListBox.Items.Add(x));

                for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
                {
                    DiscountCheckedListBox.SetItemChecked(i, true);
                }

                UpdateDiscountAndTotal();
            }
        }

        /// <summary>
        /// Обновление размера скидки и итоговую стоимость при изменении выбранных скидок.
        /// </summary>
        private void UpdateDiscountAndTotal()
        {
            if (_currentCustomer == null) return;

            double totalDiscount = 0;

            for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
            {
                if (DiscountCheckedListBox.GetItemChecked(i))
                {
                    var discount = DiscountCheckedListBox.Items[i];

                    if (discount is PointsDiscount pointsDiscount)
                    {
                        totalDiscount += pointsDiscount.Calculate(_currentCustomer.Cart.Items);
                    }
                    else if (discount is PercentDiscount percentDiscount)
                    {
                        totalDiscount += percentDiscount.Calculate(_currentCustomer.Cart.Items);
                    }
                }
            }

            UpdateAmountDisplay(totalDiscount);
        }

        /// <summary>
        /// Обновляет отображение сумм в интерфейсе.
        /// </summary>
        /// <param name="discountAmount">Размер общей скидки.</param>
        private void UpdateAmountDisplay(double discountAmount)
        {
            if (_currentCustomer != null)
            {
                double cartAmount = _currentCustomer.Cart.Amount;
                double totalAmount = cartAmount - discountAmount;

                AmountLabel.Text = cartAmount.ToString("C2");
                DiscountAmount.Text = discountAmount.ToString("C2");
                Total.Text = totalAmount >= 0 ? totalAmount.ToString("C2") : "0,00 ₽";

                DiscountAmount.ForeColor = discountAmount > 0 ? Color.Red : Color.Black;
            }
        }

        /// <summary>
        /// Обновляет все скидки покупателя после оформления заказа.
        /// </summary>
        /// <param name="items">Товары из заказа.</param>
        private void UpdateAllDiscounts(List<Item> items)
        {
            if (_currentCustomer != null)
            {
                foreach (var discount in _currentCustomer.Discounts)
                {
                    if (discount is PointsDiscount pointsDiscount)
                    {
                        pointsDiscount.Update(items);
                    }
                    else if (discount is PercentDiscount percentDiscount)
                    {
                        percentDiscount.Update(items);
                    }
                }
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
                UpdateDiscountAndTotal();
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
                if (MessageBox.Show("Вы уверены что хотите удалить данный предмет из корзины?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _currentCustomer.Cart.Items.Remove(CartListBox.SelectedItem as Item);
                    UpdateCustomer();
                    UpdateDiscountAndTotal();
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
                    UpdateDiscountAndTotal();
                }
            }
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
                double totalDiscount = 0;
                for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
                {
                    if (DiscountCheckedListBox.GetItemChecked(i))
                    {
                        var discount = DiscountCheckedListBox.Items[i];
                        if (discount is PointsDiscount pointsDiscount)
                        {
                            totalDiscount += pointsDiscount.Apply(_currentCustomer.Cart.Items);
                        }
                        else if (discount is PercentDiscount percentDiscount)
                        {
                            totalDiscount += percentDiscount.Apply(_currentCustomer.Cart.Items);
                        }
                    }
                }
                Order newOrder;
                if (_currentCustomer.IsPriority)
                {
                    newOrder = new PriorityOrder(_currentCustomer.Address, _currentCustomer.Cart.Items)
                    {
                        DiscountAmount = totalDiscount
                    };
                }
                else
                {
                    newOrder = new Order(_currentCustomer.Address, _currentCustomer.Cart.Items)
                    {
                        DiscountAmount = totalDiscount
                    };
                }
                _currentCustomer.Orders.Add(newOrder);
                UpdateAllDiscounts(_currentCustomer.Cart.Items);
                _currentCustomer.Cart.Items.Clear();
                UpdateCustomer();
                MessageBox.Show($"Заказ успешно создан!\nСкидка: {totalDiscount:C2}", "Заказ оформлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Добавьте предметы в корзину для формирования заказа!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}