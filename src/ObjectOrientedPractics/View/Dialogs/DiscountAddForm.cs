using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Dialogs
{
    public partial class DiscountAddForm : Form
    {
        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _customer;
        public DiscountAddForm(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            CategoryComboBox.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());
            CategoryComboBox.Format += (s, e) =>
            {
                if (e.ListItem is Category category)
                {
                    e.Value = category.GetDisplayName();
                }
            };
            CategoryComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Добавление скидки.
        /// </summary>
        private void OkBtn_Click(object sender, EventArgs e)
        {
            _customer.Discounts.Add(new PercentDiscount((Category)CategoryComboBox.SelectedItem));
            MessageBox.Show("Вы успешно добавили скидку!","Успешно",MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        /// <summary>
        /// Закрытие окна.
        /// </summary>
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}