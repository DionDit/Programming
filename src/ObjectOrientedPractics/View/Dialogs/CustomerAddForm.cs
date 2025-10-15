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
        /// Добавление нового покупателя.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (addressControl1.Address.IsFullyFilled)
            {
                try
                {
                    AppData.Customers.Add(new Customer(FullNameTextBox.Text, addressControl1.Address));
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Корректно заполните адрес покупателя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}