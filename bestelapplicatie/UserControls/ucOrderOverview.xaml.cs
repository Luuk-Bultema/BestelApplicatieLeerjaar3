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
    /// Interaction logic for ucOrderOverview.xaml
    /// </summary>
    public partial class ucOrderOverview : UserControl
    {
        dcKassaDataContext db;
        Classes.OrderController myOC;
        Classes.CustomerController myCC;
        public ucOrderOverview(dcKassaDataContext db)
        {
            this.db = db;
            this.myOC = new Classes.OrderController(db);
            this.myCC = new Classes.CustomerController(db);
            InitializeComponent();
            SetData();
            
        }
        void SetData()
        {
            //alle orders ophalen in datagrid
            dgOrders.ItemsSource = myOC.getAllOrders();
            //List<customer> mycustomers = myCC.getAllCustomers();
            dgIPO.ItemsSource = null;
        }

        private void btnWijzig_click(object sender, RoutedEventArgs e)
        {
            if(dgOrders.SelectedItem != null)
            
            {
                //item selecteren uit datagrid
                order selOrder = (order)dgOrders.SelectedItem;
                Windows.wEditOrder myWindow = new Windows.wEditOrder(db, selOrder);
                myWindow.Closing += MyWindow_Closing;
                myWindow.Show();
            
            }
           
        }

        private void MyWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //db = new dcKassaDataContext();
            //myOC = new Classes.OrderController(db);
            SetData();
        }

        private void dgOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //controleren of item uit datagrid orders bestaat
            if (dgOrders.SelectedItem != null)
            {
                //wat doe je hierzo?
                //haalt geselecteerde order uit datagrid op
                order selOrder = (order)dgOrders.SelectedItem;
                //pakt itemperoder van order en zet die in losse datagrid
                dgIPO.ItemsSource = selOrder.itemperorders;
            }
        }
    }

}
