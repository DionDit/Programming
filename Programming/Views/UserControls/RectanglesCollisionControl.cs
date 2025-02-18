using Programming.Models.Geometry;
using Programming.Models;
using Programming.Properties;
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
    public partial class RectanglesCollisionControl : UserControl
    {
        #region Fields
        private List<Panel> _rectanglePanels;
        private Models.Rectangle _currentRectangle;
        #endregion
        public RectanglesCollisionControl()
        {
            _rectanglePanels = new List<Panel>();
            InitializeComponent();
            UpdateRectangleListBox();
        }

        private void RectangleAdd_MouseMove(object sender, MouseEventArgs e)
        {
            RectangleAdd.BackColor = AppColors.BaseInput;
            RectangleAdd.BackgroundImage = Resources.RecAdd2;
        }

        private void RectangleAdd_MouseLeave(object sender, EventArgs e)
        {
            RectangleAdd.BackColor = AppColors.BaseInput;
            RectangleAdd.BackgroundImage = Resources.RecAdd1;

        }

        private void RectangleRemove_MouseLeave(object sender, EventArgs e)
        {
            RectangleRemove.BackgroundImage = Resources.RecRemove1;
        }

        private void RectangleRemove_MouseMove(object sender, MouseEventArgs e)
        {
            RectangleRemove.BackgroundImage = Resources.RecRemove2;

        }

        private void RectangleAdd_Click(object sender, EventArgs e)
        {
            Rectangle.Rectangles.Add(RectangleFactory.Randomize(15, RectanglePanel));
            UpdateRectangleListBox();
            RectangleBox.SelectedIndex = RectangleBox.Items.Count - 1;
        }
        private void RectangleRemove_Click(object sender, EventArgs e)
        {
            Rectangle.Rectangles.Remove(_currentRectangle);
            UpdateRectangleListBox();
            _currentRectangle = null;
            RectangleBox.SelectedIndex = RectangleBox.Items.Count - 1;
        }
        private void UpdateRectangleListBox()
        {
            RectangleBox.Items.Clear();
            Rectangle.Rectangles.ForEach((x) =>
            {
                RectangleBox.Items.Add(x);
            });
            RectangleBox.SelectedItem = _currentRectangle;
            UpdateRectanglePanel();
            UpdatePropertyTextBox();
            FindCollisions();

        }
        private void UpdateRectanglePanel()
        {

            RectanglePanel.Controls.Clear();
            _rectanglePanels.Clear();
            Rectangle.Rectangles.ForEach((x) =>
            {
                _rectanglePanels.Add(new Panel()
                {
                    Width = Convert.ToInt32(x.Width),
                    Height = Convert.ToInt32(x.Height),
                    Location = new Point(Convert.ToInt32(x.Center.X), Convert.ToInt32(x.Center.Y)),
                });
            });
            _rectanglePanels.ForEach(x => RectanglePanel.Controls.Add(x));
        }
        private void FindCollisions()
        {
            foreach (Control item in RectanglePanel.Controls)
            {
                item.BackColor = AppColors.RectangleBase;
            }

            for (int i = 0; i < Rectangle.Rectangles.Count; i++)
            {
                for (int j = i + 1; j < Rectangle.Rectangles.Count; j++)
                {

                    if (CollisionManager.IsCollision(Rectangle.Rectangles[i], Rectangle.Rectangles[j]))
                    {
                        RectanglePanel.Controls[i].BackColor = AppColors.RectangleCollision;
                        RectanglePanel.Controls[j].BackColor = AppColors.RectangleCollision;
                    }
                }
            }

        }
        private void UpdatePropertyTextBox()
        {
            if (RectangleBox.SelectedItem != null)
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
            RectangleIdTextBox.Text = rectangle.Id.ToString();
            RectangleXTextBox.Text = rectangle.Center.X.ToString();
            RectangleYTextBox.Text = rectangle.Center.Y.ToString();
            RectangleWidthTextBox.Text = rectangle.Width.ToString();
            RectangleHeightTextBox.Text = rectangle.Height.ToString();
        }
        private void ClearRectangleInfo()
        {
            RectangleIdTextBox.Text = string.Empty;
            RectangleXTextBox.Text = string.Empty;
            RectangleYTextBox.Text = string.Empty;
            RectangleWidthTextBox.Text = string.Empty;
            RectangleHeightTextBox.Text = string.Empty;
        }
        private void RectangleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = RectangleBox.SelectedItem as Rectangle;
            UpdatePropertyTextBox();
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Rectangle.Rectangles.Where(x => x == _currentRectangle).FirstOrDefault().Width = Convert.ToInt32(RectangleWidthTextBox.Text);
                RectangleWidthTextBox.BackColor = AppColors.BaseInput;
                UpdateRectangleListBox();
            }
            catch
            {
                if (RectangleBox.Items.Count > 0)
                {
                    RectangleWidthTextBox.BackColor = AppColors.ErrorInput;
                }
            }
        }

        private void RectangleHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Rectangle.Rectangles.Where(x => x == _currentRectangle).FirstOrDefault().Height = Convert.ToInt32(RectangleHeightTextBox.Text);
                RectangleHeightTextBox.BackColor = AppColors.BaseInput;
                UpdateRectangleListBox();
            }
            catch
            {
                if (RectangleBox.Items.Count > 0)
                {
                    RectangleHeightTextBox.BackColor = AppColors.ErrorInput;
                }
            }
        }
        private void InputData(object sender, KeyPressEventArgs e)
        {
            Validator.InterdictionInputData(sender, e);
        }
    }
}
