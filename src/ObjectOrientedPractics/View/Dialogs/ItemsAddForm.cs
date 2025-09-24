using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
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

            CategoryComboBox.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());

            CategoryComboBox.SelectedIndex = 0;
            CategoryComboBox.Format += (s, e) =>
            {
                if (e.ListItem is Category category)
                {
                    e.Value = category.GetDisplayName();
                }
            };
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
            AppData.Items.Add(new Item(NameTextBox.Text,DescriptionTextBox.Text,Convert.ToDouble(CostTextBox.Text),(Category)CategoryComboBox.SelectedIndex));
            DialogResult = DialogResult.OK;
        }
    }
}