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

namespace bestelapplicatie.UserControls
{
    /// <summary>
    /// Interaction logic for UcOrders.xaml
    /// </summary>
    public partial class UcOrders : UserControl
    {
        //importeren database en controller
        dcKassaDataContext db;
        Classes.CustomerController myCC;
        Classes.ProducttypeController myPTC;
        Classes.OrderController myOC;
        Classes.ItemPerOrderController myIPOC;
        public UcOrders(dcKassaDataContext db)
        {
            //instantieren van database en controllers
            this.db = db;
            this.myCC = new Classes.CustomerController(db);
            this.myPTC = new Classes.ProducttypeController(db);
            this.myOC = new Classes.OrderController(db);
            this.myIPOC = new Classes.ItemPerOrderController(db);
            
        
            InitializeComponent();
            SetData();
        }

        void SetData()
        {
            //geeft lijst van producttypes weer in combobox
            cmbProducttype.ItemsSource = myPTC.getAllProducttypes();
            //geeft lijst weer van alle customers in combobox
            cmbCustomer.ItemsSource = myCC.getAllCustomers();
        }

        private void cmbProducttype_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {// controleren of geselecteerde item producttype bestaat
            if (cmbProducttype.SelectedItem != null)
            {
                //producttype item selecteren 
                producttype selPT = (producttype)cmbProducttype.SelectedItem;
                //lijst ophalen van producten in combobox product
                cmbProduct.ItemsSource = selPT.products.ToList();
            }
        }

        private void btnAddToOrder_Click(object sender, RoutedEventArgs e)
        {
            //controleren of geselecteerde item product bestaat
            if (cmbProduct.SelectedItem != null)
            {
                // instantieren van nieuwe entiteit itemperorder, object van maken
                itemperorder myIPO = new itemperorder();
                //itemperorder vullen met data, hoeveelheid en producten
                myIPO.amount = Convert.ToInt32(txtAantal.Text);
                myIPO.product = (product)cmbProduct.SelectedItem;
                // items toevoegen aan de datagrid
                dgbestelling.Items.Add(myIPO);
            }
        }

        private void cmbCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //controleren of geselecteerde item klant bestaat
            if (cmbCustomer.SelectedItem != null)
            {
                //item klant selecteren 
                customer selCustomer = (customer)cmbCustomer.SelectedItem;
                //item vullen met data van de klant
                lblLastname.Content = selCustomer.lastname;
                lblFirstname.Content = selCustomer.firstname;
                lblCity.Content = selCustomer.city;
                lblPhonenumber.Content = selCustomer.phonenumber;
                lblEmail.Content = selCustomer.email;
            }
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            //controleren of geselecteerde item uit combobox bestaat
            if(cmbCustomer.SelectedItem != null)
            {
                // item selecteren uit combobox customer
                customer selCustomer = (customer)cmbCustomer.SelectedItem;
                order myOrder = myOC.createOrder(selCustomer);

                //ophalen van lijst item per orders, maakt nieuwe lijst van om onderin te vullen
                List<itemperorder> myIPOs = new List<itemperorder>();
                //je maakt van de datagrid een lijst met itemperorders
                foreach (itemperorder myIPO in dgbestelling.Items)
                {
                    //voeg je datagrid item toe aan lijst met item per orders
                    myIPOs.Add(myIPO);
                }
                if (myIPOC.createItemPerOrders(myIPOs, myOrder))
                {
                    MessageBox.Show("Bestelling succesvol opgeslagen!");
                }
                else
                {
                    MessageBox.Show("Er is helaas iets misgegaan met het toevoegen van de bestelling!");
                }
                
            }
        }

        private void btnDeleteIPO_Click(object sender, RoutedEventArgs e)
        {
            //controleren of geselecteerde item uit datagrid bestaat
            if (dgbestelling.SelectedItem != null)
            {
                //verwijderen van de items uit de datagrid
                dgbestelling.Items.Remove(dgbestelling.SelectedItem);
            }
        }
    }
}
