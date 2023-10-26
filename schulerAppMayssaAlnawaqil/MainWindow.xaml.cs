using schulerAppMayssaAlnawaqil.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace schulerAppMayssaAlnawaqil
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SchulerViewModel vm = new SchulerViewModel();
        public MainWindow()
        {
            InitializeComponent();
            SchulerViewModel vm = new SchulerViewModel();
            vm.NeuesSchuler = new Models.Schuler()
            {
              
                Firstname = "Firstname",
                ClassNo = 1
            };
            //vm.AddSchuler();

            vm.FillSchuelerFromDB();
            this.DataContext = vm;
        }

        private void MenuItemDelete_Click(object sender, RoutedEventArgs e)
        {
            //SchulerViewModel vm = this.DataContext as SchulerViewModel;
            //vm.DeleteSchuler();
            schulerDBContext.Entry(schuler).State = System.Data.Entity.EntityState.Deleted;
            schulerDBContext.SaveChanges();
            MessageBox.Show("Deleted successfully");
        }

        private void MenuItemNeuesSchuler_Click(object sender, RoutedEventArgs e)
        {
            NeuesSchulerWindow neuesSchulerWindow = new NeuesSchulerWindow();
            SchulerViewModel vm = this.DataContext as SchulerViewModel;
            neuesSchulerWindow.DataContext = vm;
            neuesSchulerWindow.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SchulerViewModel vm = this.DataContext as SchulerViewModel;
            vm.AddSchuler();
        }

        private void ButtonSuchen_Click(object sender, RoutedEventArgs e)
        {
            SchulerViewModel vm = this.DataContext as SchulerViewModel;
            vm.FilterSchueler();

        }
        private void Window_Activated(object sender, EventArgs e)
        {
            SchulerViewModel vm = this.DataContext as SchulerViewModel;
            dgv1.ItemsSource = vm.Schueler.ToList();
            dgv1.Columns[0].Header = "Id";
            dgv1.Columns[1].Header = "Firstname";
            dgv1.Columns[2].Header = "Lastname";
            dgv1.Columns[3].Header = "ClassNo";
        }
        SchulerDBContext schulerDBContext = new SchulerDBContext();
        Schuler schuler = new Schuler();
        private void dgv1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            try
            {
                var row = dgv1.SelectedItem as Schuler;
                int id = Convert.ToInt32((dgv1.SelectedCells[0].Column.GetCellContent(row) as TextBlock).Text);
                schuler = schulerDBContext.Schueler.Where(x => x.SchulerId == id).FirstOrDefault();
                txt_firstname.Text = schuler.Firstname;
                txt_lastname.Text = schuler.Lastname;
                txt_classno.Text = Convert.ToString(schuler.ClassNo);
            }
            catch { }
        }

        private void delete1_Click(object sender, RoutedEventArgs e)
        {
            schulerDBContext.Entry(schuler).State = System.Data.Entity.EntityState.Deleted;
            schulerDBContext.SaveChanges();
            MessageBox.Show("Deleted successfully");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                schuler.Firstname= txt_firstname.Text;
                schuler.Lastname = txt_lastname.Text;
                schuler.ClassNo = int.Parse(txt_classno.Text);
                schulerDBContext.Entry(schuler).State = System.Data.Entity.EntityState.Modified;
                schulerDBContext.SaveChanges();
                MessageBox.Show("Updeted successfully");
            }
            catch { }
        }
    }
}
