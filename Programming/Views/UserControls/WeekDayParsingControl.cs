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

namespace Programming.Views.UserControls
{
    public partial class WeekDayParsingControl : UserControl
    {
        public WeekDayParsingControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Проверка ввода дня недели.
        /// </summary>
        private void WeekDayParseButtonClick(object sender, EventArgs e)
        {
            Weekday outPut;
            if (Enum.TryParse(WeekDayTextBox.Text, true, out outPut))
            {
                WeekDayText.Text = $"Это день недели ({outPut} = {Convert.ToInt32(outPut)})";
            }
            else
            {
                WeekDayText.Text = $"Нет такого дня недели!";
            }
        }
    }
}
