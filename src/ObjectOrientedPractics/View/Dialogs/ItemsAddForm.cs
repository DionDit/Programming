using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Dialogs
{
    public partial class ItemsAddForm : Form
    {
        /// <summary>
        /// Добавляемый предмет.
        /// </summary>
        private Item _currentItem;

        public ItemsAddForm()
        {
            InitializeComponent();
            _currentItem = new Item();
        }

        /// <summary>
        /// Изменение введённой цены. 
        /// </summary>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Cost = Convert.ToDouble(CostTextBox.Text);
                CostTextBox.BackColor = AppColors.BaseInput;
            }
            catch
            {
                CostTextBox.BackColor = AppColors.ErrorInput;
            }
        }

        /// <summary>
        /// Изменение введённого названия. 
        /// </summary>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Name = NameTextBox.Text;
                NameTextBox.BackColor = AppColors.BaseInput;
            }
            catch
            {
                NameTextBox.BackColor = AppColors.ErrorInput;
            }
        }

        /// <summary>
        /// Изменение введённого описания. 
        /// </summary>
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Information = DescriptionTextBox.Text;
                DescriptionTextBox.BackColor = AppColors.BaseInput;
            }
            catch
            {
                DescriptionTextBox.BackColor = AppColors.ErrorInput;
            }
        }

        /// <summary>
        /// Добавление нового предмета.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            AppData.Items.Add(new Item(NameTextBox.Text,DescriptionTextBox.Text,Convert.ToDouble(CostTextBox.Text)));
            DialogResult = DialogResult.OK;
        }
    }
}