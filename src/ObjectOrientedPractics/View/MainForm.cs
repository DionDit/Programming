using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            LoadData();
            InitializeComponent();
            ExitSaving.Checked = AppData.IsExitSaving;
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
            // Тестовые данные
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
                    ordersTab1.UpdateOrdersList();
                    break;
            }
        }
    }
}