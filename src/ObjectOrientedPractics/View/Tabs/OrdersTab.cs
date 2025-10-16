using ObjectOrientedPractics.Model.Enums;
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
    public partial class OrdersTab : UserControl
    {
        private List<Order> _orders;
        private Order _currentOrder;
        private PriorityOrder _currentPriorityOrder;

        public OrdersTab()
        {
            InitializeComponent();
            InitializeDataGridView();
            UpdateOrdersList(PriorityOrderCheckBox.Checked);

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
            OrdersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            OrdersDataGridView.MultiSelect = false;
            OrdersDataGridView.AllowUserToResizeRows = false;
            OrdersDataGridView.AllowUserToOrderColumns = false;
            OrdersDataGridView.AllowUserToResizeColumns = true;

            var columns = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "PriorityColumn",
                    HeaderText = "",
                    Width = 30,
                    DefaultCellStyle = new DataGridViewCellStyle()
                    {
                        Alignment = DataGridViewContentAlignment.MiddleCenter,
                        Font = new Font("Arial", 14, FontStyle.Bold),
                        ForeColor = Color.Gold
                    }
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "IdColumn",
                    HeaderText = "Id",
                    DataPropertyName = "Id",
                    Width = 50,
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
                new DataGridViewTextBoxColumn()
                {
                    Name = "TotalAmountColumn",
                    HeaderText = "TotalAmount",
                    DataPropertyName = "TotalAmount",
                    Width = 100,
                    DefaultCellStyle = new DataGridViewCellStyle()
                    {
                        Format = "C2"
                    },
                },

            };

            OrdersDataGridView.Columns.AddRange(columns);
            OrdersDataGridView.CellFormatting += OrdersDataGridView_CellFormatting;

        }

        /// <summary>
        /// Обрабатывает форматирование ячеек DataGridView для отображения приоритетных заказов.
        /// </summary>
        private void OrdersDataGridView_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == OrdersDataGridView.Columns["PriorityColumn"].Index)
            {
                var order = OrdersDataGridView.Rows[e.RowIndex].DataBoundItem as Order;
                if (order is PriorityOrder)
                {
                    e.Value = "★";
                    e.FormattingApplied = true;
                }
                else
                {
                    e.Value = "";
                    e.FormattingApplied = true;
                }
            }
        }

        /// <summary>
        /// Обновление списка заказов
        /// </summary>
        public void UpdateOrdersList(bool IsPriority)
        {
            var allOrders = new List<Order>();
            AppData.Customers.ForEach(x => x.Orders.ForEach(y => allOrders.Add(y)));

            if (IsPriority)
            {
                _orders = allOrders.Where(order => order is PriorityOrder).ToList();
            }
            else
            {
                _orders = allOrders;
            }

            OrdersDataGridView.DataSource = _orders;

            OrdersDataGridView.Refresh();
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
            if (_currentOrder is PriorityOrder priorityOrder)
            {
                _currentPriorityOrder = priorityOrder;
                PriorityLabel.Visible = true;
                DeliveryTimeLabel.Visible = true;
                DeliveryTimeComboBox.Visible = true;
                DeliveryTimeComboBox.SelectedItem = _currentPriorityOrder.DeliveryTime;
            }
            else
            {
                _currentPriorityOrder = null;
                PriorityLabel.Visible = false;
                DeliveryTimeLabel.Visible = false;
                DeliveryTimeComboBox.Visible = false;
            }

            IdTextBox.Text = _currentOrder.Id.ToString();
            CreatedTextBox.Text = _currentOrder.CreationDate.ToString("F");
            StatusComboBox.SelectedItem = _currentOrder.OrderStatus;
            addressControl1.Address = _currentOrder.Address;
            addressControl1.AllReadOnly();
            AmountLabel.Text = _currentOrder.Amount.ToString("C2");
            TotalAmount.Text = _currentOrder.TotalAmount.ToString("C2");

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
                UpdateOrdersList(PriorityOrderCheckBox.Checked);
            }
        }

        /// <summary>
        /// Изменение времени доставки.
        /// </summary>
        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPriorityOrder.DeliveryTime = DeliveryTimeComboBox.SelectedItem?.ToString();
        }

        /// <summary>
        /// Показать только приоритетные заказы.
        /// </summary>
        private void PriorityOrderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrdersList(PriorityOrderCheckBox.Checked);
        }
    }
}