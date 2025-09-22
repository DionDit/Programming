using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Dialogs;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTabs : UserControl
    {
        /// <summary>
        /// Выбранный предмет.
        /// </summary>
        private Item _currentItem;

        public ItemsTabs()
        {
            InitializeComponent();
            UpdateUI();
        }

        /// <summary>
        /// Обновление графического интерфейса.
        /// </summary>
        private void UpdateUI()
        {
            ItemBox.Items.Clear();
            AppData.Items.ForEach(x => ItemBox.Items.Add(x));
        }

        /// <summary>
        /// Изменение полей ввода.
        /// </summary>
        private void UpdateTextProperty(Item item)
        {
            IdTextBox.Text = item.Id.ToString();
            NameTextBox.Text = item.Name;
            CostTextBox.Text = item.Cost.ToString();
            DescriptionTextBox.Text = item.Information;
        }

        /// <summary>
        /// Очистка полей ввода.
        /// </summary>
        private void ClearTextProperty()
        {
            IdTextBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            CostTextBox.Text = string.Empty;
            DescriptionTextBox.Text = string.Empty;
        }

        /// <summary>
        /// Выбор предмета.
        /// </summary>
        private void ItemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemBox.Items != null && ItemBox.SelectedItem != null)
            {
                _currentItem = ItemBox.SelectedItem as Item;
                UpdateTextProperty(_currentItem);
            }
        }

        /// <summary>
        /// Изменение цены предмета.
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
        /// Изменение названия предмета.
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
        /// Изменение описания предмета.
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
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (new ItemsAddForm().ShowDialog() == DialogResult.OK)
            {
                UpdateUI();
                MessageBox.Show("Вы добавили новый товар!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Удаление предмета.
        /// </summary>
        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (ItemBox.Items.Count > 0)
            {
                if (MessageBox.Show($"Вы уверены что хотите удалить {_currentItem.Name} | {_currentItem.Cost}руб.", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ClearTextProperty();
                    AppData.Items.Remove(_currentItem);
                    UpdateUI();
                    _currentItem = null;
                    NameTextBox.BackColor = AppColors.BaseInput;
                    CostTextBox.BackColor = AppColors.BaseInput;
                    DescriptionTextBox.BackColor = AppColors.BaseInput;
                }
            }
        }

        /// <summary>
        /// Запрет ввода данных.
        /// </summary>
        private void InputData(object sender, KeyPressEventArgs e)
        {
            ValueValidator.InterdictionInputData(sender, e);
        }

        private void AddRandomBtn_Click(object sender, EventArgs e)
        {
            AppData.Items.Add(ItemFactory.CreateRandomItem());
            UpdateUI();
            MessageBox.Show("Вы добавили случайно сгенерированный товар!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}