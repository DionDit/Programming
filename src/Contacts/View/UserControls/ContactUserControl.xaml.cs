using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using View.ViewModels;

namespace View.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ContactUserControl.xaml
    /// </summary>
    public partial class ContactUserControl : UserControl
    {
        public ContactUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Фильтрация вставки из буфера обмена
        /// </summary>
        private void TextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                if (!new Regex(@"^[0-9+\-\(\)]+$").IsMatch((string)e.DataObject.GetData(typeof(string))))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }

        /// <summary>
        /// Обработчик клика по фото
        /// </summary>
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var viewModel = Window.GetWindow(this)?.DataContext as MainWindowViewModel;

            if (viewModel?.SelectPhotoCommand?.CanExecute(null) == true)
            {
                viewModel.SelectPhotoCommand.Execute(null);
            }
        }
    }
}
