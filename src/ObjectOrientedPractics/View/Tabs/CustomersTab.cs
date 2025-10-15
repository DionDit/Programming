using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Dialogs;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        public CustomersTab()
        {
            InitializeComponent();
            UpdateUI();
        }

        /// <summary>
        /// Обновление графического интерфейса.
        /// </summary>
        private void UpdateUI()
        {
            CustomerListBox.Items.Clear();
            AppData.Customers.ForEach(x => CustomerListBox.Items.Add(x));
        }

        /// <summary>
        /// Изменение данных в полях ввода.
        /// </summary>
        private void UpdateTextProperty(Customer item)
        {
            IdTextBox.Text = item.Id.ToString();
            FullNameTextBox.Text = item.FullName;
            if (_currentCustomer.IsPriority)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }

        /// <summary>
        /// Очистка полей ввода.
        /// </summary>
        private void ClearTextProperty()
        {
            IdTextBox.Text = string.Empty;
            FullNameTextBox.Text = string.Empty;
        }

        /// <summary>
        /// Выбор покупателя.
        /// </summary>
        private void CustomerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerListBox.Items != null && CustomerListBox.SelectedItem != null)
            {
                _currentCustomer = CustomerListBox.SelectedItem as Customer;
                tableLayoutPanel5.Visible = true;
                UpdateTextProperty(_currentCustomer);
                addressControl1.Address = _currentCustomer.Address;

            }
        }

        /// <summary>
        /// Изменение полного имени покупателя.
        /// </summary>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.FullName = FullNameTextBox.Text;
                FullNameTextBox.BackColor = AppColors.BaseInput;
            }
            catch
            {
                FullNameTextBox.BackColor = AppColors.ErrorInput;
            }
        }

        /// <summary>
        /// Добавление нового покупателя.
        /// </summary>
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (new CustomerAddForm().ShowDialog() == DialogResult.OK)
            {
                UpdateUI();
                MessageBox.Show("Вы добавили нового покупателя!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Удаление выбранного покупателя.
        /// </summary>
        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (CustomerListBox.Items.Count > 0)
            {
                if (MessageBox.Show($"Вы уверены что хотите удалить {_currentCustomer.FullName}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ClearTextProperty();
                    AppData.Customers.Remove(_currentCustomer);
                    UpdateUI();
                    _currentCustomer = null;
                    FullNameTextBox.BackColor = AppColors.BaseInput;
                    tableLayoutPanel5.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Вы не можете выполнить данную операцию!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Запрет ввода данных.
        /// </summary>
        private void InputData(object sender, KeyPressEventArgs e)
        {
            ValueValidator.InterdictionInputData(sender, e);
        }

        /// <summary>
        /// Добавление случайного покупателя.
        /// </summary>
        private void AddRandomBtn_Click(object sender, EventArgs e)
        {
            AppData.Customers.Add(CustomerFactory.CreateRandomCustomer());
            UpdateUI();
            MessageBox.Show("Вы добавили случайного покупателя!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                _currentCustomer.IsPriority = true;
            }
            else
            {
                _currentCustomer.IsPriority = false;
            }
        }
    }
}