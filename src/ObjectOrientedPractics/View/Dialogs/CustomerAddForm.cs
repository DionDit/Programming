using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Dialogs
{
    public partial class CustomerAddForm : Form
    {
        /// <summary>
        /// Добавляемый покупатель.
        /// </summary>
        private Customer _currentCustomer;
        public CustomerAddForm()
        {
            InitializeComponent();
            _currentCustomer = new Customer();
        }

        /// <summary>
        /// Изменение введённого имени. 
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
        /// Изменение введённого адреса. 
        /// </summary>
        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.Address = AddressTextBox.Text;
                AddressTextBox.BackColor = AppColors.BaseInput;
            }
            catch
            {
                AddressTextBox.BackColor = AppColors.ErrorInput;
            }
        }

        /// <summary>
        /// Добавление нового покупателя.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            AppData.Customers.Add(new Customer(FullNameTextBox.Text, AddressTextBox.Text));
            DialogResult = DialogResult.OK;
        }
    }
}