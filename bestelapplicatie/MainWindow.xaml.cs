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

namespace bestelapplicatie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        dcKassaDataContext db = new dcKassaDataContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, RoutedEventArgs e)
        {
            frMain.Content = new UserControls.ucCustomers(db);
        }

        private void btnProducts_Click(object sender, RoutedEventArgs e)
        {
            frMain.Content = new UserControls.ucProducts(db);
        }

        private void BtnBestellingen_Click(object sender, RoutedEventArgs e)
        {
            frMain.Content = new UserControls.UcOrders(db);
        }

        private void btnBestellingBekijken_Click(object sender, RoutedEventArgs e)
        {
            frMain.Content = new UserControls.ucOrderOverview(db); 
        }

        private void BtnFactuur_Click(object sender, RoutedEventArgs e)
        {
            frMain.Content = new UserControls.ucFactuur(db);
        }

     
    }
}
