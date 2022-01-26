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
    /// Interaction logic for ucFactuur.xaml
    /// </summary>
    public partial class ucFactuur : UserControl
    {

        dcKassaDataContext db;
        Classes.CustomerController myCC;
        Classes.OrderController myOC;
        Classes.DateController myDC;
        Classes.FactuurController myFC;
        public ucFactuur(dcKassaDataContext db)
        {

            this.db = db;
            this.myCC = new Classes.CustomerController(db);
            this.myOC = new Classes.OrderController(db);
            this.myDC = new Classes.DateController(db);
            this.myFC = new Classes.FactuurController(db);
            InitializeComponent();
            SetData();
        }

        void SetData()
        {
            List<customer> mycustomers = myCC.getAllCustomers();
            /*
            dgCustomers.ItemsSource = mycustomers;
            */
            cmbKlant.ItemsSource = myCC.getAllCustomers();

            /*cmbDate.Items.Add(DateTime.Now.ToString("dd/MM/yyyy hh:mm"));


            /*
            dgCustomers.ItemsSource = myOC.getAllOrders();
            dgIPO.ItemsSource = null;
            */

        }

      
        private void cmbKlant_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (cmbKlant.SelectedItem != null)
            {
                {
                    customer selCustomer = (customer)cmbKlant.SelectedItem;
                    txtFirstname.Content = selCustomer.firstname;//txtFirstname.Text vullen met de data van het geselecteerde item
                    txtLastname.Content = selCustomer.lastname;
                    txtCity.Content = selCustomer.city;
                    txtPhonenumber.Content = selCustomer.phonenumber;
                    txtEmail.Content = selCustomer.email;
                    lblSelCustId.Content = selCustomer.customerID;
                    dgCustomers.ItemsSource = selCustomer.orders.ToList();


                }


            }


        }
        

        private void dgCustomers_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void dgCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (dgCustomers.SelectedItem != null)
            {
                order selOrder = (order)dgCustomers.SelectedItem;
                dgIPO.ItemsSource = selOrder.itemperorders;
            }

        }

        private void btnselectCustomer_Click(object sender, RoutedEventArgs e)
        {
            /*
            if (cmbKlant.SelectedItem != null)
            {
                // item selecteren uit combobox customer
                customer selCustomer = (customer)cmbKlant.SelectedItem;



                /*
                if (cmbKlant.SelectedItem != null)
                {
                    /*
                    // instantieren van nieuwe entiteit itemperorder, object van maken
                    itemperorder myIPO = new itemperorder();
                    //itemperorder vullen met data, hoeveelheid en producten
                    myIPO.amount = Convert.ToInt32(txtAantal.Text);
                    myIPO.product = (product)cmbKlant.SelectedItem;
                    */
            /*
            customer myCustomer = new customer();
            myCustomer.customerID = Convert.ToInt32(lblSelCustId.Content);
            // items toevoegen aan de datagrid
            dgCustomers.Items.Add(myCustomer);
            */
        }

        private void btnBestelperDatum(object sender, RoutedEventArgs e)
        {
            if (cmbKlant.SelectedItem != null)
            {
                {
                    customer selCustomer = (customer)cmbKlant.SelectedItem;
                    txtFirstname.Content = selCustomer.firstname;//txtFirstname.Text vullen met de data van het geselecteerde item
                    txtLastname.Content = selCustomer.lastname;
                    txtCity.Content = selCustomer.city;
                    txtPhonenumber.Content = selCustomer.phonenumber;
                    txtEmail.Content = selCustomer.email;
                    lblSelCustId.Content = selCustomer.customerID;
                    dgCustomers.ItemsSource = selCustomer.orders.ToList();
                }




            }



            /*
                if (cmbKlant.SelectedItem != null)
                {
                SetData();
                MessageBox.Show("Klant is succesvol opgeslagen!");

                }
                else
                {
                    MessageBox.Show("Er is helaas iets misgegaan met het opslaan van de klant!");
                }
            }
            */


        }

        private void bpdate1(object sender, SelectionChangedEventArgs e)
        {


            /*
            private void btnShowOrder_Click(object sender, RoutedEventArgs e)
            {
                if (cmbKlant.SelectedItem != null)
                {
                    dgIPO.ItemsSource = myOC.getAllOrders();
                }
            }

        */


        }

        private void btnSelectTimePeriod_Click(object sender, RoutedEventArgs e)
        {
            // Startdatum ophalen en opslaan in een variable
            // Einddatum ophalen en opslaan in een variable
            // Klantid ophalen en opslaan in een variable

            // Query maken om de orders op te halen, filter (where) op klantid, en datum (orderdatum groter dan startdatum en kleiner dan einddatum.
            // Deze lijst als itemssource gebruiken voor je datagrid


            DatePicker dp = new DatePicker();
           
            DateTime date1 = this.DPdate1.SelectedDate.Value.Date;
            DateTime date2 = this.DPdate2.SelectedDate.Value.Date;
            int Klantid = ((customer)this.cmbKlant.SelectedItem).customerID;
            if (date1 == null)
            {
                MessageBox.Show("Er is geen begindatum");
            }
            else
            {
                if (date2 == null)
                {
                    MessageBox.Show("Er is geen einddatum");
                }
                else
                {
 
                    if(Klantid == null)
                    {
                        MessageBox.Show("Geen klant id kunnen ophalen");

                    }
                    else
                    {
                        var  orders = (from order in db.orders where (order.date >= date1 && order.date <= date2) &&  order.customerID == Klantid select order).ToList();
                        dgCustomers.ItemsSource = orders.ToList();
                    }
                }

               
            }
            





            /* 
             DatePicker dp = new DatePicker();
             dp.DisplayDateStart = DPdate1.SelectedDate;
             dp.DisplayDateEnd = DPdate2.SelectedDate;
             */

            /*
            if (cmbKlant.SelectedItem != null)
            {
                // item selecteren uit combobox customer
                customer selCustomer = (customer)cmbKlant.SelectedItem;
                order myOrder = myOC.createOrder(selCustomer);
            }

        */


            /*
            string myDate = DatePicker.SelectedDateChangedEvent.ToString(); 
            */
            /*
            if (DPdate1.SelectedDate != null)
            {
                {
                    order selCustomer = DPdate1.SelectedDate;

                    dgCustomers.ItemsSource = selCustomer.ToLongDateString();
                }

            }
            */
        }
    }
}

    




