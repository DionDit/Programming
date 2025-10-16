using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class DiscountsTab : UserControl
    {
        private PercentDiscount PointsDiscount;

        private Order Order;
        public DiscountsTab()
        {
            InitializeComponent();
            PointsDiscount = new PercentDiscount(Category.KITCHEN_APPLIANCES);
            Order = AppData.Customers[0].Orders[0];
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            OrderAmount.Text = Order.Amount.ToString("C2");
            DiscountAmount.Text = PointsDiscount.DiscountPercent.ToString("C2");
            Info.Text = PointsDiscount.Info;
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            PointsDiscount.Calculate(Order.Items);
            UpdateLabels();
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            PointsDiscount.Apply(Order.Items);
            UpdateLabels();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            PointsDiscount.Update(Order.Items);
            UpdateLabels();
        }
    }
}
