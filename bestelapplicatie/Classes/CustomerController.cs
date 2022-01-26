using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestelapplicatie.Classes
{
    
    class CustomerController
    {
        dcKassaDataContext db;
        
        public CustomerController(dcKassaDataContext db)
        {
            this.db = db;
        }

        public List<customer> getAllCustomers()
        {
            return db.customers.ToList();
        }

     
        public bool createCustomer(string sFirstname, string sLastname, string sCity, string sPhonenumber, string sEmail)
        {
            try
            {
                //instantieren van customers om er een object van te maken zodat er customer gegevens ingevuld kunnen worden
                customer myCustomer = new customer();
                //hierna heb je een object waardoor ook de eigenschappen beschikbaar zijn 
             
                myCustomer.firstname = sFirstname;
                myCustomer.lastname = sLastname;
                myCustomer.city = sCity;
                myCustomer.phonenumber = sPhonenumber;
                myCustomer.email = sEmail;
                //customer toevoegen en in de wacht zetten om definitief opgeslagen te worden
                db.customers.InsertOnSubmit(myCustomer);
                //data daadwerkelijk toevoegen aan de database
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false ;
            }
        }

        public bool editCustomer(int iCustomerId, string sFirstname, string sLastname, string sCity, string sPhonenumber, string sEmail)
        {
            

            try
            {
                //iCustomerId = het customer id
                //customer ophalen uit de database met id 1
                customer myCustomer = (from c in db.customers
                                       where c.customerID == iCustomerId//object selecteren uit de database dat gewijzigd moet worden
                                       select c).FirstOrDefault();
                myCustomer.firstname = sFirstname;//gewijzigde data opslaan in het opgehaalde object
                myCustomer.lastname = sLastname;
                myCustomer.city = sCity;
                myCustomer.phonenumber = sPhonenumber;
                myCustomer.email = sEmail;
                //data daadwerkelijk verwerken in de database
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public bool deleteCustomer(int iCustomerId)
        {
            try
            {
                //iCustomerId = het customer id
                //customer ophalen uit de database met id 1
                customer myCustomer = (from c in db.customers
                                       where c.customerID == iCustomerId//object selecteren uit de database dat gedelete moet worden
                                       select c).FirstOrDefault();
                //customer in de wacht zetten om definitef gedelete te worden
                db.customers.DeleteOnSubmit(myCustomer);
                //data daadwerkelijk verwerken in de database
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
