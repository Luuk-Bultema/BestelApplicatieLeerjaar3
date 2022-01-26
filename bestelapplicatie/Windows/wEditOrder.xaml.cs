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

namespace bestelapplicatie.Windows
{
    /// <summary>
    /// Interaction logic for wEditOrder.xaml
    /// </summary>
    public partial class wEditOrder : Window
    {
        dcKassaDataContext db;
        order myOrder;
        Classes.CustomerController myCC;
        Classes.ItemPerOrderController myIPOC;
        Classes.OrderController myOC;
        public wEditOrder(dcKassaDataContext db, order myOrder)
        {
            this.db = db;
            this.myOrder = myOrder;
            this.myCC = new Classes.CustomerController(db);
            this.myIPOC = new Classes.ItemPerOrderController(db);
            this.myOC = new Classes.OrderController(db);
            InitializeComponent();
            SetData();
        }

        void SetData()
        {
            //cmbDate.Items.Add(DateTime.Now.ToString("dd/MM/yyyy hh:mm"));

            cmbCustomer.ItemsSource = myCC.getAllCustomers();
            dgIPOs.ItemsSource = myOrder.itemperorders;
            //cmbCustomer.SelectedItem = myOrder.customer;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SetData();
        }

        private void cmbCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbCustomer.SelectedItem != null)
            {
                customer selCustomer = (customer)cmbCustomer.SelectedItem;
                txtFirstname.Content = selCustomer.firstname;
                txtLastname.Content = selCustomer.lastname;
                txtCity.Content = selCustomer.city;
                txtPhonenumber.Content = selCustomer.phonenumber;
                txtEmail.Content = selCustomer.email;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            /*if (cmbCustomer.SelectedItem != null)
            { 

            customer selCustomer = (customer)cmbCustomer.SelectedItem;
            if (myOC.EditOrderCustomer(myOrder, selCustomer))

            {
                
                MessageBox.Show("Bestelling succesvol gewijzigd!");
            }
            else
            {
                MessageBox.Show("Er is iets misgegaan met het wijzigen van de bestelling");
            }
         
            }

            */

            if (cmbCustomer.SelectedItem != null)
            {
                customer selCustomer = (customer)cmbCustomer.SelectedItem;
               

                if (myOC.EditOrderCustomer(myOrder, selCustomer))
                {
                    
                    MessageBox.Show("Klant succesvol aan bestelling gekoppeld!");
                }
                else
                {
                    MessageBox.Show("Er is iets misgegaan met het koppelen van de bestelling aan de klant!");
                }

            }


        }

     

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (myOC.DeleteOrder(myOrder))
            {
                MessageBox.Show("Order succesvol verwijderd!");
            }
            else
            {
                MessageBox.Show("Er is helaas iets misgegaan met het verwijderen van de order");
            }
        }

        private void btnVerwijderIPOs_click(object sender, RoutedEventArgs e)
        {
            if(dgIPOs.SelectedItem !=null)
            {
                itemperorder myIPOs = (itemperorder)dgIPOs.SelectedItem;
                if(myIPOC.deleteItemPerOrders(myIPOs))
                {
                    SetData();
                    MessageBox.Show("Item per order is succesvol verwijderd!");
                }
                else
                {
                    MessageBox.Show("Er is helaas iets misgegaan met het verwijderen van de item per order");
                }
            }
        }
    }
}
