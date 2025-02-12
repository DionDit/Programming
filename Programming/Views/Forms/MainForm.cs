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
using Rectangle = Programming.Models.Rectangle;

namespace Programming.Views.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SeasonCB.DataSource = Enum.GetValues(typeof(Season));
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

        private void WeekDayParseButtonClick(object sender, EventArgs e)
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

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            switch (SeasonCB.SelectedIndex)
            {
                case 0:
                    BackColor = System.Drawing.Color.Yellow;
                    MessageBox.Show("Ура! Солнце!", "Лето", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    BackColor = System.Drawing.Color.Orange;
                    MessageBox.Show("О нет! Листья падают!", "Осень", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break; 
                case 2:
                    BackColor = System.Drawing.Color.Blue;
                    MessageBox.Show("Бррр! Холодно!", "Зима", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 3:
                    BackColor = System.Drawing.Color.Green;
                    MessageBox.Show("Ураа! Птички вернулись!", "Весна", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
    }
}
