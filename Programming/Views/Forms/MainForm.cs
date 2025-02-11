using Programming.Models;
using Programming.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Views.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EnumListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            switch ((sender as ListBox).SelectedIndex)
            {
                case 0:
                    ValueListBox.DataSource = Enum.GetValues(typeof(Models.Enums.Color));
                    break;
                case 1:
                    ValueListBox.DataSource = Enum.GetValues(typeof(FormStudyStudent));
                    break;
                case 2:
                    ValueListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;
                case 3:
                    ValueListBox.DataSource = Enum.GetValues(typeof(Season));
                    break;
                case 4:
                    ValueListBox.DataSource = Enum.GetValues(typeof(SmartphoneManufacturers));
                    break;
                case 5:
                    ValueListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
            }
        }

        private void ValueListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            EnumValue.Text = Convert.ToInt32(ValueListBox.SelectedValue).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Weekday OutPut;
            if (Enum.TryParse(WeekDayTextBox.Text, true , out OutPut))
            {
                WeekDayText.Text = $"Это день недели ({OutPut} = {Convert.ToInt32(OutPut)})";
            }
            else
            {
                WeekDayText.Text = $"Нет такого дня недели!";
            }
        }
    }
}
