using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            LoadData();
            InitializeComponent();
            ExitSaving.Checked = AppData.IsExitSaving;
            itemsTabs1.ItemsChanged += OnItemsChanged;
        }
        
        private void OnItemsChanged(object sender, EventArgs e)
        {
            RefreshTabs();
        }

        /// <summary>
        /// Обновляет данные на других вкладках.
        /// </summary>
        private void RefreshTabs()
        {
            cartsTab1.UpdateUI();
            ordersTab1.UpdateOrdersList(false);
        }

        private void LoadData()
        {
            ProjectSerializer.LoadData();

            if (AppData.Items.Count == 0)
            {
                CreateSampleData();
            }
        }

        private void CreateSampleData()
        {
            AppData.Items.Add(ItemFactory.CreateRandomItem());
            AppData.Customers.Add(CustomerFactory.CreateRandomCustomer());
        }

        private void ExitSaving_CheckedChanged(object sender, EventArgs e)
        {
            if (ExitSaving.Checked)
            {
                AppData.IsExitSaving = true;
                ProjectSerializer.EnableAutoSave(this);
            }
            else
            {
                AppData.IsExitSaving = false;
                ProjectSerializer.DisableAutoSave(this);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 2:
                    cartsTab1.UpdateUI();
                    break;
                case 3:
                    ordersTab1.UpdateOrdersList(false);
                    break;
            }
        }
    }
}