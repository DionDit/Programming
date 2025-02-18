using Programming.Models;
using Programming.Models.Enums;
using Programming.Models.Geometry;
using Programming.Properties;
using Programming.Views.UserControls;
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
            for (int i = 0; i < 10; i++)
            {
                Rectangle.Rectangles.Add(RectangleFactory.Randomize());
            }
            InitializeComponent();
            SeasonControl.SeasonChanged += SeasonControl_SeasonChanged;
        }

        /// <summary>
        /// Событие возникающие при выборе времени года.
        /// </summary>
        private void SeasonControl_SeasonChanged(object sender, int e)
        {
            switch (e)
            {
                case 0:
                    this.BackColor = AppColors.Summer;
                    tabPage1.BackColor = AppColors.Summer;
                    MessageBox.Show("Ура! Солнце!", "Лето", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;
                case 1:
                    this.BackColor = AppColors.Autumn;
                    tabPage1.BackColor = AppColors.Autumn;
                    MessageBox.Show("О нет! Листья падают!", "Осень", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    this.BackColor = AppColors.Winter;
                    tabPage1.BackColor = AppColors.Winter;
                    MessageBox.Show("Бррр! Холодно!", "Зима", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 3:
                    this.BackColor = AppColors.Spring;
                    tabPage1.BackColor = AppColors.Spring;
                    MessageBox.Show("Ураа! Птички вернулись!", "Весна", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
    }
}
