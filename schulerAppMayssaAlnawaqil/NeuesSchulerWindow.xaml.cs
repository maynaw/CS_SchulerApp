using Microsoft.Win32;
using schulerAppMayssaAlnawaqil.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace schulerAppMayssaAlnawaqil
{
    /// <summary>
    /// Interaktionslogik für NeuesSchulerWindow.xaml
    /// </summary>
    public partial class NeuesSchulerWindow : Window
    {
        public NeuesSchulerWindow()
        {
            InitializeComponent();
        }

        private void ButtonNeuesSchuler_Click(object sender, RoutedEventArgs e)
        {
            SchulerViewModel vm = this.DataContext as SchulerViewModel;
            vm.AddSchuler();
            this.Close();
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            neuesSchulerStackPanel.Background = Brushes.LightBlue;
        }

        private void ToggleButton_Checked_1(object sender, RoutedEventArgs e)
        {
            neuesSchulerStackPanel.Background = Brushes.LightPink;

        }

        private void upload1_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.bmp;*.jpg;*.png";
            if(openFileDialog.ShowDialog() == true)
            {
                imagePicture.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }
        }
    }
}
