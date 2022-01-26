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
    /// Interaction logic for wManageProductType.xaml
    /// </summary>
    public partial class wManageProductType : Window
    {
        //connectie maken met database en controllers aanspreken
        dcKassaDataContext db;
        Classes.ProducttypeController myPTC;
        public wManageProductType(dcKassaDataContext db)
        {
            //aanspreken database en controllers
            this.db = db;
            this.myPTC = new Classes.ProducttypeController(db);
            InitializeComponent();
            SetData();
        }

        void SetData()
        {
            //lijst weergeven met alle producttypes in combobox
            cmbPT.ItemsSource = myPTC.getAllProducttypes();
            
        }

        private void btnAddPT_Click(object sender, RoutedEventArgs e)
        {
            //aanspreken producttype controller toevoegen,txtDescription meegeven 
            if (myPTC.addProductType(txtDescription.Text))
            {
               
                MessageBox.Show("Producttype succesvol toegevoegd!");
            }
            else
            {
                MessageBox.Show("Er is helaas iets misgegaan met het toevoegen van het product");
            }
        }

        private void cmbPT_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //controleren of item bestaat 
            if (cmbPT.SelectedItem != null)
            {
                //item selecteren uit combobox 
                producttype selPT = (producttype)cmbPT.SelectedItem;
                //data vullen met producttypeomschrijving
                txtDescriptionEdit.Text = selPT.producttypeomschrijving;
            }

        }

        private void btnEditPT_Click(object sender, RoutedEventArgs e)
        {
            //controleren of item bestaat 
            if (cmbPT.SelectedItem != null)
            {
                // item selecteren uit combobox 
                producttype selPT = (producttype)cmbPT.SelectedItem;
                //producttype controller aanspreken om te editen, meegeven variabele selPT van net om te editen en je txtDescriptionEdit text vak
                if (myPTC.editProductType(selPT, txtDescriptionEdit.Text))
                {
                    MessageBox.Show("Producttype succesvol aangepast!");
                }
                else
                {
                    MessageBox.Show("Er is helaas iets misgegaan met het editen van het producttype");
                }

            }
        }

        private void btnDeletePT_Click(object sender, RoutedEventArgs e)
        {
            //controleren of item bestaat
            if (cmbPT.SelectedItem != null)
            {
                // item selecteren uit combobox
                producttype selPT = (producttype)cmbPT.SelectedItem;
                //producttype controller aanspreken met delete functie, meegeven variabele selPT van net
                if (myPTC.deleteProductType(selPT))
                {
                    MessageBox.Show("Producttype succesvol verwijderd!");

                }
                else
                {
                    MessageBox.Show("Er is helaas iets misgegaan met het verwijderen van het producttype");
                }
            }
        }
    }
}
