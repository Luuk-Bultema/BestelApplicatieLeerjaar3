using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestelapplicatie.Classes
{
    class ProductController
    {
        dcKassaDataContext db;


        public ProductController(dcKassaDataContext db)
        {
            this.db = db;
        }

        public List<product> getAllProducts()
        {
            return db.products.ToList();
        }

        public bool createProduct(string sproductnaam, decimal dprijs, producttype myPT)
        {
            try
            {
                //instantieren van tabel producten, je maakt hier een object van
                product myproduct = new product();
                myproduct.productName = sproductnaam;
                myproduct.producttypeid = myPT.producttypeID;
                myproduct.price = dprijs;

                //product toevoegen en in de wacht zetten om definitief opgeslagen te worden
                db.products.InsertOnSubmit(myproduct);
                //data daadwerkelijk toevoegen aan de database
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
           
        }
        public bool editProduct(product myProduct, string sName, decimal dPrice, producttype myP)
        {
            try
            {
                myProduct.productName = sName;
                myProduct.price = dPrice;
                myProduct.producttype = myP;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteProduct(product myproduct)
        {
            try
            {
                db.products.DeleteOnSubmit(myproduct);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
