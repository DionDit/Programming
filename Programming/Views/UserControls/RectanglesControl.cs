using Programming.Models;
using Programming.Models.Geometry;
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

namespace Programming.Views.UserControls
{
    public partial class RectanglesControl : UserControl
    {
        private Rectangle _currentRectangle;
        public RectanglesControl()
        {
            InitializeComponent();
            RectanglesBox.DataSource = Rectangle.Rectangles;
        }
        private void RectanglesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle = RectanglesBox.SelectedItem as Rectangle;
                UpdatePropertyTextBox();
            }
            catch
            {
            }
            
        }
        private void UpdatePropertyTextBox()
        {
            if (RectanglesBox.SelectedItem != null)
            {
                UpdateRectangleInfo(_currentRectangle);
            }
            else
            {
                ClearRectangleInfo();
            }

        }
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            LenghtTextBox.Text = _currentRectangle.Height.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString();
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }
        private void ClearRectangleInfo()
        {
            WidthTextBox.Text = string.Empty;
            LenghtTextBox.Text = string.Empty;
            ColorTextBox.Text = string.Empty;
            XTextBox.Text = string.Empty;
            YTextBox.Text = string.Empty;
            IdTextBox.Text = string.Empty;
        }
        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (RectanglesBox.SelectedItem as Rectangle).Height = Convert.ToInt32(LenghtTextBox.Text);
                LenghtTextBox.BackColor = AppColors.BaseInput;

            }
            catch
            {
                LenghtTextBox.BackColor = AppColors.ErrorInput;
            }
        }
        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (RectanglesBox.SelectedItem as Rectangle).Width = Convert.ToInt32(WidthTextBox.Text);
                WidthTextBox.BackColor = AppColors.BaseInput;

            }
            catch
            {
                WidthTextBox.BackColor = AppColors.ErrorInput;
            }
        }
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((Models.Enums.Color)Enum.Parse(typeof(Models.Enums.Color), ColorTextBox.Text) != null)
                {
                    (RectanglesBox.SelectedItem as Rectangle).Color = ColorTextBox.Text;
                    ColorTextBox.BackColor = AppColors.BaseInput;
                }
            }
            catch
            {
                ColorTextBox.BackColor = AppColors.ErrorInput;
            }
        }
        private int FindRectangleWithMaxWidth(List<Rectangle> Rectangles)
        {
            double maxWidth = 0;
            int Index = 0;
            for (int i = 0; i < Rectangles.Count; i++)
            {
                if (Rectangles[i].Width > maxWidth)
                {
                    maxWidth = Rectangles[i].Width;
                    Index = i;
                }
            }
            return Index;
        }
        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            RectanglesBox.SelectedIndex = FindRectangleWithMaxWidth(Rectangle.Rectangles);
            _currentRectangle = RectanglesBox.SelectedItem as Rectangle;
        }
        private void InputData(object sender, KeyPressEventArgs e)
        {
            Validator.InterdictionInputData(sender, e);
        }
    }
}
