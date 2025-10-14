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
    public partial class OrdersTab : UserControl
    {
        private List<Order> _orders;
        private Order _currentOrder;
        public OrdersTab()
        {
            InitializeComponent();
            InitializeDataGridView();
            UpdateOrdersList();

            StatusComboBox.Items.AddRange(Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray());
            StatusComboBox.Format += (s, e) =>
            {
                if (e.ListItem is OrderStatus orderStatus)
                {
                    e.Value = orderStatus.GetDisplayName();
                }
            };
        }

        /// <summary>
        /// Инициализация DataGridView
        /// </summary>
        private void InitializeDataGridView()
        {
            OrdersDataGridView.RowHeadersVisible = false;
            OrdersDataGridView.AutoGenerateColumns = false;
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToDeleteRows = false;
            OrdersDataGridView.ReadOnly = true;
            //OrdersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            OrdersDataGridView.MultiSelect = false;
            OrdersDataGridView.AllowUserToResizeRows = false;
            OrdersDataGridView.AllowUserToOrderColumns = false;
            OrdersDataGridView.AllowUserToResizeColumns = true;

            var columns = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "IdColumn",
                    HeaderText = "Id",
                    DataPropertyName = "Id",
                    Width = 50,
                    SortMode = DataGridViewColumnSortMode.Automatic

                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "CreationDateColumn",
                    HeaderText = "Created",
                    DataPropertyName = "CreationDate",
                    Width = 150,
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "StatusColumn",
                    HeaderText = "Order status",
                    DataPropertyName = "OrderStatus",
                    Width = 150,
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "CustomerNameColumn",
                    HeaderText = "Customer Full Name",
                    DataPropertyName = "CustomerName",
                    Width = 200,
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "AddressColumn",
                    HeaderText = "Address",
                    DataPropertyName = "AddressString",
                    Width = 250,
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "AmountColumn",
                    HeaderText = "Amount",
                    DataPropertyName = "Amount",
                    Width = 100,
                    DefaultCellStyle = new DataGridViewCellStyle()
                    {
                        Format = "C2"
                    },
                },

            };

            OrdersDataGridView.Columns.AddRange(columns);
        }

        /// <summary>
        /// Обновление списка заказов
        /// </summary>
        public void UpdateOrdersList()
        {
            var allOrders = new List<Order>();
            AppData.Customers.ForEach(x => x.Orders.ForEach(y => allOrders.Add(y)));

            _orders = allOrders;
            OrdersDataGridView.DataSource = _orders;
        }

        /// <summary>
        /// Изменение выбранной строки
        /// </summary>
        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.SelectedRows.Count > 0)
            {
                _currentOrder = OrdersDataGridView.SelectedRows[0].DataBoundItem as Order;
                if (_currentOrder != null)
                {
                    UpdateOrderDetails();
                }
            }
        }

        /// <summary>
        /// Обновление деталей заказа.
        /// </summary>
        private void UpdateOrderDetails()
        {
            IdTextBox.Text = _currentOrder.Id.ToString();
            CreatedTextBox.Text = _currentOrder.CreationDate.ToString("F");
            StatusComboBox.SelectedItem = _currentOrder.OrderStatus;
            addressControl1.Address = _currentOrder.Address;
            addressControl1.AllReadOnly();
            AmountLabel.Text = _currentOrder.Amount.ToString("C2");

            OrderItemsListBox.Items.Clear();

            _currentOrder.Items.ForEach(x => OrderItemsListBox.Items.Add(x));
        }

        /// <summary>
        /// Запрет ввода данных.
        /// </summary>
        private void InputData(object sender, KeyPressEventArgs e) => ValueValidator.InterdictionInputData(sender, e);

        /// <summary>
        /// Изменение статуса заказа.
        /// </summary>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e) => _currentOrder.OrderStatus = (OrderStatus)StatusComboBox.SelectedIndex;

        /// <summary>
        /// Поиск.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                OrdersDataGridView.DataSource = _orders.Where(x =>
                                    x.CustomerName.ToLower().Contains(textBox1.Text) ||
                                    x.OrderStatus.ToString().ToLower().Contains(textBox1.Text) ||
                                    x.AddressString.ToLower().Contains(textBox1.Text) ||
                                    x.Id.ToString().Contains(textBox1.Text) ||
                                    x.Amount.ToString("C2").ToLower().Contains(textBox1.Text) ||
                                    x.CreationDate.ToString("dd.MM.yyyy HH:mm").Contains(textBox1.Text) ||
                                    x.Items.Any(item => item.Name.ToLower().Contains(textBox1.Text))).ToList();         
            }
            else
            {
                UpdateOrdersList();
            }
        }
    }
}