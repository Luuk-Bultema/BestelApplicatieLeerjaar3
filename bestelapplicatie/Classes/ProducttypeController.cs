using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestelapplicatie.Classes
{
    class ProducttypeController
    {
        //connectie maken met database
        dcKassaDataContext db;

        public ProducttypeController(dcKassaDataContext db)
        {
            this.db = db;
        }

        //ophalen lijst van producttypes
        public List<producttype> getAllProducttypes()
        {
            return db.producttypes.ToList();
        }

       public bool addProductType(string sDescription)
        {
            try            
            {
                //instantieren van entiteit object van maken
                producttype myPT = new producttype();
                myPT.producttypeomschrijving = sDescription;
                db.producttypes.InsertOnSubmit(myPT);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
      
        public bool editProductType(producttype myPT, string sDescription)
        {
            try
            {
                //data vullen met producttypeomschrijving om te editen
                myPT.producttypeomschrijving = sDescription;
                // het editen daadwerkelijk doorvoeren naar de database
                db.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool deleteProductType(producttype myPT)
        {
            try
            {
                //in de wachtrij zetten van het verwijderen van de producttypes uit de database 
                db.producttypes.DeleteOnSubmit(myPT);
                // het verwijderen daadwerkelijk doorvoeren naar de database
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
