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
    /// Interaction logic for wEditProduct.xaml
    /// </summary>
    public partial class wEditProduct : Window
    {
        //connectie maken met database en controllers aanspreken
        dcKassaDataContext db;
        Classes.ProductController myPC;
        Classes.ProducttypeController myPTC;
        product myProduct;

        public wEditProduct(dcKassaDataContext db, product myProduct)
        {
            //aanspreken database en controllers
            this.db = db;
            this.myPC = new Classes.ProductController(db);
            this.myPTC = new Classes.ProducttypeController(db);
            this.myProduct = myProduct;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //aanspreken product controller met  functie editProduct, meegeven variabelen myProduct, txtName en txtPrice, combobox producttype meegeven en typecasten 
            if (myPC.editProduct(myProduct, txtName.Text, Convert.ToDecimal(txtPrice.Text), (producttype)cmbProducttype.SelectedItem))
            {
                MessageBox.Show("Product succesvol aangepast!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Er is helaas iets misgegaan met het wijzigen van het product");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //product controller aanspreken met delete functie, meegeven variabele myProduct
            if (myPC.deleteProduct(myProduct))
            MessageBox.Show("Product is succesvol verwijderd!");
            this.Close();
        }
        
    }
}
