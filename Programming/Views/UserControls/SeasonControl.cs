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

namespace Programming.Views.UserControls
{
    public partial class SeasonControl : UserControl
    {
        public event EventHandler<int> SeasonChanged;

        public SeasonControl()
        {
            InitializeComponent();
            SeasonCB.DataSource = Enum.GetValues(typeof(Season));
        }
        private void SeasonButton_Click(object sender, EventArgs e)
        {
            switch (SeasonCB.SelectedIndex)
            {
                case 0:
                    OnSeasonChanged(0);
                    break;
                case 1:
                    OnSeasonChanged(1);
                    break;
                case 2:
                    OnSeasonChanged(2);
                    break;
                case 3:
                    OnSeasonChanged(3);
                    break;
            }
        }
        protected virtual void OnSeasonChanged(int season)
        {
            SeasonChanged?.Invoke(this, season);
        }
    }
}
