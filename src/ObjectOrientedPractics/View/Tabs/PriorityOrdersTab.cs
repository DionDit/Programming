using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
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
    public partial class PriorityOrdersTab : UserControl
    {
        private Random rnd = new Random();
        public PriorityOrdersTab()
        {
            InitializeComponent();
            StatusComboBox.Items.AddRange(Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray());
            StatusComboBox.Format += (s, e) =>
            {
                if (e.ListItem is OrderStatus orderStatus)
                {
                    e.Value = orderStatus.GetDisplayName();
                }
            };
            DeliveryTimeComboBox.SelectedIndex = 0;
            StatusComboBox.SelectedIndex = 0;
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            OrderItemsListBox.Items.Add(AppData.Items[rnd.Next(AppData.Items.Count)]);
            UpdateAmount();
        }

        /// <summary>
        /// Удалить предмет из заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemBtn_Click(object sender, EventArgs e)
        {
            if (OrderItemsListBox.SelectedItem != null)
            {
                if (MessageBox.Show("Вы уверены что хотите удалить данный предмет из корзины?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    OrderItemsListBox.Items.Remove(OrderItemsListBox.SelectedItem);
                    UpdateAmount();
                }
            }
        }

        /// <summary>
        /// Отчистить заказ.
        /// </summary>
        private void ClearCartBtn_Click(object sender, EventArgs e)
        {
            if (OrderItemsListBox.Items.Count > 0)
            {
                if (MessageBox.Show("Вы уверены что хотите очистить корзину?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    OrderItemsListBox.Items.Clear();
                    UpdateAmount();
                }
            }
        }

        /// <summary>
        /// Обновление стоимости корзины.
        /// </summary>
        private void UpdateAmount()
        {
            AmountLabel.Text = OrderItemsListBox.Items.Cast<Item>().Sum(x => x.Cost).ToString("C2");
        }

        /// <summary>
        /// Запрет ввода данных.
        /// </summary>
        private void InputData(object sender, KeyPressEventArgs e) => ValueValidator.InterdictionInputData(sender, e);
    }
}