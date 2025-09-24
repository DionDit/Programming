using ObjectOrientedPractics.Model;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address = new Address();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Address Address
        {
            get => _address;
            set
            {
                _address = value;
                UpdateTextProperty();
            }
        }

        public AddressControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Изменение данных в полях ввода.
        /// </summary>
        private void UpdateTextProperty()
        {
            IndexTextBox.Text = Address.Index.ToString();
            CountryTextBox.Text = Address.Country;
            CityTextBox.Text = Address.City;
            StreetTextBox.Text = Address.Street;
            BuildingTextBox.Text = Address.Building;
            ApartmentTextBox.Text = Address.Apartment;

        }

        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Index = Convert.ToInt32(IndexTextBox.Text);
                IndexTextBox.BackColor = AppColors.BaseInput;
            }
            catch
            {
                IndexTextBox.BackColor = AppColors.ErrorInput;
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Country = CountryTextBox.Text;
                CountryTextBox.BackColor = AppColors.BaseInput;
            }
            catch
            {
                CountryTextBox.BackColor = AppColors.ErrorInput;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.City = CityTextBox.Text;
                CityTextBox.BackColor = AppColors.BaseInput;
            }
            catch
            {
                CityTextBox.BackColor = AppColors.ErrorInput;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Street = StreetTextBox.Text;
                StreetTextBox.BackColor = AppColors.BaseInput;
            }
            catch
            {
                StreetTextBox.BackColor = AppColors.ErrorInput;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Building = BuildingTextBox.Text;
                BuildingTextBox.BackColor = AppColors.BaseInput;
            }
            catch
            {
                BuildingTextBox.BackColor = AppColors.ErrorInput;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Apartment = ApartmentTextBox.Text;
                ApartmentTextBox.BackColor = AppColors.BaseInput;
            }
            catch
            {
                ApartmentTextBox.BackColor = AppColors.ErrorInput;
            }
        }
    }
}
