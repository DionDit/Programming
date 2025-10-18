using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
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

            ItemSortComboBox.SelectedIndex = 0;
            CategoryComboBox.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());
            CategoryComboBox.Format += (s, e) =>
            {
                if (e.ListItem is Category category)
                {
                    e.Value = category.GetDisplayName();
                }
            };
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
            CategoryComboBox.SelectedIndex = Convert.ToInt32(item.Category);
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
                tableLayoutPanel4.Visible = true;
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
                    tableLayoutPanel4.Visible = false;
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
        private void InputData(object sender, KeyPressEventArgs e) => ValueValidator.InterdictionInputData(sender, e);

        /// <summary>
        /// Добавление нового товара.
        /// </summary>
        private void AddRandomBtn_Click(object sender, EventArgs e)
        {
            AppData.Items.Add(ItemFactory.CreateRandomItem());
            UpdateUI();
            MessageBox.Show("Вы добавили случайно сгенерированный товар!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /// <summary>
        /// Изменение категории товара.
        /// </summary>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e) => _currentItem.Category = (Category)CategoryComboBox.SelectedIndex;

        /// <summary>
        /// Обработчик изменения текста в поисковой строке.
        /// </summary>
        private void SearchItemTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }

        /// <summary>
        /// Применяет фильтр поиска к списку товаров.
        /// </summary>
        private void ApplySearchFilter()
        {
            string searchText = SearchItemTextBox.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                ItemBox.Items.Clear();
                SortItems(AppData.Items).ForEach(x => ItemBox.Items.Add(x));
            }
            else
            {
                var filteredItems = DataTools.FilterItems(AppData.Items, CreateSearchFilter(searchText));
                SortItems(filteredItems);

                ItemBox.Items.Clear();
                filteredItems.ForEach(x => ItemBox.Items.Add(x));
            }
        }
        
        /// <summary>
        /// Сортировка списка товаров.
        /// </summary>
        private List<Item> SortItems(List<Item> items)
        {
            var sortItems = new List<Item>();
            if (items.Count != 0)
            {
                switch (ItemSortComboBox.SelectedIndex)
                {
                    case 0:
                        sortItems = DataTools.SortItems(items, DataTools.SortByName);
                        break;
                    case 1:
                        sortItems = DataTools.SortItems(items, DataTools.SortByCostAscending);
                        break;
                    case 2:
                        sortItems = DataTools.SortItems(items, DataTools.SortByCostDescending);
                        break;
                }
            }
            return sortItems;
        }

        /// <summary>
        /// Делегат фильтрации для поиска по подстроке в имени товара.
        /// </summary>
        private ItemFilterDelegate CreateSearchFilter(string searchText) => item => item.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0;

        /// <summary>
        /// Выбор способа сортировки.
        /// </summary>
        private void ItemSortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }
    }
}